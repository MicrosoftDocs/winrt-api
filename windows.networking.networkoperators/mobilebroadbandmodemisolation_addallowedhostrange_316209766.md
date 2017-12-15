---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandModemIsolation.AddAllowedHostRange(Windows.Networking.HostName,Windows.Networking.HostName)
-api-type: winrt method
---

<!-- Method syntax.
public void MobileBroadbandModemIsolation.AddAllowedHostRange(HostName first, HostName last)
-->

# Windows.Networking.NetworkOperators.MobileBroadbandModemIsolation.AddAllowedHostRange

## -description
Adds a range of allowed hosts. You can call this method multiple times to add multiple ranges of allowed hosts. Traffic to the added host(s) will be allowed after you call [ApplyConfigurationAsync](mobilebroadbandmodemisolation_applyconfigurationasync_10015633.md).

## -parameters
### -param first
The first allowed host in the range. Its type must be either IPv4 or IPv6.

### -param last
The last allowed host in the range. Its type must be the same as that of *first*.

## -remarks
You should add hosts before you call [ApplyConfigurationAsync](mobilebroadbandmodemisolation_applyconfigurationasync_10015633.md). The allowed hosts will be cleared after you call [ClearConfigurationAsync](mobilebroadbandmodemisolation_clearconfigurationasync_491705556.md).

## -see-also

## -examples

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
