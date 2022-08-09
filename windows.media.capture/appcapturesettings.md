---
-api-id: T:Windows.Media.Capture.AppCaptureSettings
-api-type: winrt class
---

<!-- Class syntax.
public class AppCaptureSettings : Windows.Media.Capture.IAppCaptureSettings, Windows.Media.Capture.IAppCaptureSettings2, Windows.Media.Capture.IAppCaptureSettings3, Windows.Media.Capture.IAppCaptureSettings4, Windows.Media.Capture.IAppCaptureSettings5
-->

# Windows.Media.Capture.AppCaptureSettings

## -description
Represents app capture settings.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -remarks
This API may throw an error if the background service has shut down due to idle timeout.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | IsMicrophoneCaptureEnabled |
| 1607 | 14393 | IsMicrophoneCaptureEnabledByDefault |
| 1607 | 14393 | MicrophoneGain |
| 1607 | 14393 | SystemAudioGain |
| 1607 | 14393 | VideoEncodingFrameRateMode |
| 1703 | 15063 | IsCursorImageCaptureEnabled |
| 1703 | 15063 | IsEchoCancellationEnabled |

## -examples

## -see-also
[Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true)

## -capabilities
appCaptureSettings
