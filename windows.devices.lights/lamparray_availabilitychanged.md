---
-api-id: E:Windows.Devices.Lights.LampArray.AvailabilityChanged
-api-type: winrt event
---

# Windows.Devices.Lights.LampArray.AvailabilityChanged

<!--
public event Windows.Foundation.TypedEventHandler<Windows.Devices.Lights.LampArray,object> AvailabilityChanged;
-->

## -description

Is raised when the value of [IsAvailable](lamparray_isavailable.md) changes; which can happen when the user changes system access to the device through the device settings.

The event handler's parameters are the sender [LampArray](./lamparray.md) whose property has changed, and an **Object** (which is always null).

## -remarks

Both foreground and background ("ambient") apps can receive and handle this event.

To use this event, you must declare the "com.microsoft.windows.lighting" AppExtension in the app manifest. For details about how to do that, see [Create and host an app extension](/windows/uwp/launch-resume/how-to-create-an-extension).

```xml
<Extensions>
    <uap3:Extension Category="windows.appExtension">
        <uap3:AppExtension Name="com.microsoft.windows.lighting" Id="Id" DisplayName="Id">
        </uap3:AppExtension> 
    </uap3:Extension>
</Extensions>
```

## -examples

:::row:::
    :::column:::

        [LampArray sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/LampArray)
        
        Demonstrates how to control RGB lighting of peripheral devices using the [**Windows.Devices.Lights**](/uwp/api/windows.devices.lights) and [**Windows.Devices.Lights.Effects**](/uwp/api/windows.devices.lights.effects) APIs.

    :::column-end:::
    :::column:::

        [AutoRGB Sample](https://github.com/microsoft/Dynamic-Lighting-AutoRGB)
        
        Demonstrates how to extract a single, representative color from a desktop screen and use it to illuminate LED lamps on a connected RGB device.
            
    :::column-end:::
:::row-end:::

### AvailabilityChanged event example

The following example shows how to set up a handler for an <xref:Windows.Devices.Lights.Lamp.AvailabilityChanged> event. Note how the code first checks whether the <xref:Windows.Devices.Lights.LampArray.IsAvailable> property is available before declaring the handler.

```csharp
using System;
using System.Collections.Generic;
using Windows.Devices.Enumeration;
using Windows.Devices.Lights;

namespace Sample
{
    class LampArrayHelper
    {
        private readonly DeviceWatcher watcher;
        private readonly Dictionary<string, LampArray> lampArrays;
        private readonly Dictionary<string, LampArrayEffectPlaylist> playlists;

        public LampArraySample()
        {
            lampArrays = new Dictionary<string, LampArray>();
            playlists = new Dictionary<string, LampArrayEffectPlaylist>();

            watcher = DeviceInformation.CreateWatcher(LampArray.GetDeviceSelector());

            watcher.Added += Watcher_Added;
            watcher.Removed += Watcher_Removed;

            watcher.Start();
        }

        private void DoEffectSetup(LampArray device)
        {
            Console.WriteLine("Starting effect playlist...");

            var indices = Enumerable.Range(0, device.LampCount).ToArray();

            var effect = new LampArraySolidEffect(device, indices)
            {
                Color = Colors.Red,
                CompletionBehavior = LampArrayEffectCompletionBehavior.KeepState,
                Duration = TimeSpan.FromMilliseconds(3000)
            };

            var effect2 = new LampArraySolidEffect(device, indices)
            {
                Color = Colors.Blue,
                CompletionBehavior = LampArrayEffectCompletionBehavior.KeepState,
                Duration = TimeSpan.FromMilliseconds(3000)
            };

            var playlist = new LampArrayEffectPlaylist();
            playlist.Append(effect);
            playlist.Append(effect2);
            playlist.Start();

            lock (playlists)
            {
                playlists.Add(device.DeviceId, playlist);
            }
        }

        private async void Watcher_Added(DeviceWatcher sender, DeviceInformation args)
        {
            var lampArray = await LampArray.FromIdAsync(args.Id);

            lock (lampArrays)
            {
                lampArrays[args.Id] = lampArray;
            }

            if (lampArray.LampArrayKind == LampArrayKind.Headset)
            {
                Console.WriteLine("Headset LampArray attached: " + lampArray.DeviceId);
            }

            if (ApiInformation.IsPropertyPresent("Windows.Devices.Lights.LampArray", "IsAvailable"))
            {
                if (lampArray.IsAvailable)
                {
                    DoEffectSetup(lampArray);
                }

                lampArray.AvailabilityChanged += LampArray_AvailabilityChanged;
            }
            else
            {
                DoEffectSetup(lampArray);
            }
        }

        private void Watcher_Removed(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            lock (lampArrays)
            {
                lampArrays.Remove(args.Id);
            }

            lock (playlists)
            {
                if (playlists.ContainsKey(args.Id))
                {
                    playlists[args.Id].Stop();
                    playlists.Remove(args.Id);
                }
            }
        }

        private void LampArray_AvailabilityChanged(LampArray sender, object args)
        {
            if (sender.IsAvailable)
            {
                Console.WriteLine("Device available: " + sender.DeviceId);
                DoEffectSetup(sender);
            }
            else
            {
                Console.WriteLine("Device unavailable: " + sender.DeviceId);

                lock (playlists)
                {
                    if (playlists.ContainsKey(sender.DeviceId))
                    {
                        playlists[sender.DeviceId].Stop();
                        playlists.Remove(sender.DeviceId);
                    }
                }
            }
        }
    }
}
```

```cppwinrt
#include <windows.h>

#include <algorithm>
#include <memory>
#include <numeric>
#include <vector>
#include <map>

#include <wil/resource.h>

#include <winrt/base.h>
#include <winrt/windows.devices.lights.h>
#include <winrt/windows.devices.lights.effects.h>
#include <winrt/windows.devices.enumeration.h>
#include <winrt/windows.foundation.h>
#include <winrt/windows.foundation.metadata.h>
#include <winrt/windows.ui.h>

namespace winrt
{
    using namespace winrt::Windows::Devices::Enumeration;
    using namespace winrt::Windows::Devices::Lights;
    using namespace winrt::Windows::Devices::Lights::Effects;
    using namespace winrt::Windows::Foundation;
    using namespace winrt::Windows::Foundation::Metadata;
    using namespace winrt::Windows::UI;
}

wil::srwlock lampArraysLock;
std::shared_ptr<std::map<winrt::hstring, winrt::LampArray>> lampArrays;

wil::srwlock playlistsLock;
std::shared_ptr<std::map<winrt::hstring, winrt::LampArrayEffectPlaylist>> playlists;
 
void DoEffectSetup(winrt::LampArray device)
{
    wprintf(L"Starting effect playlist...\n");

    std::vector<int32_t> indices(device.LampCount());
    std::iota(indices.begin(), indices.end(), 0);

    auto effect = winrt::LampArraySolidEffect(device, indices);
    effect.Color(winrt::Colors::Red());
    effect.CompletionBehavior(winrt::LampArrayEffectCompletionBehavior::KeepState);
    effect.Duration(std::chrono::milliseconds(3000));

    auto effect2 = winrt::LampArraySolidEffect(device, indices);
    effect2.Color(winrt::Colors::Blue());
    effect2.CompletionBehavior(winrt::LampArrayEffectCompletionBehavior::KeepState);
    effect2.Duration(std::chrono::milliseconds(3000));

    auto playlist = winrt::LampArrayEffectPlaylist();
    playlist.RepetitionMode(winrt::LampArrayRepetitionMode::Forever);

    playlist.Append(effect);
    playlist.Append(effect2);
    playlist.Start();

    auto lock = playlistsLock.lock_exclusive();
    playlists->emplace(std::make_pair(device.DeviceId(), playlist));
}
 
int __cdecl main()
{
    lampArrays = std::make_shared<std::map<winrt::hstring, winrt::LampArray>>();
    playlists = std::make_shared<std::map<winrt::hstring, winrt::LampArrayEffectPlaylist>>();
 
    auto deviceWatcher = winrt::DeviceInformation::CreateWatcher(winrt::LampArray::GetDeviceSelector());
 
    auto deviceAddedRevoker = deviceWatcher.Added(winrt::auto_revoke, [](winrt::DeviceWatcher, winrt::DeviceInformation info)
    {
        auto deviceId = info.Id();
        auto lampArray = winrt::LampArray::FromIdAsync(deviceId).get();

        if (lampArray)
        {
            wprintf(L"LampArray %s added\n", deviceId.c_str());
     
            {
                auto lock = lampArraysLock.lock_exclusive();
                lampArrays->emplace(std::make_pair(deviceId, lampArray));
            }
     
            if (winrt::ApiInformation::IsPropertyPresent(L"Windows.Devices.Lights.LampArray", L"IsAvailable"))
            {
                if (lampArray.IsAvailable())
                {
                    DoEffectSetup(lampArray);
                }
     
                lampArray.AvailabilityChanged([](winrt::LampArray device, winrt::IInspectable)
                {
                    if (device.IsAvailable())
                    {
                        wprintf(L"Device available: %s\n", device.DeviceId().c_str());
                        DoEffectSetup(device);
                    }
                    else
                    {
                        wprintf(L"Device unavailable: %s\n", device.DeviceId().c_str());
                        
                        auto lock = playlistsLock.lock_exclusive();

                        auto entry = playlists->find(device.DeviceId());
                        if (entry != playlists->end())
                        {
                            entry->second.Stop();
                            playlists->erase(entry);
                        }
                    }
                });
            }
            else
            {
                DoEffectSetup(lampArray);
            }
        }
    });
 
    auto deviceRemovedRevoker = deviceWatcher.Removed(winrt::auto_revoke, [](winrt::DeviceWatcher, winrt::DeviceInformationUpdate info)
    {
        auto deviceId = info.Id();

        {
            auto lock = lampArraysLock.lock_exclusive();
            lampArrays->erase(deviceId);
        }

        {
            auto lock = playlistsLock.lock_exclusive();

            auto entry = playlists->find(deviceId);
            if (entry != playlists->end())
            {
                entry->second.Stop();
                playlists->erase(entry);
            }
        }

        wprintf(L"LampArray %s removed\n", deviceId.c_str());
    });
 
    deviceWatcher.Start();
 
    wprintf(L"Press any key to exit\n");
    getchar();
 
    deviceWatcher.Stop();
 
    return 0;
}
```

## -see-also

[IsAvailable](lamparray_isavailable.md), [Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)
