---
-api-id: M:Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstanceCollection.GetAt(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance GetAt(System.UInt32 index)
-->

# Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstanceCollection.GetAt

## -description
Gets the [DnssdServiceInstance](dnssdserviceinstance.md) at a given index into the [DnssdServiceInstanceCollection](dnssdserviceinstancecollection.md).

> [!NOTE]
> DnssdServiceInstanceCollection is not supported and may be altered or unavailable in the future. Instead, use the Windows.Devices.Enumeration API.

## -parameters
### -param index
The index of the instance to be retrieved. Indices are 0-based. If your code specifies an index that is out of bounds, an exception is thrown. The maximum valid index is equal to one less than the [DnssdServiceInstanceCollection.Size](dnssdserviceinstancecollection_size.md) value.

## -returns
The [DnssdServiceInstance](dnssdserviceinstance.md) at the given index in the collection.

## -remarks

## -examples

## -see-also
