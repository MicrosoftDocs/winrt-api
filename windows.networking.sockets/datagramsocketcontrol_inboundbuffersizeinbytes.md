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
The [InboundBufferSizeInBytes](datagramsocketcontrol_inboundbuffersizeinbytes.md) property sets the value of the **SO_RCVBUF** socket option on the TCP socket used by the [DatagramSocket](datagramsocket.md). The default value is the local computer's default receive buffer size. For more detailed information, see [SOL_SOCKET Socket Options](https://msdn.microsoft.com/library/0cd0056e-0c33-4f6e-9f70-5417f8f8da4b) in the Windows Sockets documentation.

This property may be set before the [DatagramSocket](datagramsocket.md) is bound or connected. After the [DatagramSocket](datagramsocket.md) is bound or connected, setting this property will result in an error.

## -examples

## -see-also
[How to use advanced socket controls  ](https://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls  ](https://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [DatagramSocket](datagramsocket.md)
