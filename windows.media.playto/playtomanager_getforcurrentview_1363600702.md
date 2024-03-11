---
-api-id: M:Windows.Media.PlayTo.PlayToManager.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.PlayTo.PlayToManager GetForCurrentView()
-->

# Windows.Media.PlayTo.PlayToManager.GetForCurrentView

## -description
Gets the Play To manager for the current view.

## -returns
The Play To manager for the current view.

## -remarks

You can use the [PlayToManager](playtomanager.md) instance for the current view to establish the Play To contract for the app and customize which media Play To streams to a target device. You supply the media to be streamed during the [SourceRequested](playtomanager_sourcerequested.md) event by using the [SetSource](playtosourcerequest_setsource_1024738425.md) method.

## -examples

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)