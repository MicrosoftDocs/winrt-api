---
-api-id: M:Windows.Media.Protection.PlayReady.NDClient.StartAsync(Windows.Foundation.Uri,System.UInt32,Windows.Media.Protection.PlayReady.INDCustomData,Windows.Media.Protection.PlayReady.INDLicenseFetchDescriptor)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Protection.PlayReady.INDStartResult> StartAsync(Windows.Foundation.Uri contentUrl, System.UInt32 startAsyncOptions, Windows.Media.Protection.PlayReady.INDCustomData registrationCustomData, Windows.Media.Protection.PlayReady.INDLicenseFetchDescriptor licenseFetchDescriptor)
-->

# Windows.Media.Protection.PlayReady.NDClient.StartAsync

## -description
Starts the registration, proximity detection, and license fetch procedures between a client receiver and a transmitter.

## -parameters
### -param contentUrl
The URL of the streamed content.

### -param startAsyncOptions
The asynchronous start options. See the [NDStartAsyncOptions](ndstartasyncoptions.md) enumeration for a detailed description of these options.

### -param registrationCustomData
The custom data type identifier that is used for registration with the transmitter.

### -param licenseFetchDescriptor
The descriptor used for license fetching.

## -returns
The result of the asynchronous start call.

## -remarks
This method sets up a PlayReady-ND session with a transmitter and notifies the download engine to begin streaming content as soon as it has established the session.

This method also notifies listeners that each task has completed by firing the appropriate [ClosedCaptionDataReceived](ndclient_closedcaptiondatareceived.md), [LicenseFetchCompleted](ndclient_licensefetchcompleted.md), [ProximityDetectionCompleted](ndclient_proximitydetectioncompleted.md), [RegistrationCompleted](ndclient_registrationcompleted.md), and [ReRegistrationNeeded](ndclient_reregistrationneeded.md) events.

## -examples

## -see-also
[INDStartResult](indstartresult.md)