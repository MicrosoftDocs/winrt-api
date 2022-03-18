---
-api-id: M:Windows.Gaming.Input.RacingWheel.FromGameController(Windows.Gaming.Input.IGameController)
-api-type: winrt method
---

<!-- Method syntax.
public RacingWheel RacingWheel.FromGameController(IGameController gameController)
-->

# Windows.Gaming.Input.RacingWheel.FromGameController


## -description

Returns the given game controller as a racing wheel.

## -parameters

### -param gameController

The game controller to be returned as a racing wheel.

## -returns

The racing wheel that was returned from the given game controller.

## -remarks

This method checks if the provided game controller has a racing wheel implementation, and if so, it returns that implementation. You might use this method if you want to first get the controller as a [RawGameController](rawgamecontroller.md), and then see if it can be used as a **RacingWheel**&mdash;if so, you can use a default control scheme for racing wheels, otherwise you can let the player do their own input mapping.

## -see-also

[Windows.Gaming.Input.IGameController](igamecontroller.md)

## -examples

In the following example, the app gets the first available [RawGameController](rawgamecontroller.md) object, and tries to access this game controller via the **RacingWheel** class.

```cppwinrt
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
RacingWheel racingWheel{ nullptr };

if (RawGameController::RawGameControllers().Size() > 0)
{
    RawGameController rawGameController{ RawGameController::RawGameControllers().GetAt(0) };
    racingWheel = RacingWheel::FromGameController(rawGameController);
}

if (racingWheel)
{
    // Assign a standard button mapping to this controller.
}
```

```cppcx
RacingWheel^ racingWheel;

if (RawGameController::RawGameControllers->Size > 0)
{
    RawGameController^ rawGameController = 
        RawGameController::RawGameControllers->GetAt(0);
        
    racingWheel = RacingWheel::FromGameController(rawGameController);
}

if (racingWheel != nullptr)
{
    // Assign a standard button mapping to this controller.
}
```

