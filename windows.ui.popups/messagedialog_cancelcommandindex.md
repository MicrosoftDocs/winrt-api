---
-api-id: P:Windows.UI.Popups.MessageDialog.CancelCommandIndex
-api-type: winrt property
---

<!-- Property syntax
public uint CancelCommandIndex { get;  set; }
-->

# Windows.UI.Popups.MessageDialog.CancelCommandIndex

## -description
Gets or sets the index of the command you want to use as the cancel command. This is the command that fires when users press the ESC key.

Add the commands before you set the index.

## -property-value
The index of the cancel command.

## -remarks
Use message dialogs to send critical or blocking messages and questions from the app.

<table>
   <tr><th>Value</th><th>When to use</th></tr>
   <tr><td>≥ 0</td><td>The dialog offers a safe default choice that is the equivalent of cancellation, like "Cancel" or "Close." Set [CancelCommandIndex](messagedialog_cancelcommandindex.md) to the index of the command handler for that cancel/close command, so that when the user dismisses the dialog through a noncommital action, like pressing ESC, the API returns the command handler you want.

> [!NOTE]
> Generally, you should avoid creating dialogs that can be dismissed this way and that re-launch asking the same question or sending the same message again and again. They make the app noisy and tend to annoy users.</td></tr>
   <tr><td>-1</td><td>The user is required to make an explicit decision like tapping a specific button on the dialog. This ensures that the user can't dismiss the dialog through a noncommital action like pressing ESC.</td></tr>
   <tr><td>-2</td><td>**Not recommended**.The dialog is not dismissed when the user presses ESC or during an incoming contract activation; however, if the app re-uses the main app window when responding to incoming activations, the dialog's command handlers will no longer be valid. Because the API doesn't handle this behavior, we recommend not using this value.</td></tr>
</table>

**Error handling on dismissal by a contract activation**If the app receives an incoming contract activation (like from Search, Share, Settings, Devices or the file picker contracts) while the dialog is showing, the dialog is programmatically dismissed, regardless of the property value that has been set for the [CancelCommandIndex](messagedialog_cancelcommandindex.md).

To help you handle this case, the API returns a dummy command handler. You, then, can decide how to handle and react to the error.

## -examples

## -see-also
