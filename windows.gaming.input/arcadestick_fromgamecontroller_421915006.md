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

## -parameters

### -param gameController

The game controller to be returned as an arcade stick.

## -returns

The arcade stick that was returned from the given game controller.

## -remarks

This method checks if the provided game controller has an arcade stick implementation, and if so, it returns that implementation. You might use this method if you want to first get the controller as a [RawGameController](rawgamecontroller.md), and then see if it can be used as an **ArcadeStick**&mdash;if so, you can use a default control scheme for arcade sticks, otherwise you can let the player do their own input mapping.

## -see-also

[Windows.Gaming.Input.IGameController](igamecontroller.md)

## -examples

In the following example, the app gets the first available [RawGameController](rawgamecontroller.md) object, and tries to access this game controller via the **ArcadeStick** class.

```cppwinrt
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
ArcadeStick arcadeStick{ nullptr };

if (RawGameController::RawGameControllers().Size() > 0)
{
    RawGameController rawGameController{ RawGameController::RawGameControllers().GetAt(0) };
    arcadeStick = ArcadeStick::FromGameController(rawGameController);
}

if (arcadeStick)
{
    // Assign a standard button mapping to this controller.
}
```

```cppcx
ArcadeStick^ arcadeStick;

if (RawGameController::RawGameControllers->Size > 0)
{
    RawGameController^ rawGameController = RawGameController::RawGameControllers->GetAt(0);
    arcadeStick = ArcadeStick::FromGameController(rawGameController);
}

if (arcadeStick != nullptr)
{
    // Assign a standard button mapping to this controller.
}
```