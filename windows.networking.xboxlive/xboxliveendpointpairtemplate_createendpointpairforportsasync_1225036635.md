---
-api-id: M:Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate.CreateEndpointPairForPortsAsync(Windows.Networking.XboxLive.XboxLiveDeviceAddress,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.XboxLive.XboxLiveEndpointPairCreationResult> CreateEndpointPairForPortsAsync(Windows.Networking.XboxLive.XboxLiveDeviceAddress deviceAddress, System.String initiatorPort, System.String acceptorPort)
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate.CreateEndpointPairForPortsAsync

## -description

Creates an endpoint pair between the local device and the specified remote device, specifying specific ports from the template's designated range of acceptable ports, with creation behavior **XboxLiveEndpointPairCreationBehaviors.None**.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param deviceAddress

The **XboxLiveDeviceAddress** of the remote device to be connected to.

### -param initiatorPort

The port to be used by the initiator, from the range of acceptable initiator ports specified in this template.

### -param acceptorPort

The port to be used by the acceptor, from the range of acceptable acceptor ports specified in this template.

## -returns

An asynchronous endpoint creation operation. When the operation completes, contains the results of the operation.

## -remarks

## -examples

## -see-also

[CreateEndpointPairForPortsAsync(XboxLiveDeviceAddress, String, String, XboxLiveEndpointPairCreationBehaviors)](xboxliveendpointpairtemplate_createendpointpairforportsasync_630320203.md)
