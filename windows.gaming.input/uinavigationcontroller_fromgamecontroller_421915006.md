---
-api-id: M:Windows.Gaming.Input.UINavigationController.FromGameController(Windows.Gaming.Input.IGameController)
-api-type: winrt method
---

<!-- Method syntax.
public UINavigationController UINavigationController.FromGameController(IGameController gameController)
-->

# Windows.Gaming.Input.UINavigationController.FromGameController


## -description

Returns the given game controller as a UI navigation controller.

## -parameters

### -param gameController

The game controller to be returned as a UI navigation controller.

## -returns

The UI navigation controller that was returned from the given game controller.

## -remarks

This method checks if the provided game controller has a UI navigation controller implementation, and if so, it returns that implementation. You might use this method if you want to first get the controller as a [RawGameController](rawgamecontroller.md), and then see if it can be used as a **UINavigationController**&mdash;if so, you can use a default control scheme for UI navigation controllers, otherwise you can let the player do their own input mapping.

## -see-also

[Windows.Gaming.Input.IGameController](igamecontroller.md)

## -examples

In the following example, the app gets the first available [RawGameController](rawgamecontroller.md) object, and tries to access this game controller via the **UINavigationController** class.

```cppwinrt
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
UINavigationController uiNavigationController{ nullptr };

if (RawGameController::RawGameControllers().Size() > 0)
{
    RawGameController rawGameController{ RawGameController::RawGameControllers().GetAt(0) };
    uiNavigationController = UINavigationController::FromGameController(rawGameController);
}

if (uiNavigationController)
{
    // Assign a standard button mapping to this controller.
}
```

```cppcx
UINavigationController^ uiNavigationController;

if (RawGameController::RawGameControllers->Size > 0)
{
    RawGameController^ rawGameController = 
        RawGameController::RawGameControllers->GetAt(0);
        
    uiNavigationController = 
        UINavigationController::FromGameController(rawGameController);
}

if (uiNavigationController != nullptr)
{
    // Assign a standard button mapping to this controller.
}
```

