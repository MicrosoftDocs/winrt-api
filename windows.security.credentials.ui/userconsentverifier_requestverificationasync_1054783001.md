---
-api-id: M:Windows.Security.Credentials.UI.UserConsentVerifier.RequestVerificationAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Credentials.UI.UserConsentVerificationResult> RequestVerificationAsync(System.String message)
-->

# Windows.Security.Credentials.UI.UserConsentVerifier.RequestVerificationAsync

## -description
Performs a verification using an authentication device such as Microsoft Passport PIN, Windows Hello, or a fingerprint reader. This API is for Universal Windows Platform (UWP) apps. The alternative API to use for a desktop app is described in **Examples** in [UserConsentVerifier class](/uwp/api/windows.security.credentials.ui.userconsentverifier).

## -parameters
### -param message
A message to display to the user for this verification request.

## -returns
A [UserConsentVerificationResult](userconsentverificationresult.md) value that describes the result of the verification.

## -remarks
You can use the RequestVerificationAsync method to request user consent for a sensitive operation. For example, you can require device authentication before authorizing an in-app purchase, or access to restricted resources. You can use the [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md) method to determine if authentication is supported for the current user.

## -examples

See **Examples** in [UserConsentVerifier class](/uwp/api/windows.security.credentials.ui.userconsentverifier).

## -see-also
[UserConsentVerifier class](/uwp/api/windows.security.credentials.ui.userconsentverifier), [Fingerprint biometrics](/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/UserConsentVerifier), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity)
