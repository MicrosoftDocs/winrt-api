---
-api-id: E:Windows.UI.Xaml.Input.ICommand.CanExecuteChanged
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.Foundation.EventHandler CanExecuteChanged<object>
-->

# Windows.UI.Xaml.Input.ICommand.CanExecuteChanged

## -description

Occurs whenever something happens that affects whether the command can execute.



## -remarks

Call CanExecute on the command element when this event occurs.

A command element typically disables itself if the command it is associated with cannot execute. For example, a MenuItem associated with the Paste command is disabled when the there is nothing on the clipboard to paste.

## -examples

## -see-also

[Command design basics](/windows/uwp/layout/commanding-basics), [Commanding in Universal Windows Platform apps using StandardUICommand, XamlUICommand, and ICommand](/windows/uwp/design/controls-and-patterns/commanding), [XamlUICommand](xamluicommand.md), [StandardUICommand](standarduicommand.md)
