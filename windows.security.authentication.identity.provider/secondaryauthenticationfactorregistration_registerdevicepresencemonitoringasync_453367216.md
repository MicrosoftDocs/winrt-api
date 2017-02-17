---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync(System.String,System.String,Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresenceMonitoringMode,System.String,System.String,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<SecondaryAuthenticationFactorDevicePresenceMonitoringRegistrationStatus> SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync(String deviceId, String deviceInstancePath, SecondaryAuthenticationFactorDevicePresenceMonitoringMode monitoringMode, String deviceFriendlyName, String deviceModelNumber, IBuffer deviceConfigurationData)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.RegisterDevicePresenceMonitoringAsync

## -description
Registers a companion device for presence monitoring by the main device.

## -parameters

### -param deviceId
The unique identifier for the companion device.

### -param deviceInstancePath
The device instance path string.

### -param monitoringMode
A [**SecondaryAuthenticationFactorDevicePresenceMonitoringMode**](SecondaryAuthenticationFactorDevicePresenceMonitoringMode.md) value describing the monitoring mode type that will be used.

### -param deviceFriendlyName
The friendly name of the device.

### -param deviceModelNumber
The model number of the device.

### -param deviceConfigurationData
A byte array of device configuration data.

## -returns
An asynchronous operation with the status of the registration.

## -remarks

## -see-also

## -examples

