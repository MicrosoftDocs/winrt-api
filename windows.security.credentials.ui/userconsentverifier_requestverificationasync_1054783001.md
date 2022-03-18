---
-api-id: M:Windows.Security.Credentials.UI.UserConsentVerifier.RequestVerificationAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Credentials.UI.UserConsentVerificationResult> RequestVerificationAsync(System.String message)
-->

# Windows.Security.Credentials.UI.UserConsentVerifier.RequestVerificationAsync

## -description
Performs a verification using a device such as Microsoft Passport PIN, Windows Hello, or a fingerprint reader.

## -parameters
### -param message
A message to display to the user for this biometric verification request.

## -returns
A [UserConsentVerificationResult](userconsentverificationresult.md) value that describes the result of the biometric verification.

## -remarks
You can use the RequestVerificationAsync method to request user consent for authentication. For example, you can require fingerprint authentication before authorizing an in-app purchase, or access to restricted resources. You can use the [CheckAvailabilityAsync](userconsentverifier_checkavailabilityasync_167910294.md) method to determine if authentication is supported for the current computer .

## -examples

## -see-also
[Fingerprint biometrics](/windows/uwp/security/fingerprint-biometrics), [UserConsentVerifier sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/UserConsentVerifier), [Windows.Security.Credentials.UI](windows_security_credentials_ui.md), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity)
