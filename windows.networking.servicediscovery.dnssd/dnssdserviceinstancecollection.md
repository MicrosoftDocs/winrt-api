---
-api-id: T:Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstanceCollection
-api-type: winrt class
---

<!-- Class syntax.
public class DnssdServiceInstanceCollection : Windows.Foundation.Collections.IIterable<Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance>, Windows.Foundation.Collections.IVectorView<Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance>
-->

# Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstanceCollection

## -description
A collection of DNS Service Discovery (DNS-SD) service instances.

> [!NOTE]
> DnssdServiceInstanceCollection is not supported and may be altered or unavailable in the future. Instead, use the Windows.Devices.Enumeration API.

## -remarks
Your code does not create a DnssdServiceInstanceCollection directly. Instead, handle the [DnssdServiceWatcher.EnumerationCompleted](dnssdservicewatcher_enumerationcompleted.md) event. When that event is triggered, the second argument to the event handler is a pointer to a DnssdServiceInstanceCollection object that contains information about the discovered service instances.

## -examples

## -see-also
[IVectorView(DnssdServiceInstance)](../windows.foundation.collections/ivectorview_1.md), [IIterable(DnssdServiceInstance)](../windows.foundation.collections/iiterable_1.md)
