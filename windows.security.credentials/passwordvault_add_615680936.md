---
-api-id: M:Windows.Security.Credentials.PasswordVault.Add(Windows.Security.Credentials.PasswordCredential)
-api-type: winrt method
---

<!-- Method syntax
public void Add(Windows.Security.Credentials.PasswordCredential credential)
-->

# Windows.Security.Credentials.PasswordVault.Add

## -description

Adds a credential to the **Credential Locker**.

## -parameters

### -param credential

The credential to be added.

## -remarks

You can only store up to 20 credentials per app in the [Credential Locker](/windows/uwp/security/credential-locker). If you try to store more than 20 credentials, you will encounter an [Exception](/dotnet/api/system.exception?view=dotnet-uwp-10.0&preserve-view=true).

> [!NOTE]
> The limit of 20 credentials per app only applies when using the Credential Locker from a UWP app or from a desktop app [running in an **AppContainer**](/windows/win32/secauthz/appcontainer-for-legacy-applications-).

## -examples

## -see-also

[Credential locker](/windows/uwp/security/credential-locker), [Remove](passwordvault_remove_423289634.md)
