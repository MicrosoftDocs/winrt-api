---
-api-id: M:Windows.UI.Xaml.Input.XamlUICommand.CanExecute(System.Object)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool XamlUICommand.CanExecute(Object parameter)
-->

# Windows.UI.Xaml.Input.XamlUICommand.CanExecute

## -description

Retrieves whether the command can execute in its current state.



## -parameters

### -param parameter

Data used by the command. If the command does not require data, this object can be set to null.

## -returns

**true** if this command can be executed; otherwise, **false**.

## -remarks

A command source typically calls this method when the [CanExecuteChanged](xamluicommand_canexecutechanged.md) event is raised.

## -see-also

[StandardUICommand](standarduicommand.md), [Command design basics](/windows/uwp/layout/commanding-basics), [Commanding in Universal Windows Platform apps using StandardUICommand, XamlUICommand, and ICommand](/windows/uwp/design/controls-and-patterns/commanding)

## -examples
