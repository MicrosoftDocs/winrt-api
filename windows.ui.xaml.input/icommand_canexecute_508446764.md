---
-api-id: M:Windows.UI.Xaml.Input.ICommand.CanExecute(System.Object)
-api-type: winrt method
---

<!-- Method syntax
public bool CanExecute(System.Object parameter)
-->

# Windows.UI.Xaml.Input.ICommand.CanExecute

## -description

Retrieves whether the command can execute in its current state.



## -parameters

### -param parameter

Data used by the command. If the command does not require data, this object can be set to null.

## -returns

**true** if this command can be executed; otherwise, **false**.

## -remarks

Typically, a command source calls this method when the [CanExecuteChanged](icommand_canexecutechanged.md) event is raised.

## -examples

## -see-also

[Command design basics](/windows/uwp/layout/commanding-basics), [Commanding in Universal Windows Platform apps using StandardUICommand, XamlUICommand, and ICommand](/windows/uwp/design/controls-and-patterns/commanding), [XamlUICommand](xamluicommand.md), [StandardUICommand](standarduicommand.md)
