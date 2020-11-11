---
-api-id: T:Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceWatcherStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceWatcherStatus : int
-->

# DnssdServiceWatcherStatus

## -description
Values representing the status of a [DnssdServiceWatcher](dnssdservicewatcher.md).

> [!NOTE]
> DnssdServiceWatcher is not supported and may be altered or unavailable in the future. Instead, use the Windows.Devices.Enumeration API.

> [!NOTE]
> Win32 DNS Service Discovery (DNS-SD) APIs are declared in the [windns.h header](/windows/win32/api/windns/). For example, the Win32 APIs for announcing and discovering services are [DnsServiceRegister](/windows/win32/api/windns/nf-windns-dnsserviceregister) and [DnsServiceBrowse](/windows/win32/api/windns/nf-windns-dnsservicebrowse).

## -enum-fields
### -field Created:0
The watcher has been created.

### -field Started:1
The watcher has acknowledged receiving a start command.

### -field EnumerationCompleted:2
The watcher has finished enumerating service instances.

### -field Stopping:3
The watcher has acknowledged receiving a stop command.

### -field Stopped:4
The watcher has completed processing a stop command.

### -field Aborted:5
The watcher has been aborted in the process of enumerating service instances.


## -remarks

## -examples

## -see-also