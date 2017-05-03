---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorInfo.UpdateDevicePresenceAsync(Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresence)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction SecondaryAuthenticationFactorInfo.UpdateDevicePresenceAsync(SecondaryAuthenticationFactorDevicePresence presenceState)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorInfo.UpdateDevicePresenceAsync

## -description
Manually assigns a presence state to a device.

## -parameters

### -param presenceState
A [**SecondaryAuthenticationFactorDevicePresence**](SecondaryAuthenticationFactorDevicePresence.md) value indicating the device's presence state.

## -returns
An asynchronous action for the operation.

## -remarks
This method should only be used when a companion device's monitoring mode is set to [**SecondaryAuthenticationFactorDevicePresenceMonitoringMode.AppManaged**](SecondaryAuthenticationFactorDevicePresenceMonitoringMode.md). In this case, the app that is using the companion device for authentication must incorporate the third party app's presence-monitoring functionality and manually assign a [**SecondaryAuthenticationFactorDevicePresence**](SecondaryAuthenticationFactorDevicePresence.md) value according to the result. 

## -see-also

## -examples

