---
-api-id: M:Windows.Gaming.Input.RawGameController.GetCurrentReading(System.Boolean[],Windows.Gaming.Input.GameControllerSwitchPosition[],System.Double[])
-api-type: winrt method
---

<!-- Method syntax.
public ulong RawGameController.GetCurrentReading(Boolean[] buttonArray, GameControllerSwitchPosition[] switchArray, Double[] axisArray)
-->

# Windows.Gaming.Input.RawGameController.GetCurrentReading


## -description

Gets a snapshot of the raw game controller's state.

## -parameters

### -param buttonArray

The button array for the raw game controller to be populated with the current state of each button.

### -param switchArray

The switch array for the raw game controller to be populated with the current state of each switch.

### -param axisArray

The axis array for the raw game controller to be populated with the current state of each axis.

## -returns

The timestamp of when the reading was retrieved from the raw game controller.

## -remarks

Unlike the **GetCurrentReading** member functions of other classes, such as [ArcadeStick.GetCurrentReading](arcadestick_getcurrentreading_1416488181.md), **RawGameController.GetCurrentReading** takes three parameters: the button, switch, and axis arrays of the raw game controller. You create these arrays yourself, with the sizes [RawGameController.ButtonCount](rawgamecontroller_buttoncount.md), [RawGameController.SwitchCount](rawgamecontroller_switchcount.md), and [RawGameController.AxisCount](rawgamecontroller_axiscount.md), respectively.

**RawGameController.GetCurrentReading** populates each of these arrays with the current states of each input. The button array is an array of Booleans, where **true** means the button is pressed and **false** means it is not. The switch array is an array of [GameControllerSwitchPosition](gamecontrollerswitchposition.md), where the value at each index represents that switch's current position. Finally, the axis array is an array of doubles, where the value at each index (between 0.0 and 1.0) represents the position of that axis.

See [Raw game controller](/windows/uwp/gaming/raw-game-controller) for more information about how to read input from a raw game controller.

## -see-also

[Windows.Gaming.Input.GameControllerSwitchPosition](gamecontrollerswitchposition.md)

## -examples

