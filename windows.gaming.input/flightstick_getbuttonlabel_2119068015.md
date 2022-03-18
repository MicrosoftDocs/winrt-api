---
-api-id: M:Windows.Gaming.Input.FlightStick.GetButtonLabel(Windows.Gaming.Input.FlightStickButtons)
-api-type: winrt method
---

<!-- Method syntax.
public GameControllerButtonLabel FlightStick.GetButtonLabel(FlightStickButtons button)
-->

# Windows.Gaming.Input.FlightStick.GetButtonLabel


## -description

Retrieves the button label for the specified button.

## -parameters

### -param button

The button for which to retrieve the label.

## -returns

The label for the specified button. If the button label is blank or there is no known label for the controller's button, then **None** is returned.

## -remarks

The following example gets the label on the **FirePrimary** button on the flight stick, and shows an icon based on the label.

```cppwinrt
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;

void ShowFlightStickFirePrimaryButtonIcon(FlightStick flightStick)
{
    GameControllerButtonLabel label =
        flightStick.GetButtonLabel(FlightStickButtons::FirePrimary);

    switch (label)
    {
        case (GameControllerButtonLabel::RightTrigger):
        {
            // Show the right trigger icon.
        }
        // ...
    }
}
```

## -see-also

[Windows.Gaming.Input.GameControllerButtonLabel](gamecontrollerbuttonlabel.md), [Windows.Gaming.Input.FlightStickButtons](flightstickbuttons.md)

## -examples

