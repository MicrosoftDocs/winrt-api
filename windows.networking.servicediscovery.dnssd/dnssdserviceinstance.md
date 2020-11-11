---
-api-id: T:Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance
-api-type: winrt class
---

<!-- Class syntax.
public class DnssdServiceInstance : Windows.Foundation.IStringable, Windows.Networking.ServiceDiscovery.Dnssd.IDnssdServiceInstance
-->

# Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance

## -description
Encapsulates an instance of a service that uses DNS Service Discovery (DNS-SD).

> [!NOTE]
> Win32 DNS Service Discovery (DNS-SD) APIs are declared in the [windns.h header](/windows/win32/api/windns/). For example, the Win32 APIs for announcing and discovering services are [DnsServiceRegister](/windows/win32/api/windns/nf-windns-dnsserviceregister) and [DnsServiceBrowse](/windows/win32/api/windns/nf-windns-dnsservicebrowse).

## -remarks
Use this class if you are providing a service that advertises itself to other DNS-SD users, or if you are consuming services advertised via DNS-SD.

If your code attempts to register a service instance with the same name as a previously-registered service, your service will be renamed to avoid a conflict by adding a number in parentheses at the end of the name you specified. For example, if you specified "mygame" and that name was already registered for another service, your service would be renamed to something like, "mygame (2)". When this is done, [DnssdRegistrationResult.HasInstanceNameChanged](dnssdregistrationresult_hasinstancenamechanged.md) is set to **true**.



## -examples

## -see-also
[IStringable](../windows.foundation/istringable.md)