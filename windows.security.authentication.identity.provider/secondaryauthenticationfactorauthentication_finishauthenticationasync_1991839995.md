---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthentication.FinishAuthenticationAsync(Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorFinishAuthenticationStatus> FinishAuthenticationAsync(Windows.Storage.Streams.IBuffer deviceHmac, Windows.Storage.Streams.IBuffer sessionHmac)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthentication.FinishAuthenticationAsync

## -description
Finishes an authentication with a companion device.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -parameters
### -param deviceHmac
The authentication device HMAC.

### -param sessionHmac
The session HMAC.

## -returns
When this method completes, it returns the status of the operation finishing.

## -remarks

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)