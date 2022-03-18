---
-api-id: T:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration
-api-type: winrt class
---

<!-- Class syntax.
public class SecondaryAuthenticationFactorRegistration : Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorRegistration
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration

## -description
Contains methods for registering companion devices.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | IsDevicePresenceMonitoringSupported |
| 1703 | 15063 | RegisterDevicePresenceMonitoringAsync(String,String,SecondaryAuthenticationFactorDevicePresenceMonitoringMode) |
| 1703 | 15063 | RegisterDevicePresenceMonitoringAsync(String,String,SecondaryAuthenticationFactorDevicePresenceMonitoringMode,String,String,IBuffer) |
| 1703 | 15063 | UnregisterDevicePresenceMonitoringAsync |

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)