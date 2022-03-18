---
-api-id: M:Windows.Gaming.Input.Gamepad.FromGameController(Windows.Gaming.Input.IGameController)
-api-type: winrt method
---

<!-- Method syntax.
public Gamepad Gamepad.FromGameController(IGameController gameController)
-->

# Windows.Gaming.Input.Gamepad.FromGameController


## -description

Returns the given game controller as a gamepad.

## -parameters

### -param gameController

The game controller to be returned as a gamepad.

## -returns

The gamepad that was returned from the given game controller.

## -remarks

This method checks if the provided game controller has a gamepad implementation, and if so, it returns that implementation. You might use this method if you want to first get the controller as a [RawGameController](rawgamecontroller.md), and then see if it can be used as a **Gamepad**&mdash;if so, you can use a default control scheme for gamepads, otherwise you can let the player do their own input mapping.

## -see-also

[Windows.Gaming.Input.IGameController](igamecontroller.md)

## -examples

In the following example, the app gets the first available [RawGameController](rawgamecontroller.md) object, and tries to access this game controller via the **Gamepad** class.

```cppwinrt
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
Gamepad gamepad{ nullptr };

if (RawGameController::RawGameControllers().Size() > 0)
{
    RawGameController rawGameController{ RawGameController::RawGameControllers().GetAt(0) };
    gamepad = Gamepad::FromGameController(rawGameController);
}

if (gamepad)
{
    // Assign a standard button mapping to this controller.
}
```

```cppcx
Gamepad^ gamepad;

if (RawGameController::RawGameControllers->Size > 0)
{
    RawGameController^ rawGameController = RawGameController::RawGameControllers->GetAt(0);
    gamepad = Gamepad::FromGameController(rawGameController);
}

if (gamepad != nullptr)
{
    // Assign a standard button mapping to this controller.
}
```

```cs
Gamepad gamepad = null;

if (RawGameController.RawGameControllers.Count > 0)
{
    RawGameController rawGameController = RawGameController.RawGameControllers[0];
    gamepad = Gamepad.FromGameController(rawGameController);
}

if (gamepad != null)
{
    // Assign a standard button mapping to this controller.
}
```