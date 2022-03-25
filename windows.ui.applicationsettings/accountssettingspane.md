---
-api-id: T:Windows.UI.ApplicationSettings.AccountsSettingsPane
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class AccountsSettingsPane : Windows.UI.ApplicationSettings.IAccountsSettingsPane
-->

# Windows.UI.ApplicationSettings.AccountsSettingsPane

## -description
Provides methods to show the accounts pane and also to enable the app to register callbacks when the accounts flyout is about to be displayed.

## -remarks
The app provides the callbacks with account metadata for all of the web account providers, web accounts, global account commands, and credential locker credentials that the app displays. Examples of account providers are Facebook, LinkedIn, and Twitter.

The account and credential command classes in the [Windows.UI.ApplicationSettings](windows_ui_applicationsettings.md) namespace correspond with data objects in the [Windows.UI.ApplicationSettings](windows_ui_applicationsettings.md) namespace:<table>
   <tr><th>Data Object ([Windows.Security.Credentials](../windows.security.credentials/windows_security_credentials.md))</th><th>UI object ([Windows.UI.ApplicationSettings](windows_ui_applicationsettings.md))</th></tr>
   <tr><td>[WebAccount](../windows.security.credentials/webaccount.md)</td><td>[WebAccountCommand](webaccountcommand.md)</td></tr>
   <tr><td>[WebAccountProvider](../windows.security.credentials/webaccountprovider.md)</td><td>[WebAccountProviderCommand](webaccountprovidercommand.md)</td></tr>
   <tr><td>[PasswordCredential](../windows.security.credentials/passwordcredential.md)</td><td>[CredentialCommand](credentialcommand.md)</td></tr>
</table>

### Desktop applications

For a desktop app, instead of using the AccountSettingsPane class, you'll need to use the interop API.

- First [Retrieve a window handle (HWND)](/windows/apps/develop/ui-input/retrieve-hwnd). That topic contains code examples for Windows UI Library (WinUI) 3, Windows Presentation Foundation (WPF), and Windows Forms (WinForms). Plug that code into the code listing below.
- The [IAccountSettingsPaneInterop](/windows/win32/api/accountssettingspaneinterop) interface should be used for desktop apps. For C# apps using .NET 5 or later, the AccountSettingsPaneInterop class is available. For more info about the C# interop classes, see [Call interop APIs from a .NET 5+ app](/windows/apps/desktop/modernize/winrt-com-interop-csharp). Also see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects).

The following is an example on how to use the AccountSettingsPaneInterop class in C# (.NET 5 or later):
```csharp
private void LoginButton_Click(object sender, RoutedEventArgs e)
{
    // Retrieve the window handle for whichever UI framework being used (WinUI3, WPF, WinForms)
    var hwnd = ...
    // Call methods from the interop class, passing in the window handle
    await AccountsSettingsPaneInterop.ShowManageAccountsForWindowAsync(hwnd);
}
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ShowAddAccountAsync |
| 1607 | 14393 | ShowManageAccountsAsync |
| 1803 | 17134 | ShowAddAccountForUserAsync |
| 1803 | 17134 | ShowManageAccountsForUserAsync |

## -examples

## -see-also
[PasswordCredential](../windows.security.credentials/passwordcredential.md), [WebAccountProvider](../windows.security.credentials/webaccountprovider.md), [WebAccount](../windows.security.credentials/webaccount.md)
