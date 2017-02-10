---
-api-id: P:Windows.Networking.Sockets.StreamSocketControl.KeepAlive
-api-type: winrt property
---

<!-- Property syntax
public bool KeepAlive { get;  set; }
-->

# Windows.Networking.Sockets.StreamSocketControl.KeepAlive

## -description
A value that indicates whether keep-alive packets are sent to the remote destination on a [StreamSocket](streamsocket.md) object.

## -property-value
Whether keep-alive packets are sent to the remote destination.

## -remarks
When this property is **true**, the [StreamSocket](streamsocket.md) sends keep-alive packets when no data or acknowledgment packets have been received for the TCP connection within an interval. When a [StreamSocket](streamsocket.md) is created, the default value for this property is **false**.

This property may be set before the [StreamSocket](streamsocket.md) is connected. After the [StreamSocket](streamsocket.md) is connected, setting the property will result in an error.

For more detailed information, see the [SO_KEEPALIVE](http://msdn.microsoft.com/library/d6da7761-7a09-4c91-9737-550590a773b3) socket option in the Windows Sockets documentation.

## -examples

## -see-also
[How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]