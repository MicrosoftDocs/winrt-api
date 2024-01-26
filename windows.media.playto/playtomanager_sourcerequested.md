---
-api-id: E:Windows.Media.PlayTo.PlayToManager.SourceRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SourceRequested<Windows.Media.PlayTo.PlayToManager,  Windows.Media.PlayTo.PlayToSourceRequestedEventArgs>
-->

# Windows.Media.PlayTo.PlayToManager.SourceRequested

## -description
Occurs when a user requests media to stream to a Play To target device.

## -remarks
The **SourceRequested** event is fired when a user selects the **Devices** charm in a Play To– enabled application. You supply the audio, video, or image that Play To will stream to a target device during the **SourceRequested** event.

If you do not supply a media source within 200 milliseconds, the **SourceRequested** event will time out and the Devices charm will not display any Play To targets for your app.

The **SourceRequested** event occurs before the user selects the target device. After the user has selected the target device, the [SourceSelected](playtomanager_sourceselected.md) event is fired. If the user exits the **Devices** charm without selecting a target device, the [SourceSelected](playtomanager_sourceselected.md) event isn't fired.



## -examples

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)