---
-api-id: M:Windows.Security.Credentials.PasswordVault.Add(Windows.Security.Credentials.PasswordCredential)
-api-type: winrt method
---

<!-- Method syntax
public void Add(Windows.Security.Credentials.PasswordCredential credential)
-->

# Windows.Security.Credentials.PasswordVault.Add

## -description
Adds a credential to the Credential Locker.

## -parameters
### -param credential
The credential to be added.

## -remarks
You can only store up to 20 credentials per app in the Credential Locker. If you try to store more than 20 credentials, you will encounter an [Exception](https://docs.microsoft.com/dotnet/api/system.exception?redirectedfrom=MSDN).

## -examples

## -see-also
