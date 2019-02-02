---
-api-id: T:Windows.Networking.Proximity.PeerRole
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.Proximity.PeerRole : int
-->

# PeerRole

## -description
Describes the role of the peer app when connected to multiple peers.

## -enum-fields
### -field Peer:0
The app is part of a two-peer connection.

### -field Host:1
The app is the host peer app in a multi-peer connection.

### -field Client:2
The app is a client peer app in a multi-peer connection.


## -remarks
The [Role](peerfinder_role.md) property is used in multi-peer app connections to identify whether the peer app is the **Host** or **Client**, or if the peer app is participating in a two-peer connection as a **Peer**. For multi-peer app connections, you must set the [Role](peerfinder_role.md) property before calling the [Start](peerfinder_start_119778276.md) method. If the Role property is not set, the default is **Peer**.

In a multi-peer app scenario, the Role identifies the capability of the apps to connect. A **Host** app can connect to up to four **Client** apps. **Host** apps can only discover apps that advertise as **Client** apps. **Client** apps can only discover apps that advertise as **Host** apps. The **Peer** role identifies a two-app scenario. Therefore, **Peer** apps can only discover other **Peer** apps. The same rules apply for peer apps connected using a tap gesture. For example, apps advertising as **Host** apps can only tap to connect with apps advertising as **Client** apps.

## -examples


[!code-csharp[PeerRole_CS](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/csharp/PeerRole.xaml.cs#SnippetPeerRole_CS)]

[!code-js[PeerRole](../windows.networking.proximity/code/Proximity_FindAllPeersAsync1/js/peerrole.js#SnippetPeerRole)]

## -see-also
[PeerFinder](peerfinder.md), [Proximity and Tapping (JavaScript)](https://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](https://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](https://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
