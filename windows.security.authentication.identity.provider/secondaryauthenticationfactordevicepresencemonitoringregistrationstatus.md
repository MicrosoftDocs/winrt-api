---
-api-id: T:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus : int 
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus

## -description
**Deprecated.** Contains values that describe the status of the registration of a companion device for presence monitoring.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -enum-fields
### -field Unsupported:0
Presence monitoring is not supported on this device.

### -field Succeeded:1
The device was registered for presence monitoring successfully.

### -field DisabledByPolicy:2
Presence monitoring registration was prevented by a policy setting on the device.

## -remarks

## -see-also

## -examples