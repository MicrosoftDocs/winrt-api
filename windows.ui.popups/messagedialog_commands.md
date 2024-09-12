---
-api-id: P:Windows.UI.Popups.MessageDialog.Commands
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Popups.IUICommand> Commands { get; }
-->

# Windows.UI.Popups.MessageDialog.Commands

## -description
Gets an array of commands that appear in the command bar of the message dialog. These commands makes the dialog actionable.

Get this array and add [UICommand](uicommand.md) objects that represent your commands to it. If the dialog is currently showing, the commands aren't added to the command bar.

## -property-value
The commands.

## -remarks
By default, the array of commands for a dialog is empty. If no commands are appended to this array, then a default "Close" command is shown on the dialog.

To delay interaction with commands for a short period when the dialog is first shown, set the *AcceptUserInputAfterDelay* option with [MessageDialogOptions](messagedialogoptions.md).

A maximum number of 3 [UICommand](uicommand.md) objects can be added, and an exception will be thrown if adding over 3.

## -examples

## -see-also
