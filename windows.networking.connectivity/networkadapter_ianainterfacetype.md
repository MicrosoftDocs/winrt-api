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
Gets a value indicating the network interface type as defined by the Internet Assigned Names Authority (IANA) for the [NetworkAdapter](networkadapter.md).

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
This property represents the interface type as defined by the Internet Assigned Names Authority (IANA). For a list of possible values, see [http://www.iana.org/assignments/ianaiftype-mib](https://www.iana.org/assignments/ianaiftype-mib/ianaiftype-mib).

## -examples

## -see-also
