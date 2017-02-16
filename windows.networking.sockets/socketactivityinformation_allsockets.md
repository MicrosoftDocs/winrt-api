---
-api-id: P:Windows.Networking.Sockets.SocketActivityInformation.AllSockets
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, Windows.Networking.Sockets.SocketActivityInformation> AllSockets { get; }
-->

# Windows.Networking.Sockets.SocketActivityInformation.AllSockets

## -description
Gets a list of all the sockets transferred to the socket brokering service by this app.

## -property-value
A list of all the sockets transferred to the socket brokering service by this app.

## -remarks
When a new instance of your app has become active, and you want the new instance to take ownership of the sockets that a previous instance of your app transferred to the socket broker, use the static [AllSockets](socketactivityinformation_allsockets.md) collection to enumerate the sockets associated with your app. For each socket in the collection, transfer ownership to the current app instance by getting the appropriate socket object ([DatagramSocket](datagramsocket.md), [StreamSocket](streamsocket.md), or [StreamSocketListener](streamsocketlistener.md)), as indicated by the [SocketKind](socketactivityinformation_socketkind.md) property. Using the property getter for the socket object transfers ownership of the socket back from the socket broker to your app.

Note that your code is only allowed to transfer ownership of a socket to a socket object whose type that matches the [SocketActivityKind](socketactivitykind.md) of the socket being transferred. Attempting to use the wrong type of socket object will fail.

## -examples

## -see-also
