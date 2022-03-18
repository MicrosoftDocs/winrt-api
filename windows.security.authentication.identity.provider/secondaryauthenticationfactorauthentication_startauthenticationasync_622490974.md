---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthentication.StartAuthenticationAsync(System.String,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationResult> StartAuthenticationAsync(System.String deviceId, Windows.Storage.Streams.IBuffer serviceAuthenticationNonce)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthentication.StartAuthenticationAsync

## -description
Start an authentication with a companion device.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -parameters
### -param deviceId
The Id of the device to authenticate with.

### -param serviceAuthenticationNonce
The service authentication nonce.

## -returns
When this method completes, it returns the results of the authentication.

## -remarks

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)