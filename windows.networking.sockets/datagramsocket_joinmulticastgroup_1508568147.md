---
-api-id: M:Windows.Networking.Sockets.DatagramSocket.JoinMulticastGroup(Windows.Networking.HostName)
-api-type: winrt method
---

<!-- Method syntax
public void JoinMulticastGroup(Windows.Networking.HostName host)
-->

# Windows.Networking.Sockets.DatagramSocket.JoinMulticastGroup

## -description
Joins a [DatagramSocket](datagramsocket.md) object to a multicast group.

## -parameters
### -param host
The hostname or IP address for the multicast group.

## -remarks
To receive multicast packets on the [DatagramSocket](datagramsocket.md) object, an app must assign the [MessageReceived ](datagramsocket_messagereceived.md) event to an event handler, bind to a local service name or UDP port and a local hostname or IP address using the [BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) or [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) method, and then call the JoinMulticastGroup method to join the multicast group.

If a network adapter was specified to the [BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) method, only groups on networks present on the specified adapter will be joined.

An app receiving multicast packets may also need to deal with network adapter changes. If network connectivity changes and the local computer or device is assigned a different IP address, the app needs to rejoin the multicast group.

## -examples

## -see-also


## -capabilities
ID_CAP_NETWORKING [Windows Phone]
