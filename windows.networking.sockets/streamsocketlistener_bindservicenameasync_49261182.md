---
-api-id: M:Windows.Networking.Sockets.StreamSocketListener.BindServiceNameAsync(System.String,Windows.Networking.Sockets.SocketProtectionLevel)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction BindServiceNameAsync(System.String localServiceName, Windows.Networking.Sockets.SocketProtectionLevel protectionLevel)
-->

# Windows.Networking.Sockets.StreamSocketListener.BindServiceNameAsync

## -description
Starts a bind operation on a [StreamSocketListener](streamsocketlistener.md) to a local service name with a specified [SocketProtectionLevel](socketprotectionlevel.md) to set on any bound sockets.

## -parameters
### -param localServiceName
The local service name or TCP port on which to bind the [StreamSocketListener](streamsocketlistener.md) object. For Bluetooth RFCOMM, this parameter is the Bluetooth Service ID.

### -param protectionLevel
The protection level for encryption to set on any bound sockets.

## -returns
The asynchronous bind operation on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The [BindServiceNameAsync(String, SocketProtectionLevel)](streamsocketlistener_bindservicenameasync_49261182.md) method binds to the local IP addresses of all network interfaces on the local computer and to the local service name or TCP port specified in the *localServiceName* parameter. For Bluetooth RFCOMM, this method binds to the Bluetooth Service ID specified in the *localServiceName* parameter on all Bluetooth interfaces. This method sets the protection level for encryption on any bound sockets to the *protectionLevel* parameter.

If the *localServiceName* parameter is an empty string, then the system will select the local TCP port on which to bind. A Bluetooth Service ID must be supplied to bind for Bluetooth.

The [BindServiceNameAsync(String, SocketProtectionLevel)](streamsocketlistener_bindservicenameasync_49261182.md) method will fail if another app (another [StreamSocketListener](streamsocketlistener.md), for example) has already been bound to the local TCP port or Bluetooth Service ID specified in the *localServiceName* parameter.

The *protectionLevel* parameter must be set to **PlainSocket** for all sockets except those used over Bluetooth. When the socket is to be used over Bluetooth, the *protectionLevel* parameter can be set to **PlainSocket**, **BluetoothEncryptionAllowNullAuthentication**, or **BluetoothEncryptionWithAuthentication**. For more information, see the [SocketProtectionLevel](socketprotectionlevel.md) enumeration.

## -examples

## -see-also
[BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md), [BindServiceNameAsync(String)](streamsocketlistener_bindservicenameasync_673478814.md), [SocketProtectionLevel](socketprotectionlevel.md), [StreamSocketListenerInformation](streamsocketlistenerinformation.md)