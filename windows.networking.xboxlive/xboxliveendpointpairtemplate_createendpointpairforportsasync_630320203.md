---
-api-id: M:Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate.CreateEndpointPairForPortsAsync(Windows.Networking.XboxLive.XboxLiveDeviceAddress,System.String,System.String,Windows.Networking.XboxLive.XboxLiveEndpointPairCreationBehaviors)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.XboxLive.XboxLiveEndpointPairCreationResult> CreateEndpointPairForPortsAsync(Windows.Networking.XboxLive.XboxLiveDeviceAddress deviceAddress, System.String initiatorPort, System.String acceptorPort, Windows.Networking.XboxLive.XboxLiveEndpointPairCreationBehaviors behaviors)
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate.CreateEndpointPairForPortsAsync

## -description

Creates an endpoint pair between the local device and the specified remote device, specifying specific ports from the template's designated ranges of acceptable ports, and specifying how the system should behave if an **XboxLiveEndpointPair** already exists for this template, remote device, and port combination.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param deviceAddress

The **XboxLiveDeviceAddress** of the remote device to be connected to.

### -param initiatorPort

The port to be used by the initiator, from the range of acceptable initiator ports specified in this template.

### -param acceptorPort

The port to be used by the acceptor, from the range of acceptable acceptor ports specified in this template.

### -param behaviors

A value that specifies how the system should act when the requested endpoint pair has already been established. Your code can specify either that the existing **XboxLiveEndpointPair** be used, or that the system re-evaluate all potential network paths according to the template's quality requirements. If the same network path is selected after re-evaluation, then the same **XboxLiveEndpointPair** is returned. If a new path is found, then the old **XboxLiveEndpointPair** is destroyed, and a new one returned.

## -returns

An asynchronous endpoint creation operation. When the operation completes, contains the results of the operation.

## -remarks

## -examples

## -see-also

[CreateEndpointPairForPortsAsync(XboxLiveDeviceAddress, String, String)](xboxliveendpointpairtemplate_createendpointpairforportsasync_1225036635.md)
