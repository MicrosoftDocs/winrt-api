---
-api-id: E:Windows.Gaming.Input.RawGameController.HeadsetConnected
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler HeadsetConnected<IGameController, Headset>
-->

# Windows.Gaming.Input.RawGameController.HeadsetConnected

## -description

Signals when a headset is attached to the raw game controller.

## -remarks

For more information on detecting, tracking, and using headsets, see [Headset](https://docs.microsoft.com/windows/uwp/gaming/headset).

## -see-also

* [Windows.Gaming.Input.IGameController](igamecontroller.md)
* [Windows.Gaming.Input.Headset](headset.md)

## -examples

The following example shows how to register a handler for this event. `rawGameController` is a **RawGameController** that's connected to the device.

```cpp
rawGameController.HeadsetConnected += ref new TypedEventHandler<IGameController^, Headset^>(
		[] (IGameController^ device, Headset^ headset)
{
    // Enable headset capture and playback on this device.
});
```