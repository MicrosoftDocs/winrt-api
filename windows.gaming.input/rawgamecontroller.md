---
-api-id: T:Windows.Gaming.Input.RawGameController
-api-type: winrt class
---

<!-- Class syntax.
public class RawGameController : IGameController, IGameControllerBatteryInfo
-->

# Windows.Gaming.Input.RawGameController

## -description

Represents any type of game controller.

## -remarks

Instances of the **RawGameController** class cannot be created directly; instead, instances of the class are retrieved through the [RawGameController.RawGameControllers](rawgamecontroller_rawgamecontrollers.md) property listing all connected game controllers or through the [RawGameController.RawGameControllerAdded](rawgamecontroller_rawgamecontrolleradded.md) event.

All inputs available on a **RawGameController** are exposed as simple arrays of unnamed buttons, switches, and axes. Using this class, you can allow customers to create custom input mappings no matter what type of controller they're using.

You'll need to create these arrays yourself, and then populate them using [RawGameController.GetCurrentReading](rawgamecontroller_getcurrentreading_123740519.md) to determine the states of the buttons, switches, and axes. See that function's documentation for more information.

See [Raw game controller](https://docs.microsoft.com/windows/uwp/gaming/raw-game-controller) for information about how to use the **RawGameController** class.

## -see-also

[Windows.Gaming.Input.IGameController interface](igamecontroller.md),
[Windows.Gaming.Input.IGameControllerBatteryInfo interface](igamecontrollerbatteryinfo.md),
[Raw game controller](https://docs.microsoft.com/windows/uwp/gaming/raw-game-controller),
[Input practices for games](https://docs.microsoft.com/windows/uwp/gaming/input-practices-for-games)

## -examples

The following code snippet shows how to loop through the **RawGameController.RawGameControllers** list and add each **RawGameController** to a vector. You'll need to put a lock on the vector, because things can change at any time (a controller might be disconnected or reconnected, for example).

```cpp
void GetRawGameControllers()
{
    auto myControllers{ std::vector<RawGameController>() };
    critical_section myLock{};

    for (auto controller : RawGameController::RawGameControllers())
    {
        // Check if the controller is already in myControllers; if it isn't, add it.
        critical_section::scoped_lock lock{ myLock };
        auto it = std::find(begin(myControllers), end(myControllers), controller);

        if (it == end(myControllers))
        {
            // This code assumes that you're interested in all controllers.
            myControllers.emplace_back(controller);
        }
    }
}
```