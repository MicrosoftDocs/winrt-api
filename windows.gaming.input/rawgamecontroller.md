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

You'll need to create these arrays yourself, and then populate them using [RawGameController.GetCurrentReading](rawgamecontroller_getcurrentreading.md) to determine the states of the buttons, switches, and axes. See that function's documentation for more information.

## -see-also

* [Windows.Gaming.Input.IGameController](igamecontroller.md)
* [Windows.Gaming.Input.IGameControllerBatteryInfo](igamecontrollerbatteryinfo.md)

## -examples
