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

The account and credential command classes in the [Windows.UI.ApplicationSettings](windows_ui_applicationsettings.md) namespace correspond with data objects in the [Windows.UI.ApplicationSettings](windows_ui_applicationsettings.md) namespace:

| Data Object ([Windows.Security.Credentials](../windows.security.credentials/windows_security_credentials.md)) | UI object ([Windows.UI.ApplicationSettings](windows_ui_applicationsettings.md)) |
|---|---|
| [WebAccount](../windows.security.credentials/webaccount.md) | [WebAccountCommand](webaccountcommand.md) |
| [WebAccountProvider](../windows.security.credentials/webaccountprovider.md) | [WebAccountProviderCommand](webaccountprovidercommand.md) |
| [PasswordCredential](../windows.security.credentials/passwordcredential.md) | [CredentialCommand](credentialcommand.md) |

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
