---
-api-id: T:Windows.Security.Credentials.UI.UserConsentVerificationResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Credentials.UI.UserConsentVerificationResult : int
-->

# UserConsentVerificationResult

## -description
Describes the result of a verification operation.

## -enum-fields
### -field Verified:0
The fingerprint was verified.

### -field DeviceNotPresent:1
There is no biometric verifier device available.

### -field NotConfiguredForUser:2
A biometric verifier device is not configured for this user.

### -field DisabledByPolicy:3
Group policy has disabled the biometric verifier device.

### -field DeviceBusy:4
The biometric verifier device is performing an operation and is unavailable.

### -field RetriesExhausted:5
After 10 attempts, the original verification request and all subsequent attempts at the same verification were not verified.

### -field Canceled:6
The verification operation was canceled.


## -remarks
The following example shows a method that requests fingerprint verification and returns a message that describes the result based on the UserConsentVerificationResult value.

[!code-csharp[2](../windows.security.credentials.ui/code/BiometricAuth/cs/MainPage.xaml.cs#Snippet2)]

[!code-js[2_JS](../windows.security.credentials.ui/code/BiometricAuth/js/default.js#Snippet2_JS)]

## -examples

## -see-also
[Fingerprint biometrics](/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/UserConsentVerifier), [RequestVerificationAsync](userconsentverifier_requestverificationasync_1054783001.md), [UserConsentVerifier](userconsentverifier.md), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity)
