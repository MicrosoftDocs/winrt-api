---
-api-id: M:Windows.Networking.XboxLive.XboxLiveEndpointPair.GetLocalSocketAddressBytes(System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void GetLocalSocketAddressBytes(System.Byte[] socketAddress)
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPair.GetLocalSocketAddressBytes

## -description

Gets the local endpoint's socket address information as an array of Byte. This method fills the specified byte buffer with the **SOCKADDR_STORAGE** address of the local device for use in subsequent Winsock operations leveraging the Xbox Live Multiplayer Networking API.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param socketAddress

The local socket address, as an array of Byte.

## -remarks

The port number value is zero if the **XboxLiveEndpointPairTemplate** allowed dynamically-assigned port numbers. In that case, your app must determine the local port number through other means.

The local address returned by this method is valid only on the calling device; to retrieve the local network identity for use by remote peers, create an **XboxLiveDeviceAddress** object for the local device, and send the remote peer a snapshot of that object.

## -examples

## -see-also
