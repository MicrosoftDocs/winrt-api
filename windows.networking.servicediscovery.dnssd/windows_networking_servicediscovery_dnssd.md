---
-api-id: N:Windows.Networking.ServiceDiscovery.Dnssd
-api-type: winrt namespace
---

# Windows.Networking.ServiceDiscovery.Dnssd

## -description
Supports the registration and discovery of services that advertise themselves using DNS Service Discovery (DNS-SD).

> [!NOTE]
> Win32 DNS Service Discovery (DNS-SD) APIs are declared in the [windns.h header](/windows/win32/api/windns/). For example, the Win32 APIs for announcing and discovering services are [DnsServiceRegister](/windows/win32/api/windns/nf-windns-dnsserviceregister) and [DnsServiceBrowse](/windows/win32/api/windns/nf-windns-dnsservicebrowse).

## -remarks
Server code uses the members of this namespace to advertise services available to clients on a local network, via DNS Service Discovery (DNS-SD). Client code uses the members of this namespace to identify services being offered via DNS-SD. The actual communication between client and server takes place over sockets, using ports and protocols advertised and discovered through DNS-SD.

DNS-SD is described in [RFC 6763](https://tools.ietf.org/html/rfc6763). For context and general information about DNS, see [RFC 1034](https://tools.ietf.org/html/rfc1034).

## -examples

## -see-also