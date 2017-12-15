---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandModemIsolation.AddAllowedHost(Windows.Networking.HostName)
-api-type: winrt method
---

<!-- Method syntax.
public void MobileBroadbandModemIsolation.AddAllowedHost(HostName host)
-->

# Windows.Networking.NetworkOperators.MobileBroadbandModemIsolation.AddAllowedHost

## -description
Adds an allowed host. You can call this method multiple times to add multiple allowed hosts. Traffic to the added host(s) will be allowed after you call [ApplyConfigurationAsync](mobilebroadbandmodemisolation_applyconfigurationasync_10015633.md).

## -parameters
### -param host
The allowed host, whose type must be either IPv4 or IPv6.

## -remarks
You should add hosts before you call [ApplyConfigurationAsync](mobilebroadbandmodemisolation_applyconfigurationasync_10015633.md). The allowed hosts will be cleared after you call [ClearConfigurationAsync](mobilebroadbandmodemisolation_clearconfigurationasync_491705556.md).

## -see-also

## -examples

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
