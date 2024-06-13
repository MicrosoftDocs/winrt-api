---
-api-id: M:Windows.Media.PlayTo.PlayToSourceRequest.SetSource(Windows.Media.PlayTo.PlayToSource)
-api-type: winrt method
---

<!-- Method syntax
public void SetSource(Windows.Media.PlayTo.PlayToSource value)
-->

# Windows.Media.PlayTo.PlayToSourceRequest.SetSource

## -description
Sets the source element to connect to the Play To target.

## -parameters
### -param value
The source element to connect to the Play To target.

## -remarks
The [PlayToSourceRequest](playtosourcerequest.md) class represents a user request for source media to stream to a Play To target. You use the [SourceRequest](playtosourcerequestedeventargs_sourcerequest.md) property of the [PlayToSourceRequestedEventArgs](playtosourcerequestedeventargs.md) class to pass media from your application to Play To during the [SourceRequested](playtomanager_sourcerequested.md) event.

## -examples

## -see-also
[SourceRequested](playtomanager_sourcerequested.md), [Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)