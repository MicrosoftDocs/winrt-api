---
-api-id: M:Windows.Networking.Sockets.StreamSocketListener.BindServiceNameAsync(System.String,Windows.Networking.Sockets.SocketProtectionLevel,Windows.Networking.Connectivity.NetworkAdapter)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction BindServiceNameAsync(System.String localServiceName, Windows.Networking.Sockets.SocketProtectionLevel protectionLevel, Windows.Networking.Connectivity.NetworkAdapter adapter)
-->

# Windows.Networking.Sockets.StreamSocketListener.BindServiceNameAsync

## -description
Starts a socket bind operation on a [StreamSocketListener](streamsocketlistener.md) to a local service name on a specified network adapter with a specified [SocketProtectionLevel](socketprotectionlevel.md) to set on any bound sockets.

## -parameters
### -param localServiceName
The local service name or TCP port on which to bind the [StreamSocketListener](streamsocketlistener.md) object. For Bluetooth RFCOMM, this parameter is the Bluetooth Service ID.

### -param protectionLevel
The protection level for encryption to set on any bound sockets.

### -param adapter
The network adapter on which to bind the [StreamSocketListener](streamsocketlistener.md) object.

## -returns
The asynchronous bind operation on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The [BindServiceNameAsync(String, SocketProtectionLevel, NetworkAdapter) method binds to the local service name or TCP port specified in the *localServiceName* parameter on the network adapter specified in the *adapter* parameter on the local computer. For Bluetooth RFCOMM, this method binds to the Bluetooth Service ID specified in the *localServiceName* parameter if the *adapter* parameter is **null**. A Bluetooth Service ID must be supplied to bind for Bluetooth. If a network adapter is specified in the *adapter* parameter and the *localServiceName* parameter contains a Bluetooth Service ID, then this method will fail.

This method sets the protection level for encryption on any bound sockets to the *protectionLevel* parameter.

If the *localServiceName* parameter is an empty string, then the system will select the local TCP port on which to bind. If the *adapter* parameter is **null** for a TCP socket bind, an error will occur.

The name resolution mechanism used by the [BindServiceNameAsync(String, SocketProtectionLevel, NetworkAdapter) method is limited to the specified interface for the domain name system (DNS) namespace.

The [BindServiceNameAsync(String, SocketProtectionLevel, NetworkAdapter) method will fail if another app (another [StreamSocketListener](streamsocketlistener.md), for example) has already been bound to the local TCP port specified in the *localServiceName* parameter on the network adapter specified in the *adapter* parameter. For Bluetooth, this method will fail if another app (another [StreamSocketListener](streamsocketlistener.md), for example) has already been bound to the Bluetooth Service ID specified in the *localServiceName* parameter.

Using the specified network adapter is on a best-effort basis. A system with adapters configured in weak-host or forwarding modes may use an adapter other than the specified adapter.

The *protectionLevel* parameter must be set to **PlainSocket** for all sockets except those used over Bluetooth. When the socket is to be used over Bluetooth, the *protectionLevel* parameter can be set to **PlainSocket**, **BluetoothEncryptionAllowNullAuthentication**, or **BluetoothEncryptionWithAuthentication**. For more information, see the [SocketProtectionLevel](socketprotectionlevel.md) enumeration.

## -examples

## -see-also
[BindServiceNameAsync(String)](streamsocketlistener_bindservicenameasync_673478814.md), [BindServiceNameAsync(String, SocketProtectionLevel)](streamsocketlistener_bindservicenameasync_49261182.md), [SocketProtectionLevel](socketprotectionlevel.md), [StreamSocketListenerInformation](streamsocketlistenerinformation.md)
