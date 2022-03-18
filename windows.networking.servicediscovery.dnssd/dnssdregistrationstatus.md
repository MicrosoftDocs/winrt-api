---
-api-id: T:Windows.Networking.ServiceDiscovery.Dnssd.DnssdRegistrationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.ServiceDiscovery.Dnssd.DnssdRegistrationStatus : int
-->

# DnssdRegistrationStatus

## -description
Values representing the status of a DNS-SD registration attempt.

> [!NOTE]
> Win32 DNS Service Discovery (DNS-SD) APIs are declared in the [windns.h header](/windows/win32/api/windns/). For example, the Win32 APIs for announcing and discovering services are [DnsServiceRegister](/windows/win32/api/windns/nf-windns-dnsserviceregister) and [DnsServiceBrowse](/windows/win32/api/windns/nf-windns-dnsservicebrowse).

## -enum-fields
### -field Success:0
The service has been registered successfully.

### -field InvalidServiceName:1
The service was not registered because the service name provided is not valid.

### -field ServerError:2
The service was not registered because of an error on the DNS server.

### -field SecurityError:3
The service was not registered because security settings did not allow it.


## -remarks

## -examples

## -see-also