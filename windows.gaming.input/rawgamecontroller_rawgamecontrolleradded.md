---
-api-id: E:Windows.Gaming.Input.RawGameController.RawGameControllerAdded
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler RawGameControllerAdded<RawGameController>
-->

# Windows.Gaming.Input.RawGameController.RawGameControllerAdded

## -description

Signals when a new raw game controller is connected.

## -remarks

To identify controllers that have already been added, you query the list of connected controllers using [RawGameController.RawGameControllers](rawgamecontroller_rawgamecontrollers.md). However, because you might only be interested in some of the connected raw game controllers, we recommend that you maintain your own collection instead of accessing them through **RawGameControllers**.

## -see-also

## -examples

The following example starts tracking a raw game controller that's been added. `myRawGameControllers` is a `Vector<RawGameController^>` that contains the raw game controllers that your game is tracking.

```cpp
RawGameController::RawGameControllerAdded += ref new EventHandler<RawGameController^>(
		[] (Platform::Object^, RawGameController^ args)
{
    // This code assumes that you're interested in all new raw game controllers.
    myRawGameControllers->Append(args);
});
```