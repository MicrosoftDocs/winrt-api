---
-api-id: T:Windows.Security.Credentials.UI.UserConsentVerifier
-api-type: winrt class
---

<!-- Class syntax.
public class UserConsentVerifier 
-->

# Windows.Security.Credentials.UI.UserConsentVerifier

## -description

Checks for availability of a verification device (such as a Microsoft Passport PIN, Windows Hello biometric, or fingerprint reader) and performs a verification.

## -remarks

You can use the UserConsentVerifier class to enhance the security of your app by including a request for verification whenever the user is required to consent to a particular action. For example, you can require a fingerprint authentication before authorizing an in-app purchase or access to restricted resources. You can use the UserConsentVerifier class to determine if fingerprint authentication is supported for the current computer using the [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md) method, and then request user consent from a fingerprint scan using the [RequestVerificationAsync](userconsentverifier_requestverificationasync_1054783001.md) method.

## -examples

The following example shows a method that requests fingerprint verification and returns a message that describes the result.

[!code-csharp[2](../windows.security.credentials.ui/code/BiometricAuth/cs/MainPage.xaml.cs#Snippet2)]

## -see-also

[Fingerprint biometrics](/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/UserConsentVerifier), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [UserConsentVerifier sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620615)
