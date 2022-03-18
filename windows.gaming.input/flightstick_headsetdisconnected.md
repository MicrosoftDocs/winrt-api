---
-api-id: E:Windows.Gaming.Input.FlightStick.HeadsetDisconnected
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler HeadsetDisconnected<IGameController, Headset>
-->

# Windows.Gaming.Input.FlightStick.HeadsetDisconnected

## -description

Signals when a headset is disconnected from the flight stick.

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
FlightStick m_flightStick{ nullptr }; // Need to initialize this to a **FlightStick** that's connected to the device.
...
m_flightStick.HeadsetDisconnected([this](IGameController const& /* sender */, Headset const& /* args */)
    {
        // Disable headset capture and playback on this device.
    });
```

```cppcx
// `flightStick` is a **FlightStick** that's connected to the device.
flightStick.HeadsetDisconnected += ref new TypedEventHandler<IGameController^, Headset^>(
    [] (IGameController^ device, Headset^ headset)
{
    // Disable headset capture and playback on this device.
});
```