---
-api-id: T:Windows.Media.Capture.AppBroadcastStreamVideoHeader
-api-type: winrt class
---

<!-- Class syntax.
public class AppBroadcastStreamVideoHeader : Windows.Media.Capture.IAppBroadcastStreamVideoHeader
-->

# Windows.Media.Capture.AppBroadcastStreamVideoHeader

## -description
Provides metadata about a broadcast video frame.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -remarks
Get an instance of this class by accessing the [VideoHeader](appbroadcaststreamvideoframe_videoheader.md) property of an [AppBroadcastStreamVideoFrame](appbroadcaststreamvideoframe.md) object obtained from a call to [AppBroadcastStreamReader.TryGetNextVideoFrame](appbroadcaststreamreader_trygetnextvideoframe.md).

## -examples

## -see-also

## -capabilities
appBroadcast, appBroadcastSettings
