---
-api-id: M:Windows.Gaming.Input.RawGameController.FromGameController(Windows.Gaming.Input.IGameController)
-api-type: winrt method
---

<!-- Method syntax.
public RawGameController RawGameController.FromGameController(IGameController gameController)
-->

# Windows.Gaming.Input.RawGameController.FromGameController


## -description

Returns the given game controller as a raw game controller.

## -parameters

### -param gameController

The game controller to be returned as a raw game controller.

## -returns

The raw game controller that was returned from the given game controller.

## -remarks

This method checks if the provided game controller has a raw game controller implementation, and if so, it returns that implementation. You might use this method if you want to first get the controller as a [RawGameController](rawgamecontroller.md), and then see if it can be used as another type of controller, such as a [Gamepad](gamepad.md)&mdash;if so, you can use a default control scheme for that controller type, otherwise you can let the player do their own input mapping.

## -see-also

[Windows.Gaming.Input.IGameController](igamecontroller.md)

## -examples

