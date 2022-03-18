---
-api-id: E:Windows.Gaming.Input.RawGameController.HeadsetDisconnected
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler HeadsetDisconnected<IGameController, Headset>
-->

# Windows.Gaming.Input.RawGameController.HeadsetDisconnected

## -description

Signals when a headset is disconnected from the raw game controller.

## -remarks

For more information on detecting, tracking, and using headsets, see [Headset](/windows/uwp/gaming/headset).

## -see-also

[Windows.Gaming.Input.IGameController](igamecontroller.md), [Windows.Gaming.Input.Headset](headset.md)

## -examples

The following example shows how to register a handler for this event.

```cppwinrt
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
RawGameController m_rawGameController{ nullptr }; // Need to initialize this to a **RawGameController** that's connected to the device.
...
m_rawGameController.HeadsetDisconnected([this](IGameController const& /* sender */, Headset const& /* args */)
    {
        // Disable headset capture and playback on this device.
    });
```

```cppcx
// `rawGameController` is a **RawGameController** that's connected to the device.
rawGameController.HeadsetDisconnected += ref new TypedEventHandler<IGameController^, Headset^>(
        [] (IGameController^ device, Headset^ headset)
{
    // DIsable headset capture and playback on this device.
});
```