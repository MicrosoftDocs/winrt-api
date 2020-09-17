---
-api-id: E:Windows.Gaming.Input.FlightStick.HeadsetConnected
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler HeadsetConnected<IGameController, Headset>
-->

# Windows.Gaming.Input.FlightStick.HeadsetConnected

## -description

Signals when a headset is attached to the flight stick.

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
m_flightStick.HeadsetConnected([this](IGameController const& /* sender */, Headset const& /* args */)
    {
        // Enable headset capture and playback on this device.
    });
```

```cppcx
`flightStick` is a **FlightStick** that's connected to the device.
flightStick.HeadsetConnected += ref new TypedEventHandler<IGameController^, Headset^>(
    [] (IGameController^ device, Headset^ headset)
{
    // Enable headset capture and playback on this device.
});
```