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

For more information on detecting, tracking, and using headsets, see [Headset](https://docs.microsoft.com/windows/uwp/gaming/headset).

## -see-also

* [Windows.Gaming.Input.IGameController](igamecontroller.md)
* [Windows.Gaming.Input.Headset](headset.md)

## -examples

The following example shows how to register a handler for this event. `flightStick` is a **FlightStick** that's connected to the device.

```cpp
flightStick.HeadsetConnected += ref new TypedEventHandler<IGameController^, Headset^>(
    [] (IGameController^ device, Headset^ headset)
{
    // Enable headset capture and playback on this device.
});
```