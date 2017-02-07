---
-api-id: M:Windows.Gaming.Input.ArcadeStick.FromGameController(Windows.Gaming.Input.IGameController)
-api-type: winrt method
---

<!-- Method syntax.
public ArcadeStick ArcadeStick.FromGameController(IGameController gameController)
-->

# Windows.Gaming.Input.ArcadeStick.FromGameController

## -description

Returns the given game controller as an [ArcadeStick](arcadestick.md) object.

## -params

## -param gameController

The game controller to be converted to an ArcadeStick.

## -returns

The ArcadeStick that was converted from the given game controller.

## -remarks

## -see-also

* [ArcadeStick](arcadestick.md)
* [IGameController](igamecontroller.md)

## -examples

In the following example, the app gets the first available [RawGameController](rawgamecontroller.md) object, and tries to access this game controller via the `ArcadeStick` class.

```csharp
RawGameController rawGameController = RawGameController.RawGameControllers[0];
ArcadeStick arcadeStick = ArcadeStick.FromGameController(rawGameController);

if (arcadeStick != null) 
{
    // Assign a standard button mapping to this controller.
}
```