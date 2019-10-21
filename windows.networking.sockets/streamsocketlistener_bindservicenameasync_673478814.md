---
-api-id: M:Windows.Networking.Sockets.StreamSocketListener.BindServiceNameAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction BindServiceNameAsync(System.String localServiceName)
-->

# Windows.Networking.Sockets.StreamSocketListener.BindServiceNameAsync

## -description
Starts a bind operation on a [StreamSocketListener](streamsocketlistener.md) to a local service name.

## -parameters
### -param localServiceName
The local service name or TCP port on which to bind the [StreamSocketListener](streamsocketlistener.md) object. For Bluetooth RFCOMM, this parameter is the Bluetooth Service ID.

## -returns
The asynchronous bind operation on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The BindServiceNameAsync(String) method binds to the local IP addresses of all network interfaces on the local computer and to the local service name or TCP port specified in the *localServiceName* parameter. If the *localServiceName* parameter is an empty string, then the system will select the local TCP port on which to bind.

For Bluetooth RFCOMM, this method binds to the Bluetooth Service ID specified in the *localServiceName* parameter on all Bluetooth interfaces. A Bluetooth Service ID must be supplied to bind for Bluetooth.

The BindServiceNameAsync(String) method will fail if another app (another [StreamSocketListener](streamsocketlistener.md), for example) has already been bound to the local TCP port or Bluetooth Service ID specified in the *localServiceName* parameter.

## -examples

## -see-also
[BindEndpointAsync](streamsocketlistener_bindendpointasync_1396029045.md), [BindServiceNameAsync(String, SocketProtectionLevel)](streamsocketlistener_bindservicenameasync_49261182.md), [BindServiceNameAsync(String, SocketProtectionLevel, NetworkAdapter)](streamsocketlistener_bindservicenameasync_1713574846.md), [StreamSocketListenerInformation](streamsocketlistenerinformation.md)
