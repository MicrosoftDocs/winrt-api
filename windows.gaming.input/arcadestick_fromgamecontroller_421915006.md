---
-api-id: M:Windows.Gaming.Input.ArcadeStick.FromGameController(Windows.Gaming.Input.IGameController)
-api-type: winrt method
---

<!-- Method syntax.
public ArcadeStick ArcadeStick.FromGameController(IGameController gameController)
-->

# Windows.Gaming.Input.ArcadeStick.FromGameController

## -description

Returns the given game controller as an arcade stick.

## -params

## -param gameController

The game controller to be returned as an arcade stick.

## -returns

The arcade stick that was returned from the given game controller.

## -remarks

## -see-also

* [Windows.Gaming.Input.IGameController](igamecontroller.md)

## -examples

<!--In the following example, the app gets the first available [RawGameController](rawgamecontroller.md) object, and tries to access this game controller via the `ArcadeStick` class.

```csharp
ArcadeStick arcadeStick = null;

if (RawGameController.RawGameControllers.Count > 0)
{
    RawGameController rawGameController = RawGameController.RawGameControllers[0];
    arcadeStick = ArcadeStick.FromGameController(rawGameController);
}

if (arcadeStick != null) 
{
    // Assign a standard button mapping to this controller.
}
```-->