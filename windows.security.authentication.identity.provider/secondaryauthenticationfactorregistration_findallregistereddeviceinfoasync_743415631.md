---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.FindAllRegisteredDeviceInfoAsync(Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceFindScope)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorInfo>> FindAllRegisteredDeviceInfoAsync(Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceFindScope queryType)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.FindAllRegisteredDeviceInfoAsync

## -description
Returns info on found registered devices.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -parameters
### -param queryType
The scope of devices to find.

## -returns
When this method completes, it returns device info for the found registered devices.

## -remarks

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)