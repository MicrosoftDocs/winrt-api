---
-api-id: T:Windows.Media.Capture.AppBroadcastStreamReader
-api-type: winrt class
---

<!-- Class syntax.
public class AppBroadcastStreamReader : Windows.Media.Capture.IAppBroadcastStreamReader
-->

# Windows.Media.Capture.AppBroadcastStreamReader

## -description
Provides methods and events for obtaining audio and video frames from an app broadcast stream.

> [!NOTE]
> This API requires the **appBroadcast** and **appBroadcastSettings** capability which is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime.

## -remarks
Get an instance of this class by accessing the [AppBroadcastBackgroundServiceStreamInfo.BroadcastStreamReader](appbroadcastbackgroundservicestreaminfo_broadcaststreamreader.md)

This API may throw an error if the background service has shut down due to idle timeout.

## -examples

## -see-also

## -capabilities
appBroadcast, appBroadcastSettings
