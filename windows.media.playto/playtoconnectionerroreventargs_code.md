---
-api-id: P:Windows.Media.PlayTo.PlayToConnectionErrorEventArgs.Code
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.PlayTo.PlayToConnectionError Code { get; }
-->

# Windows.Media.PlayTo.PlayToConnectionErrorEventArgs.Code

## -description
Gets the error code for a Play To connection error.

## -property-value
The error code for a Play To connection error.

## -remarks
In Windows 8UWP apps, Code is always set to **DeviceError**.

In Windows 8.1UWP apps, Code is set to either **DeviceError** or **ProtectedPlaybackFailed**. This enables the app to determine if the failure is related to the media-protection status of the content. The app can continue playing the next item in the playlist or to stop. Apps can also use this new Code value to remove all protected music from the playlist.

## -examples

## -see-also
[PlayToConnection.Error event](playtoconnection_error.md), [Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)