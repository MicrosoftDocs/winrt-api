---
-api-id: M:Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate.CreateEndpointPairAsync(Windows.Networking.XboxLive.XboxLiveDeviceAddress,Windows.Networking.XboxLive.XboxLiveEndpointPairCreationBehaviors)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.XboxLive.XboxLiveEndpointPairCreationResult> CreateEndpointPairAsync(Windows.Networking.XboxLive.XboxLiveDeviceAddress deviceAddress, Windows.Networking.XboxLive.XboxLiveEndpointPairCreationBehaviors behaviors)
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate.CreateEndpointPairAsync

## -description

Creates an **XboxLiveEndpointPair** between the local device and a specified remote device, while specifying how the system should behave if an **XboxLiveEndpointPair** already exists for this template and remote device.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param deviceAddress

The **XboxLiveDeviceAddress** of the remote device for the endpoint pair.

### -param behaviors

A value that specifies how the system should behave when the requested endpoint pair has already been established. Your code can specify either that the existing **XboxLiveEndpointPair** be used, or that the system re-evaluate all potential network paths according to the template's quality requirements. If the same network path is selected after re-evaluation, then the same **XboxLiveEndpointPair** is returned. If a new path is found, then the old **XboxLiveEndpointPair** is destroyed, and a new one returned.

## -returns

An asynchronous endpoint creation operation. When the operation completes, contains the results of the operation.

## -remarks

The most common way to get an address for the *deviceAddress* parameter is to be sent one from the Xbox Live matchmaking service.

## -examples

## -see-also

[CreateEndpointPairAsync(XboxLiveDeviceAddress)](xboxliveendpointpairtemplate_createendpointpairasync_354642904.md)
