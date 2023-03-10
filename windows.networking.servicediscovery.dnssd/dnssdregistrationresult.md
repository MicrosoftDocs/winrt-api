---
-api-id: T:Windows.Networking.ServiceDiscovery.Dnssd.DnssdRegistrationResult
-api-type: winrt class
---

<!-- Class syntax.
public class DnssdRegistrationResult : Windows.Foundation.IStringable, Windows.Networking.ServiceDiscovery.Dnssd.IDnssdRegistrationResult
-->

# Windows.Networking.ServiceDiscovery.Dnssd.DnssdRegistrationResult

## -description
Encapsulates detailed information about the result of an attempt to register a service instance using DNS-SD.

> [!NOTE]
> Win32 DNS Service Discovery (DNS-SD) APIs are declared in the [windns.h header](/windows/win32/api/windns/). For example, the Win32 APIs for announcing and discovering services are [DnsServiceRegister](/windows/win32/api/windns/nf-windns-dnsserviceregister) and [DnsServiceBrowse](/windows/win32/api/windns/nf-windns-dnsservicebrowse).

## -remarks
See [RFC 1034](https://www.ietf.org/rfc/rfc1034.txt) for details about the format and contents of the DNS SRV RR, and [RFC 2782](https://www.ietf.org/rfc/rfc2782.txt) for details about how DNS-SD clients and servers use those records.

If your code attempts to register a service instance with the same name as a previously-registered service, your service will be renamed to avoid a conflict by adding a number in parentheses at the end of the name you specified. For example, if you specified "mygame" and that name was already registered for another service, your service would be renamed to something like, "mygame (2)". When this is done, **HasInstanceNameChanged** is set to **true**.

## -examples

## -see-also
[IStringable](../windows.foundation/istringable.md)