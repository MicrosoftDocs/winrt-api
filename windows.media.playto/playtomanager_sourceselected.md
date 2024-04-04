---
-api-id: E:Windows.Media.PlayTo.PlayToManager.SourceSelected
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SourceSelected<Windows.Media.PlayTo.PlayToManager,  Windows.Media.PlayTo.PlayToSourceSelectedEventArgs>
-->

# Windows.Media.PlayTo.PlayToManager.SourceSelected

## -description
Occurs when a Play To source element has been selected.

## -remarks

In a Play To– enabled app, the user selects the **Devices** charm (or the Play To UI) to stream audio, video, or images from the app to a target device. The SourceSelected event is fired after the user has selected a target device. If the user exits the **Devices** charm or the Play To UI without selecting a target device, the SourceSelected event isn't fired.

## -examples

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)