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

Show will not notify the caller when the user has dismissed the account settings pane.
To receive an asynchronous action response use [ShowManageAccountsAsync](accountssettingspane_showmanageaccountsasync_541379460.md).

Do not call Show multiple times in rapid succession. If you call Show while an existing Show operation is still running, an exception will be thrown.

## -examples

## -see-also
