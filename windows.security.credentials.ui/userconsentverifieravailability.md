---
-api-id: T:Windows.Security.Credentials.UI.UserConsentVerifierAvailability
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Credentials.UI.UserConsentVerifierAvailability : int
-->

# UserConsentVerifierAvailability

## -description
Describes the result of a check for an an authentication device such as a fingerprint reader.

## -enum-fields
### -field Available:0
An authentication device is available.

### -field DeviceNotPresent:1
There is no authentication device available.

### -field NotConfiguredForUser:2
An authentication device is not configured for this user.

### -field DisabledByPolicy:3
Group policy has disabled the authentication device.

### -field DeviceBusy:4
The authentication device is performing an operation and is unavailable.


## -remarks
You can use the [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md) method to determine if fingerprint authentication is supported for the current computer.

## -examples

The following example shows a method that checks to see if an authentication device is supported for the current user and returns a message that describes the result based on the UserConsentVerifierAvailability value.

[!code-csharp[1](../windows.security.credentials.ui/code/BiometricAuth/cs/MainPage.xaml.cs#Snippet1)]

## -see-also
[Fingerprint biometrics](/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/UserConsentVerifier), [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md), [UserConsentVerifier](userconsentverifier.md), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity)
