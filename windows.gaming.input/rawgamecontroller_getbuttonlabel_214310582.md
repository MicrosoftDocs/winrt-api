---
-api-id: M:Windows.Gaming.Input.RawGameController.GetButtonLabel(System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public GameControllerButtonLabel RawGameController.GetButtonLabel(Int32 buttonIndex)
-->

# Windows.Gaming.Input.RawGameController.GetButtonLabel

## -description

Retrieves the button label for the specified button.

## -params

## -param buttonIndex

The button for which to retrieve the label.

## -returns

Returns the label for the specified button. If the button label is blank or there is no known label for the controller’s button, then **None** is returned.

## -remarks

TODO: How do you get buttonIndex parameter?

Unlike the **GetButtonLabel** member functions of other classes, such as [ArcadeStick.GetButtonLabel](arcadestick_getbuttonlabel.md), this function takes an integer, rather than an [ArcadeStickButtons](arcadestickbuttons.md) or other enumeration value. 

## -see-also

## -examples

