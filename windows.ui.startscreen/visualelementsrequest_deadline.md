---
-api-id: P:Windows.UI.StartScreen.VisualElementsRequest.Deadline
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime Deadline { get; }
-->

# Windows.UI.StartScreen.VisualElementsRequest.Deadline

## -description
Gets the approximate time at which the [deferral](visualelementsrequest_getdeferral_254836512.md) will time-out.

## -property-value
The time at which the deferral will time out.

## -remarks
If the deferral time-out is reached and the developer has not called the [Complete](visualelementsrequestdeferral_complete_1807836922.md) method, the tile properties present before the event was fired are used— all properties set in the handler are ignored.

## -examples

## -see-also
