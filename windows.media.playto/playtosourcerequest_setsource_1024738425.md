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
[SourceRequested](playtomanager_sourcerequested.md), [Play To sample](http://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](http://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](http://go.microsoft.com/fwlink/p/?linkid=245168)