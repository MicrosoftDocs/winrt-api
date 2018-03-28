---
-api-id: E:Windows.UI.Xaml.Input.ICommand.CanExecuteChanged
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.Foundation.EventHandler CanExecuteChanged<object>
-->

# Windows.UI.Xaml.Input.ICommand.CanExecuteChanged

## -description
Occurs when changes occur that affect whether the command can execute.

## -remarks
Call [CanExecute](icommand_canexecutechanged.md) on the command element when this event occurs.

A command element typically disables itself if the command it is associated with cannot execute. For example, a MenuItem associated with the Paste command will gray itself out when the Paste command cannot execute.

## -examples

## -see-also
