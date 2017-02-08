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

## -params

## -param button

The button for which to retrieve the label.

## -returns

Returns the label for the specified button. If the button label is blank or there is no known label for the controller’s button, then `None` is returned.

## -remarks

## -see-also

## -examples

```csharp
private void ShowFlightStickFirePrimaryButtonIcon(FlightStick flightStick) 
{
    GameControllerButtonLabel label = 
        flightStick.GetButtonLabel(FlightStickButtons.FirePrimary);

    switch (label)
    {
        case (RightTrigger)
        {
            // Show right trigger icon
        }
        // ...
    }
}
```