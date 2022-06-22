---
-api-id: P:Windows.UI.Xaml.BringIntoViewRequestedEventArgs.HorizontalOffset
-api-type: winrt property
---

<!-- Property syntax.
public double HorizontalOffset { get;  set; }
-->

# Windows.UI.Xaml.BringIntoViewRequestedEventArgs.HorizontalOffset

## -description
Gets or sets the horizontal distance to add to the viewport-relative position of the TargetRect after satisfying the requested [HorizontalAlignmentRatio](bringintoviewrequestedeventargs_horizontalalignmentratio.md).



## -property-value

The horizontal distance to add to the viewport-relative position of the TargetRect after satisfying the requested [HorizontalAlignmentRatio](bringintoviewrequestedeventargs_horizontalalignmentratio.md).

## -remarks
This value can be modified by event handlers as the event bubbles. A scrolling control that partially or fully satisfies the request will adjust the requested HorizontalOffset to reflect the remaining amount that it could not satisfy.

## -see-also

## -examples

