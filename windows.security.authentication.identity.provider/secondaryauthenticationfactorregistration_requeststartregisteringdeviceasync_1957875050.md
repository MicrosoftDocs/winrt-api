---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.RequestStartRegisteringDeviceAsync(System.String,Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceCapabilities,System.String,System.String,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistrationResult> RequestStartRegisteringDeviceAsync(System.String deviceId, Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceCapabilities capabilities, System.String deviceFriendlyName, System.String deviceModelNumber, Windows.Storage.Streams.IBuffer deviceKey, Windows.Storage.Streams.IBuffer mutualAuthenticationKey)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorRegistration.RequestStartRegisteringDeviceAsync

## -description
Starts registering a companion device.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -parameters
### -param deviceId
The Id of the device.

### -param capabilities
The device capabilities.

### -param deviceFriendlyName
The device friendly name.

### -param deviceModelNumber
The device model number.

### -param deviceKey
The device key.

### -param mutualAuthenticationKey
The mutual authentication key.

## -returns
An asynchronous operation with a registration result instance.

## -remarks
A companion device must be registered for secondary authentication before it is optionally registered for device presence monitoring.

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)