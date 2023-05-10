---
-api-id: M:Windows.Networking.XboxLive.XboxLiveEndpointPair.FindEndpointPairBySocketAddressBytes(System.Byte[],System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.XboxLive.XboxLiveEndpointPair FindEndpointPairBySocketAddressBytes(System.Byte[] localSocketAddress, System.Byte[] remoteSocketAddress)
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPair.FindEndpointPairBySocketAddressBytes

## -description

Finds an existing **XboxLiveEndpointPair** instance, if one exists, associated with traffic between two given socket addresses, where the socket addresses are provided as arrays of Byte containing Winsock **SOCKADDR_STORAGE** or related structures.

Use this method to work backwards from incoming traffic to the **XboxLiveEndpointPair** associated with that traffic.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param localSocketAddress

Address of the local socket, as an array of Byte containing a Winsock **SOCKADDR_STORAGE** or related structure, for example, the array returned when you call **GetLocalSocketAddressBytes**.

### -param remoteSocketAddress

Address of the remote socket, as an array of Byte containing a Winsock **SOCKADDR_STORAGE** or related structure, for example, the array returned when you call **GetRemoteSocketAddressBytes**.

## -returns

The **XboxLiveEndpointPair** that corresponds to the endpoints specified, or a null pointer if no such endpoint pair is found.

## -remarks

## -examples

## -see-also
