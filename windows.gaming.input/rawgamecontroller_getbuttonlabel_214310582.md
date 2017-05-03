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

The label for the specified button. If the button label is blank or there is no known label for the controller’s button, then **None** is returned.

## -remarks

Unlike the **GetButtonLabel** member functions of other classes, such as [ArcadeStick.GetButtonLabel](arcadestick_getbuttonlabel.md), this function takes an integer, rather than an [ArcadeStickButtons](arcadestickbuttons.md) or other enumeration value. This integer is an index into the buttons array for the raw game controller.

You can create your own buttons array and then populate it with values representing each button's state using [RawGameController.GetCurrentReading](rawgamecontroller_getcurrentreading.md). See [Raw game controller](https://docs.microsoft.com/windows/uwp/gaming/raw-game-controller) for more information.

## -see-also

* [Windows.Gaming.Input.GameControllerButtonLabel](gamecontrollerbuttonlabel.md)

## -examples
