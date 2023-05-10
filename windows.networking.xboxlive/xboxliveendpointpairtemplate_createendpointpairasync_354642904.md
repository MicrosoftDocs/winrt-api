---
-api-id: M:Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate.CreateEndpointPairAsync(Windows.Networking.XboxLive.XboxLiveDeviceAddress)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.XboxLive.XboxLiveEndpointPairCreationResult> CreateEndpointPairAsync(Windows.Networking.XboxLive.XboxLiveDeviceAddress deviceAddress)
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate.CreateEndpointPairAsync

## -description

Creates an **XboxLiveEndpointPair** between the local device and a specified remote device, based on the current template, with creation behavior **XboxLiveEndpointPairCreationBehaviors.None**.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param deviceAddress

The XboxLiveDeviceAddress of the remote device to be connected to.

## -returns

An asynchronous endpoint creation operation. When the operation completes, contains the results of the operation.

## -remarks

The most common way to get an address for the *deviceAddress* parameter is to be sent one from the Xbox Live matchmaking service.

## -examples

## -see-also

[CreateEndpointPairAsync(XboxLiveDeviceAddress, XboxLiveEndpointPairCreationBehaviors)](xboxliveendpointpairtemplate_createendpointpairasync_235287572.md)
