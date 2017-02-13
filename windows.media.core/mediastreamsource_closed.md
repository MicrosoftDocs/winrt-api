---
-api-id: E:Windows.Media.Core.MediaStreamSource.Closed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Closed<Windows.Media.Core.MediaStreamSource,  Windows.Media.Core.MediaStreamSourceClosedEventArgs>
-->

# Windows.Media.Core.MediaStreamSource.Closed

## -description
Occurs when the [MediaStreamSource](mediastreamsource.md) is shutting down.

## -remarks
If the [MediaStreamSource](mediastreamsource.md) is shutting down due to an error, the [Reason](mediastreamsourceclosedrequest_reason.md) property on the [MediaStreamSourceClosedRequest](mediastreamsourceclosedrequest.md) object, which can be obtained from [MediaStreamSourceClosedEventArgs](mediastreamsourceclosedeventargs.md), provides information about the nature of the error.

Upon receiving this event, the application should remove all of its event handlers from the [MediaStreamSource](mediastreamsource.md) object, and refrain from further use of this instance of the [MediaStreamSource](mediastreamsource.md) object.

Applications are not required to have a handler for this event.

## -examples

## -see-also
[MediaStreamSourceClosedEventArgs](mediastreamsourceclosedeventargs.md)