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
You can use the [UserConsentVerifier](userconsentverifier.md) class to enhance the security of your app by including a request for verification whenever the user is required to consent to a particular action. For example, you can require a fingerprint authentication before authorizing an in-app purchase or access to restricted resources. You can use the [UserConsentVerifier](userconsentverifier.md) class to determine if fingerprint authentication is supported for the current computer using the [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync.md) method, and then request user consent from a fingerprint scan using the [RequestVerificationAsync](userconsentverifier_requestverificationasync.md) method.

The following example shows a method that requests fingerprint verification and returns a message that describes the result.





[!code-csharp[2](../windows.security.credentials.ui/code/BiometricAuth/cs/MainPage.xaml.cs#Snippet2)]


[!code-js[2_JS](../windows.security.credentials.ui/code/BiometricAuth/js/default.js#Snippet2_JS)]

## -examples

## -see-also
[Fingerprint biometrics](http://msdn.microsoft.com/library/55483729-5f8a-401a-8072-3cd611ddfed2), [UserConsentVerifier sample](http://go.microsoft.com/fwlink/p/?LinkID=303650), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](http://msdn.microsoft.com/library/53e36ddc-200a-4850-aaf0-07eca3662bb9), [UserConsentVerifier sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620615)
