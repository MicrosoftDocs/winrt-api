---
-api-id: P:Windows.Networking.Connectivity.NetworkAdapter.IanaInterfaceType
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint IanaInterfaceType { get; }
-->

# Windows.Networking.Connectivity.NetworkAdapter.IanaInterfaceType

## -description
Gets the network interface type as defined by the Internet Assigned Numbers Authority (IANA) for the  
[NetworkAdapter](networkadapter.md).  
The table lists common values; many other values are possible (see Remarks).

## -property-value
The interface type as defined by the Internet Assigned Names Authority (IANA). The table below lists common values for the interface type, although many other values are possible (see **Remarks**).

|Value|Description|
|-|-|
|1|Some other type of network interface.|
|6|An Ethernet network interface.|
|9|A token ring network interface.|
|23|A PPP network interface.|
|24|A software loopback network interface.|
|37|An ATM network interface.|
|71|An IEEE 802.11 wireless network interface.|
|131|A tunnel type encapsulation network interface.|
|144|An IEEE 1394 (Firewire) high performance serial bus network interface.|

## -remarks
This property represents the interface type as defined by the Internet Assigned Numbers Authority (IANA).  
For the complete, current list of possible values, see the IANA ifType registry:  
<https://www.iana.org/assignments/ianaiftype-mib/ianaiftype-mib>.  
> [!NOTE]  
> Values outside the table may appear as new interface types are assigned. Handle unknown values defensively.

## -examples

## -see-also
[NetworkAdapter](networkadapter.md),
[NetworkAdapter.InboundMaxBitsPerSecond](networkadapter_inboundmaxbitspersecond.md),
[NetworkAdapter.NetworkAdapterId](networkadapter_networkadapterid.md),
[NetworkAdapter.OutboundMaxBitsPerSecond](networkadapter_outboundmaxbitspersecond.md)
