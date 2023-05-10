---
-api-id: M:Windows.Networking.XboxLive.XboxLiveEndpointPair.FindEndpointPairByHostNamesAndPorts(Windows.Networking.HostName,System.String,Windows.Networking.HostName,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.XboxLive.XboxLiveEndpointPair FindEndpointPairByHostNamesAndPorts(Windows.Networking.HostName localHostName, System.String localPort, Windows.Networking.HostName remoteHostName, System.String remotePort)
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPair.FindEndpointPairByHostNamesAndPorts

## -description

Finds an existing **XboxLiveEndpointPair** instance, if one exists, associated with traffic from a first host and port to a second host and port.

Use this method to work backwards from incoming traffic to the **XboxLiveEndpointPair** that's associated with that traffic.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param localHostName

The **HostName** of the local end of the endpoint pair.

### -param localPort

The port number of the local end of the endpoint pair.

### -param remoteHostName

The **HostName** of the remote end of the endpoint pair.

### -param remotePort

The port number of the remote end of the endpoint pair.

## -returns

The **XboxLiveEndpointPair** that corresponds to the endpoints specified, or a null pointer if no such endpoint pair is found.

## -remarks

## -examples

## -see-also
