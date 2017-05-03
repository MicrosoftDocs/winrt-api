---
-api-id: E:Windows.Gaming.Input.RawGameController.RawGameControllerRemoved
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler RawGameControllerRemoved<RawGameController>
-->

# Windows.Gaming.Input.RawGameController.RawGameControllerRemoved

## -description

Signals when a raw game controller is disconnected.

## -remarks

The following example stops tracking a raw game controller that's been removed. `myRawGameControllers` is a `Vector<RawGameController^>` that contains the raw game controllers that your game is tracking.

```cpp
RawGameController::RawGameControllerRemoved += 
    ref new EventHandler<RawGameController^>(
        [] (Platform::Object^, RawGameController^ args)
{
    unsigned int indexRemoved;

    if (myRawGameControllers->IndexOf(args, &indexRemoved))
    {
        myRawGameControllers->RemoveAt(indexRemoved);
    }
});
```

## -see-also

## -examples
