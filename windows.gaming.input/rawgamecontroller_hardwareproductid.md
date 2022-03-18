---
-api-id: P:Windows.Gaming.Input.RawGameController.HardwareProductId
-api-type: winrt property
---

<!-- Property syntax.
public ushort HardwareProductId { get; }
-->

# Windows.Gaming.Input.RawGameController.HardwareProductId

## -description

The hardware product ID of the raw game controller.

## -property-value

The hardware product ID of the raw game controller.

## -remarks

If you have a specific controller that you want to support, you can get this value and [RawGameController.HardwareVendorId](/uwp/api/windows.gaming.input.rawgamecontroller.HardwareVendorId) and check that they match the controller. The position of each input in each array that you get from [RawGameController.GetCurrentReading](/uwp/api/windows.gaming.input.rawgamecontroller#Windows_Gaming_Input_RawGameController_GetCurrentReading_System_Boolean___Windows_Gaming_Input_GameControllerSwitchPosition___System_Double___) is the same for every controller with the same **HardwareProductId** and **HardwareVendorId**, so you don't have to worry about your logic potentially being inconsistent among different controllers of the same type.

## -see-also

## -examples

The following example checks if the given raw game controller's PID and VID (Product ID and Vendor ID, respectively) match the given PID and VID.

```cppwinrt
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
void CheckIfMatch(RawGameController rawGameController, uint16_t pid, uint16_t vid)
{
    if ((rawGameController.HardwareProductId() == pid) &&
        (rawGameController.HardwareVendorId() == vid))
    {
        /* This controller is the type that we're checking for, so we can assign a
        specific input mapping. */
    }
}
```