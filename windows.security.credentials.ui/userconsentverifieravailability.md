---
-api-id: T:Windows.Security.Credentials.UI.UserConsentVerifierAvailability
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Credentials.UI.UserConsentVerifierAvailability : int
-->

# UserConsentVerifierAvailability

## -description
Describes the result of a check for a biometric (fingerprint) verifier device.

## -enum-fields
### -field Available:0
A biometric verifier device is available.

### -field DeviceNotPresent:1
There is no biometric verifier device available.

### -field NotConfiguredForUser:2
A biometric verifier device is not configured for this user.

### -field DisabledByPolicy:3
Group policy has disabled the biometric verifier device.

### -field DeviceBusy:4
The biometric verifier device is performing an operation and is unavailable.


## -remarks
You can use the [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md) method to determine if fingerprint authentication is supported for the current computer.

The following example shows a method that checks to see if fingerprint authentication is supported for the current computer and returns a message that describes the result based on the UserConsentVerifierAvailability value.





[!code-csharp[1](../windows.security.credentials.ui/code/BiometricAuth/cs/MainPage.xaml.cs#Snippet1)]


[!code-js[1_JS](../windows.security.credentials.ui/code/BiometricAuth/js/default.js#Snippet1_JS)]

## -examples

## -see-also
[Fingerprint biometrics](https://docs.microsoft.com/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://go.microsoft.com/fwlink/p/?LinkID=303650), [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md), [UserConsentVerifier](userconsentverifier.md), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](https://docs.microsoft.com/windows/uwp/security/authentication-and-user-identity)
