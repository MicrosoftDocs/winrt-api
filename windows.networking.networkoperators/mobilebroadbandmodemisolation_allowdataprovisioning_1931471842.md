---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandModemIsolation.AllowDataProvisioning
-api-type: winrt method
---

<!-- Method syntax.
public void MobileBroadbandModemIsolation.AllowDataProvisioning()
-->

# Windows.Networking.NetworkOperators.MobileBroadbandModemIsolation.AllowDataProvisioning

## -description
Adds data-provisioning rules to the mobile broadband modem isolation configuration, allowing Windows data-purchasing processes and applications to access the network connectivity in the cellular interface.

## -remarks
You should call this method before you call [ApplyConfigurationAsync](mobilebroadbandmodemisolation_applyconfigurationasync_10015633.md). The data-provisioning rules will be cleared after you call [ClearConfigurationAsync](mobilebroadbandmodemisolation_clearconfigurationasync_491705556.md).

## -see-also

## -examples

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
