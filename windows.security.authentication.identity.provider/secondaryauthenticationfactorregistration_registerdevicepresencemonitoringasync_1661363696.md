---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync(System.String,System.String,Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringMode)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync(String deviceId, String deviceInstancePath, SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync

## -description
**Deprecated.** Registers a companion device for presence monitoring by the main device.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -parameters

### -param deviceId
The unique identifier for the companion device.

### -param deviceInstancePath
The device instance path string.

### -param monitoringMode
A [SecondaryAuthenticationFactorDevicePresenceMonitoringMode](SecondaryAuthenticationFactorDevicePresenceMonitoringMode.md) value describing the monitoring mode type that will be used.

## -returns
An asynchronous operation with the status of the registration.

## -remarks
A companion device must be registered for secondary authentication before it is optionally registered for device presence monitoring.

## -see-also

## -examples