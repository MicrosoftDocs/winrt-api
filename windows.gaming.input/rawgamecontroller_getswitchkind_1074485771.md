---
-api-id: M:Windows.Gaming.Input.RawGameController.GetSwitchKind(System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public GameControllerSwitchKind RawGameController.GetSwitchKind(Int32 switchIndex)
-->

# Windows.Gaming.Input.RawGameController.GetSwitchKind


## -description

Gets the type of the specified switch on the raw game controller.

## -parameters

### -param switchIndex

The index in the raw game controller's switch array of the switch whose type you are querying.

## -returns

The type of the given switch on the raw game controller.

## -remarks

This function takes an integer, which is the index in the raw game controller's switch array that points to the switch you want to query. You can create your own switch array and then populate it with values representing each switch's state using [RawGameController.GetCurrentReading](rawgamecontroller_getcurrentreading_123740519.md). See [Raw game controller](/windows/uwp/gaming/raw-game-controller) for more information.

## -see-also

[Windows.Gaming.Input.GameControllerSwitchKind](gamecontrollerswitchkind.md)

## -examples

