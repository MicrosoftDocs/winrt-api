---
-api-id: P:Windows.Networking.Connectivity.NetworkAdapter.OutboundMaxBitsPerSecond
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public ulong OutboundMaxBitsPerSecond { get; }
-->

# Windows.Networking.Connectivity.NetworkAdapter.OutboundMaxBitsPerSecond

## -description
Gets a value indicating the maximum outbound speed in bits per second.

## -property-value
The maximum outbound transfer rate in bits per second.

## -remarks
This property represents the current speed in bits per second of the transmit link for the [NetworkAdapter](networkadapter.md). This value represents the maximum speed of the interface and is generally much higher than the actual speed when sending network data on this link, particularly for wireless networks.

## -examples

## -see-also
[InboundMaxBitsPerSecond](networkadapter_inboundmaxbitspersecond.md)