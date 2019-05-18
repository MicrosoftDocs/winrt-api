---
-api-id: M:Windows.UI.ApplicationSettings.AccountsSettingsPane.Show
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Show()
-->

# Windows.UI.ApplicationSettings.AccountsSettingsPane.Show

## -description
Displays the account settings pane.

## -remarks
You can modify the contents of the [AccountsSettingsPane](accountssettingspane.md) by registering for the [AccountCommandsRequested](accountssettingspane_accountcommandsrequested.md) event. If an error occurs while modifying the pane, Show will fail silently and the pane will not appear. 

Show will not notify the caller of the user’s action. To receive an asynchronous action response use [ShowAddAccountAsync](accountssettingspane_showaddaccountasync_1845582900.md).

Do not call Show multiple times in rapid succession. If you call Show while an existing Show operation is still running, exception will throw.

## -examples

## -see-also
