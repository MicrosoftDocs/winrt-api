---
-api-id: P:Windows.Networking.Sockets.DatagramSocketControl.DontFragment
-api-type: winrt property
---

<!-- Property syntax
public bool DontFragment { get;  set; }
-->

# Windows.Networking.Sockets.DatagramSocketControl.DontFragment

## -description
Gets or sets a Boolean value that specifies whether the [DatagramSocket](datagramsocket.md) allows IP datagrams for UDP to be fragmented.

## -property-value
Whether the [DatagramSocket](datagramsocket.md) allows datagrams to be fragmented.

**true** if the [DatagramSocket](datagramsocket.md) shouldn't fragment datagrams; otherwise, **false**. The default is **false** which allows datagrams to be fragmented.

## -remarks
The DontFragment property lets your app decide whether the [DatagramSocket](datagramsocket.md) allows datagrams to be fragmented. The default value is **false** which allows datagrams to be fragmented.

IP datagrams used by UDP require fragmentation when their size exceeds the Maximum Transfer Unit (MTU) of the network transmission hardware. Datagrams may be fragmented by the sending app or by an intermediate router (IPv4 only). If a datagram must be fragmented, and the DontFragment property is set to **true**, the datagram is discarded, and an Internet Control Message Protocol (ICMP) error message is sent back to the sender of the datagram.

This property may be set before the [DatagramSocket](datagramsocket.md) is bound or connected. After the [DatagramSocket](datagramsocket.md) is bound or connected, setting this property will result in an error.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [DatagramSocket](datagramsocket.md)
