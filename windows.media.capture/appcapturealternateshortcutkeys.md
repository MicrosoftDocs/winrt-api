---
-api-id: T:Windows.Media.Capture.AppCaptureAlternateShortcutKeys
-api-type: winrt class
---

<!-- Class syntax.
public class AppCaptureAlternateShortcutKeys : Windows.Media.Capture.IAppCaptureAlternateShortcutKeys, Windows.Media.Capture.IAppCaptureAlternateShortcutKeys2, Windows.Media.Capture.IAppCaptureAlternateShortcutKeys3
-->

# Windows.Media.Capture.AppCaptureAlternateShortcutKeys

## -description
Defines alternate shortcut keys for app capture.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -remarks
Get an instance of this class with the [AlternateShortcutKeys](appcapturesettings_alternateshortcutkeys.md) property.

This API may throw an error if the background service has shut down due to idle timeout.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | ToggleMicrophoneCaptureKey |
| 1511 | 10586 | ToggleMicrophoneCaptureKeyModifiers |
| 1607 | 14393 | ToggleBroadcastKey |
| 1607 | 14393 | ToggleBroadcastKeyModifiers |
| 1607 | 14393 | ToggleCameraCaptureKey |
| 1607 | 14393 | ToggleCameraCaptureKeyModifiers |

## -examples

## -see-also
