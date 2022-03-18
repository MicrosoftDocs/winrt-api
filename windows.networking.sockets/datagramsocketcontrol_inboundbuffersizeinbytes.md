---
-api-id: P:Windows.Networking.Sockets.DatagramSocketControl.InboundBufferSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public uint InboundBufferSizeInBytes { get;  set; }
-->

# Windows.Networking.Sockets.DatagramSocketControl.InboundBufferSizeInBytes

## -description
Gets or sets the size, in bytes, of the buffer used for receiving data on the [DatagramSocket](datagramsocket.md) object.

## -property-value
The size, in bytes, of the buffer used for receiving data on the [DatagramSocket](datagramsocket.md) object.

## -remarks
The InboundBufferSizeInBytes property sets the value of the **SO_RCVBUF** socket option on the TCP socket used by the [DatagramSocket](datagramsocket.md). The default value is the local computer's default receive buffer size. For more detailed information, see [SOL_SOCKET Socket Options](/windows/desktop/WinSock/sol-socket-socket-options) in the Windows Sockets documentation.

This property may be set before the [DatagramSocket](datagramsocket.md) is bound or connected. After the [DatagramSocket](datagramsocket.md) is bound or connected, setting this property will result in an error.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [DatagramSocket](datagramsocket.md)
