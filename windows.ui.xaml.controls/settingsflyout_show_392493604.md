---
-api-id: M:Windows.UI.Xaml.Controls.SettingsFlyout.Show
-api-type: winrt method
---

<!-- Method syntax
public void Show()
-->

# Windows.UI.Xaml.Controls.SettingsFlyout.Show

## -description
Opens the Settings flyout, and returns the user to the Settings pane after the flyout is dismissed.

## -remarks
If a [SettingsFlyout](settingsflyout.md) is shown by calling the Show method, then clicking the Back button reopens the [SettingsPane](../windows.ui.applicationsettings/settingspane.md) after the [SettingsFlyout](settingsflyout.md) dismisses. If a [SettingsFlyout](settingsflyout.md) is shown by calling [ShowIndependent](settingsflyout_showindependent_61271159.md), then clicking the Back button dismisses the [SettingsFlyout](settingsflyout.md) and returns the user to the app; the [SettingsPane](../windows.ui.applicationsettings/settingspane.md) is not reopened.

Call the Show method in your [CommandsRequested](../windows.ui.applicationsettings/settingspane_commandsrequested.md) event handler. This code is invoked when the user opens the [SettingsFlyout](settingsflyout.md) from the [SettingsPane](../windows.ui.applicationsettings/settingspane.md), so you should return the user to the [SettingsPane](../windows.ui.applicationsettings/settingspane.md) when they click the Back button.

Only one [SettingsFlyout](settingsflyout.md) is shown at a time. Calling Show on a [SettingsFlyout](settingsflyout.md) closes any other [SettingsFlyout](settingsflyout.md) currently shown. The [SettingsFlyout](settingsflyout.md) being closed completes its close animation before the new [SettingsFlyout](settingsflyout.md) begins its show animation.

## -examples
```csharp
private void App_CommandsRequested(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
{
    // Add update settings.
    Windows.UI.ApplicationSettings.SettingsCommand updateSetting =
        new Windows.UI.ApplicationSettings.SettingsCommand("AppUpdateSettings", "App updates", (handler) =>
        {
            UpdateSettingsFlyout updatesFlyout = new UpdateSettingsFlyout();
            updatesFlyout.Show();
        });

    args.Request.ApplicationCommands.Add(updateSetting);

    // Add account list.
    Windows.UI.ApplicationSettings.SettingsCommand accountListSetting =
        new Windows.UI.ApplicationSettings.SettingsCommand("AppAccountListSettings", "Accounts", (handler) =>
        {
            AccountListSettingsFlyout accountsListFlyout = new AccountListSettingsFlyout();
            accountsListFlyout.Show();
        });
   
    args.Request.ApplicationCommands.Add(accountListSetting);
}
```

For more code in context, see Scenario 3 of the [App settings sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/App%20settings%20sample).

## -see-also
[ShowIndependent](settingsflyout_showindependent_61271159.md), [Quickstart: Add app settings](/previous-versions/windows/apps/hh872190(v=win.10)), [Quickstart: Add app help](/previous-versions/windows/apps/jj649425(v=win.10))
