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
You can modify the contents of the [AccountsSettingsPane](accountssettingspane.md) by registering for the [AccountCommandsRequested](accountssettingspane_accountcommandsrequested.md) event. If an error occurs while modifying the pane, [Show](accountssettingspane_show.md) will fail silently and the pane will not appear. 

Do not call [Show](accountssettingspane_show.md) multiple times in rapid succession. If you call [Show](accountssettingspane_show.md) while an existing [Show](accountssettingspane_show.md) operation is still running, exception will throw.

## -examples

## -see-also
