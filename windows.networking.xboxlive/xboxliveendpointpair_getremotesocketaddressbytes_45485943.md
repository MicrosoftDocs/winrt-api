---
-api-id: M:Windows.Networking.XboxLive.XboxLiveEndpointPair.GetRemoteSocketAddressBytes(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void GetRemoteSocketAddressBytes(System.Byte[] socketAddress)
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPair.GetRemoteSocketAddressBytes

## -description

Gets the remote endpoint's socket address information, as an array of Byte. This method fills the specified byte buffer with the **SOCKADDR_STORAGE** address of the remote device for use in subsequent Winsock operations leveraging the Xbox Live Multiplayer Networking API.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param socketAddress

The remote socket address, as an array of Byte.

## -remarks

The port number value will be zero if the **XboxLiveEndpointPairTemplate** allowed dynamically-assigned port numbers. In that case, your app will have to determine the remote port number through external means. 

The peer address returned by this property is valid only on the calling device. To retrieve a network identity that can be shared with other peers, use the corresponding **XboxLiveDeviceAddress** object, and send a snapshot of that object to peers.

## -examples

## -see-also
