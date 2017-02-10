---
-api-id: P:Windows.Networking.Sockets.StreamSocketListenerControl.OutboundBufferSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public uint OutboundBufferSizeInBytes { get;  set; }
-->

# Windows.Networking.Sockets.StreamSocketListenerControl.OutboundBufferSizeInBytes

## -description
The size, in bytes, of the send buffer to be used for sending data on a [StreamSocket](streamsocket.md) object created when a connection is received by the [StreamSocketListener](streamsocketlistener.md) object.

## -property-value
The size, in bytes, of the send buffer to be used for sending data on the [StreamSocket](streamsocket.md) object created.

## -remarks
The [OutboundBufferSizeInBytes](streamsocketlistenercontrol_outboundbuffersizeinbytes.md) property sets the value of the **SO_SNDBUF** socket option on the TCP socket used by the [StreamSocket](streamsocket.md) created. The default value is the local computer's default send buffer size. This value varies based on the system memory size. For more detailed information, see [SOL_SOCKET Socket Options](http://msdn.microsoft.com/library/0cd0056e-0c33-4f6e-9f70-5417f8f8da4b) in the Windows Sockets documentation.

For most apps, this property should not be set since this disables TCP send auto-tuning by the system on this [StreamSocket](streamsocket.md) object. With TCP send auto-tuning disabled, network throughput is often worse especially on a connections with high latency. So this property should only be used in very specific situations.

This property may be set before the [StreamSocketListener](streamsocketlistener.md) starts listening for incoming connections. After the [StreamSocketListener](streamsocketlistener.md) starts listening for incoming connections, setting the property will result in an error.

## -examples

## -see-also
[How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [SOL_SOCKET Socket Options](http://msdn.microsoft.com/library/0cd0056e-0c33-4f6e-9f70-5417f8f8da4b), [StreamSocket](streamsocket.md), [StreamSocketListener](streamsocketlistener.md)