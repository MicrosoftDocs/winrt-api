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

You'll need to create these arrays yourself, and then populate them using [GetCurrentReading](rawgamecontroller_getcurrentreading_123740519.md) to determine the states of the buttons, switches, and axes. See that function's documentation for more information.

See [Raw game controller](/windows/uwp/gaming/raw-game-controller) for information about how to use the **RawGameController** class.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | DisplayName |
| 1709 | 16299 | NonRoamableId |
| 1709 | 16299 | SimpleHapticsControllers |

## -see-also

[Windows.Gaming.Input.IGameController interface](igamecontroller.md),
[Windows.Gaming.Input.IGameControllerBatteryInfo interface](igamecontrollerbatteryinfo.md),
[Raw game controller](/windows/uwp/gaming/raw-game-controller),
[Input practices for games](/windows/uwp/gaming/input-practices-for-games)

## -examples

The following code snippet shows how to loop through the **RawGameController.RawGameControllers** list and add each **RawGameController** to a vector. You'll need to put a lock on the vector, because things can change at any time (a controller might be disconnected or reconnected, for example).

```cppwinrt
#include <concrt.h>
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
std::vector<RawGameController> myRawGameControllers;
concurrency::critical_section myLock{};

for (auto const& rawGameController : RawGameController::RawGameControllers())
{
    // Test whether the raw game controller is already in myRawGameControllers; if it isn't, add it.
    concurrency::critical_section::scoped_lock lock{ myLock };
    auto it{ std::find(begin(myRawGameControllers), end(myRawGameControllers), rawGameController) };

    if (it == end(myRawGameControllers))
    {
        // This code assumes that you're interested in all raw game controllers.
        myRawGameControllers.push_back(rawGameController);
    }
}
```
