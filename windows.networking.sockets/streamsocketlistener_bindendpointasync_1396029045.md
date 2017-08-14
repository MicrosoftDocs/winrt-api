---
-api-id: M:Windows.Networking.Sockets.StreamSocketListener.BindEndpointAsync(Windows.Networking.HostName,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction BindEndpointAsync(Windows.Networking.HostName localHostName, System.String localServiceName)
-->

# Windows.Networking.Sockets.StreamSocketListener.BindEndpointAsync

## -description
Starts a bind operation on a [StreamSocketListener](streamsocketlistener.md) to a local hostname and a local service name.

## -parameters
### -param localHostName
The local hostname or IP address on which to bind the [StreamSocketListener](streamsocketlistener.md) object.

### -param localServiceName
The local service name or TCP port on which to bind the [StreamSocketListener](streamsocketlistener.md) object.

## -returns
An asynchronous bind operation on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The [BindEndpointAsync](streamsocketlistener_bindendpointasync.md) method binds a [StreamSocketListener](streamsocketlistener.md) object to a specific hostname or IP address specified in the *localHostName* parameter and the local service name or TCP port specified in the *localServiceName* parameter. If the *localHostName* parameter is null, then the system will select the local IP address to bind to the [StreamSocketListener](streamsocketlistener.md) object . If the *localServiceName* parameter contains an empty string, then the system will select the local TCP port to bind to the [StreamSocketListener](streamsocketlistener.md) object.

The [BindEndpointAsync](streamsocketlistener_bindendpointasync.md) method will fail if another app using TCP (another [StreamSocketListener](streamsocketlistener.md), for example) has already been bound to the local IP address and TCP port specified in the *localHostName* and *localServiceName* parameters.

## -examples

## -see-also
[BindServiceNameAsync](streamsocketlistener_bindservicenameasync.md), [HostName](../windows.networking/hostname.md), [StreamSocketListenerInformation](streamsocketlistenerinformation.md)

## -capabilities
internetClientServer, privateNetworkClientServer, ID_CAP_NETWORKING [Windows Phone]
