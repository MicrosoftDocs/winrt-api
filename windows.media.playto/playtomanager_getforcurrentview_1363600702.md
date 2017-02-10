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
<!--{annotation author="v-shawja" time="1/27/2012 10:49:35 AM"}In the first sentence of the following paragraph, note that MSTP generally prefers "destination" over "target". Please make that change if it would be accurate. Or "target" can simply be deleted if it's unnecessary.-->
You can use the [PlayToManager](playtomanager.md) instance for the current view to establish the Play To contract for the app and customize which media Play To streams to a target device. You supply the media to be streamed during the [SourceRequested](playtomanager_sourcerequested.md) event by using the [SetSource](playtosourcerequest_setsource.md) method.

## -examples

## -see-also
[Play To sample](http://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](http://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](http://go.microsoft.com/fwlink/p/?linkid=245168)