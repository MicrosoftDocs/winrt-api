---
-api-id: E:Windows.UI.Xaml.Controls.SettingsFlyout.BackClick
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.BackClickEventHandler BackClick
-->

# Windows.UI.Xaml.Controls.SettingsFlyout.BackClick

## -description
Occurs when the user clicks the back button on a [SettingsFlyout](settingsflyout.md) control.

## -xaml-syntax
```xaml
<SettingsFlyout BackClick="eventhandler"/>

```


## -remarks
By default, clicking the back button on a [SettingsFlyout](settingsflyout.md) control hides the control. Handle the BackClick event and set [BackClickEventArgs.Handled](backclickeventargs_handled.md) to **true** to override this behavior and introduce your own logic.

This is useful when you have a [SettingsFlyout](settingsflyout.md) that opens a second [SettingsFlyout](settingsflyout.md). By default, when the user taps the Back button on the second flyout, it will reopen the [SettingsPane](../windows.ui.applicationsettings/settingspane.md). You should handle the BackClick event and reopen the first flyout instead.

## -examples
In this scenario, the Settings charm is used to open a [SettingsFlyout](settingsflyout.md) that contains a list of accounts. When the user picks an account, a new [SettingsFlyout](settingsflyout.md) is shown with options for the selected account.

Here, you handle the BackClick event of the second flyout so that when the user clicks the Back button, you show the account list again instead of the [SettingsPane](../windows.ui.applicationsettings/settingspane.md).

```csharp
void AccountSettingsFlyout_BackClick(object sender, BackClickEventArgs e)
{
    e.Handled = true;
    AccountListSettingsFlyout accountList = new AccountListSettingsFlyout();
    accountList.Show();  
}
```

For more code in context, see Scenario 5 of the [App settings sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/App%20settings%20sample).

## -see-also
[BackClickEventArgs](backclickeventargs.md)
