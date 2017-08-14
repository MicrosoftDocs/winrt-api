---
-api-id: T:Windows.Media.Capture.AppBroadcastStreamAudioHeader
-api-type: winrt class
---

<!-- Class syntax.
public class AppBroadcastStreamAudioHeader : Windows.Media.Capture.IAppBroadcastStreamAudioHeader
-->

# Windows.Media.Capture.AppBroadcastStreamAudioHeader

## -description
Provides metadata about a broadcast audio frame.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -remarks
Get an instance of this class by accessing the [AudioHeader](appbroadcaststreamaudioframe_audioheader.md) property of an [AppBroadcastStreamAudioFrame](appbroadcaststreamaudioframe.md) object obtained from a call to [AppBroadcastStreamReader.TryGetNextAudioFrame](appbroadcaststreamreader_trygetnextaudioframe.md).

## -examples

## -see-also

## -capabilities
appBroadcast, appBroadcastSettings
