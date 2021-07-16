---
-api-id: T:Windows.Media.Capture.AppBroadcastPlugInState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.AppBroadcastPlugInState : int
-->

# AppBroadcastPlugInState

## -description
Specifies the current state of the broadcast background task.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -enum-fields
### -field Unknown:0
The current state is unknown.

### -field Initialized:1
The broadcast background task is initialized.

### -field MicrosoftSignInRequired:2
The current user needs to be authenticated with the Microsoft service.

### -field OAuthSignInRequired:3
The current user needs to be authenticated with the broadcast provider service.

### -field ProviderSignInRequired:4
The broadcast background task needs to authenticate the current user with the broadcast provider service.

### -field InBandwidthTest:5
The broadcast background task is in the process of testing the bandwidth of the device's connection to the broadcasting service provider. Once this test is complete, the system will set the [AppBroadcastBackgroundServiceStreamInfo.BandwidthTestBitrate](appbroadcastbackgroundservicestreaminfo_bandwidthtestbitrate.md) property to indicate the result of the bandwidth test.

### -field ReadyToBroadcast:6
The broadcast background task is ready to broadcast.



## -remarks

## -examples

## -see-also

## -capabilities
appBroadcast, appBroadcastSettings
