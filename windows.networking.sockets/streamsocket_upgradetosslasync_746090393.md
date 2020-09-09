---
-api-id: M:Windows.Networking.Sockets.StreamSocket.UpgradeToSslAsync(Windows.Networking.Sockets.SocketProtectionLevel,Windows.Networking.HostName)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction UpgradeToSslAsync(Windows.Networking.Sockets.SocketProtectionLevel protectionLevel, Windows.Networking.HostName validationHostName)
-->

# Windows.Networking.Sockets.StreamSocket.UpgradeToSslAsync

## -description
Starts an asynchronous operation to upgrade a connected socket to use SSL on a [StreamSocket](streamsocket.md) object.

## -parameters
### -param protectionLevel
The protection level that represents the integrity and encryption on the [StreamSocket](streamsocket.md) object.

### -param validationHostName
The hostname of the remote network destination that is used for validation when upgrading to SSL.

## -returns
An asynchronous operation to upgrade to use SSL on a [StreamSocket](streamsocket.md) object.

## -remarks
The UpgradeToSslAsync method can only be used to upgrade an already established connection made with a [SocketProtectionLevel](socketprotectionlevel.md) of **PlainSocket**.

The typical order of operations to establish an SSL connection is as follows:


+ Create the [StreamSocket](streamsocket.md).
+ Get socket control data on a [StreamSocketControl](streamsocketcontrol.md) object using the [Control](streamsocket_control.md) property and set any properties before calling one of the [ConnectAsync](streamsocket_connectasync_13692504.md) methods.
+ Call one of the [ConnectAsync](streamsocket_connectasync_13692504.md) methods to establish a connection with the remote endpoint. If an SSL/TLS connection is required immediately, this can be specified using some of the [ConnectAsync](streamsocket_connectasync_13692504.md) methods. If an SSL/TLS connection is desired after sending and receiving some initial data, then the UpgradeToSslAsync method can be called later to upgrade the connection to use SSL.
+ Get the [OutputStream](streamsocket_outputstream.md) property to write data to the remote host.
+ Get the [InputStream](streamsocket_inputstream.md) property to read data from the remote host.
+ Read and write data as needed.
+ Call the [Close](streamsocket_close_811482585.md) method to abort any pending operations and release all unmanaged resources associated with the [StreamSocket](streamsocket.md) object.
The UpgradeToSslAsync method requires that the remote server to which the connection was established is able to upgrade a TCP connection to an SSL connection.

The UpgradeToSslAsync method can only be used for client connections. This method can't be used to upgrade a connection accepted by the [StreamSocketListener](streamsocketlistener.md) to an SSL connection. The UpgradeToSslAsync method only implements the client parts of the SSL protocol negotiation, not the server parts that would be needed to listen for and accept SSL connections.

## -examples

## -see-also
[HostName](../windows.networking/hostname.md), [How to secure socket connections with TLS/SSL](/previous-versions/windows/apps/hh780595(v=win.10)), [SocketProtectionLevel](socketprotectionlevel.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
