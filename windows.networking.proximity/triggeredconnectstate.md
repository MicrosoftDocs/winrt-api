---
-api-id: T:Windows.Networking.Proximity.TriggeredConnectState
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.Proximity.TriggeredConnectState : int
-->

# TriggeredConnectState

## -description
Indicates the current state of a connection to a peer application.

## -enum-fields
### -field PeerFound:0
A device that supports proximity socket connections is within proximity. The tap gesture is complete.

### -field Listening:1
This side of the socket connection will be the host and is waiting for a connection from the peer.

### -field Connecting:2
This side of the socket connection will be the client and is attempting to connect to the peer.

### -field Completed:3
The connection is complete, and the [StreamSocket](../windows.networking.sockets/streamsocket_streamsocket_1221375020.md) class can now be used to communicate with the peer.

### -field Canceled:4
The connection was stopped before it was completed.

### -field Failed:5
An error prevented a successful connection.


## -remarks

## -examples


[!code-js[FindPeers](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/default.js#SnippetFindPeers)]

[!code-csharp[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/BlankPage.xaml.cs#SnippetConnect_CS)]

[!code-vb[Connect_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/vbnet/BlankPage.xaml.vb#SnippetConnect_CS)]

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
