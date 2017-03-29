---
-api-id: P:Windows.Devices.AllJoyn.AllJoynCredentials.PasswordCredential
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Security.Credentials.PasswordCredential PasswordCredential { get;  set; }
-->

# Windows.Devices.AllJoyn.AllJoynCredentials.PasswordCredential

## -description
The user name, if any, and password used for authentication.

## -property-value
A user name/password combination.

## -remarks
The password value contained in a [PasswordCredential](../windows.security.credentials/passwordcredential.md) object is used by the following authentication mechanisms: It’s also optionally used by Rsa if the private key associated with the certificate is encrypted with a password. The user name is used only by SrpLogon, and is ignored for the other ones.


+ SrpAnonymous
+ SrpLogon
+ Pin
+ EcdhePsk
> [!NOTE]
> Used for Rsa if the private key associated with the certificate is encrypted with a password.

The username value contained in a [PasswordCredential](../windows.security.credentials/passwordcredential.md) object is used only by SrpLogon, and is ignored by other authentication mechanisms.

## -examples

## -see-also


## -capabilities
allJoyn