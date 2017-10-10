---
-api-id: M:Windows.Networking.Proximity.PeerFinder.Start(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Start(System.String peerMessage)
-->

# Windows.Networking.Proximity.PeerFinder.Start

## -description
Makes an app discoverable to remote peers.

## -parameters
### -param peerMessage
The message to deliver to the proximate device.

## -remarks
You can call the **Start** method to begin the process of finding a peer app and to make your app discoverable to remote peers that call the [FindAllPeersAsync](peerfinder_findallpeersasync.md) method. A peer is a device that has an app running in the foreground with a matching AppId. A peer can also have a matching Browse Id that's specified as an alternate identity. For more information, see [AlternateIdentities](peerfinder_alternateidentities.md).

You can use this overload of the [Start](peerfinder_start_119778276.md) method to send a message to a peer app that will be passed as an app activation argument.

You can connect to only one peer at a time if your app is in the peer or client role. If your app is in the host role, you can connect up to 5 clients at a time.

When an app is activated by tapping a nearby device, the activation parameters indicate whether the [PeerFinder](peerfinder.md) should be started or if the app was launched with activation arguments. The format of the activation parameters is *"Windows.Networking.Proximity.PeerFinder:StreamSocket Role=&lt;Host|Client&gt;"*. For more information, see the "Activating apps using Proximity" section of [Supporting Proximity and Tapping.](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b)



> [!IMPORTANT]
> Always set the [DisplayName](peerfinder_displayname.md) property to a unique value for your app before you call the [Start](peerfinder_start.md) method.

### Windows Phone 8

Wi-Fi Direct is not supported on Windows Phone 8. 

## -examples

## -see-also
[AlternateIdentities](peerfinder_alternateidentities.md), [Start](peerfinder_start_1587696324.md), [Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
