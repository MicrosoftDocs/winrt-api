---
-api-id: P:Windows.Security.Credentials.UI.CredentialPickerOptions.CallerSavesCredential
-api-type: winrt property
---

<!-- Property syntax
public bool CallerSavesCredential { get;  set; }
-->

# Windows.Security.Credentials.UI.CredentialPickerOptions.CallerSavesCredential

## -description
Gets or sets whether the caller wants to save the credentials.

## -property-value
Gets or sets whether the caller wants to save the credentials. The default value is False.

## -remarks
If [CallerSavesCredential](credentialpickeroptions_callersavescredential.md) is False and the user checks the **Save Credentials** check box, the entered credentials are stored in [Credential Manager](http://go.microsoft.com/fwlink/p/?LinkID=287069) by default. However, if [CallerSavesCredential](credentialpickeroptions_callersavescredential.md) is set to True and the user checks the **Save Credentials** check box, it is up to caller to store the entered credentials securely. For secure credential storage, please refer to [Credential Locker](../windows.security.credentials/passwordvault.md).

## -examples

## -see-also
