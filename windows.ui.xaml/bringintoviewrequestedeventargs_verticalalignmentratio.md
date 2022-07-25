---
-api-id: P:Windows.UI.Xaml.BringIntoViewRequestedEventArgs.VerticalAlignmentRatio
-api-type: winrt property
---

<!-- Property syntax.
public double VerticalAlignmentRatio { get; }
-->

# Windows.UI.Xaml.BringIntoViewRequestedEventArgs.VerticalAlignmentRatio

## -description
Gets the requested vertical alignment ratio which controls the alignment of the horizontal axis of the TargetRect with respect to the horizontal axis of the viewport. 



## -property-value

The requested vertical alignment ratio between 0.0 and 1.0, or NaN. See Remarks.

## -remarks
A value of NaN indicates that scrolling controls should do the minimum necessary to bring the element fully into view aligned to the nearest edge of the viewport.

> [!NOTE]
> Do not use the `==` operator to test for NaN.
>
> In C#, use [Double.IsNaN()](/dotnet/api/system.double.isnan?view=dotnet-uwp-10.0&preserve-view=true) to test for NaN.
>
> In C++, use [isnan()](/cpp/c-runtime-library/reference/isnan-isnan-isnanf) to test for NaN.

If the value is not NaN, then the range of possible value is clamped from 0.0 to 1.0 with 0.0 representing the top horizontal edge and 1.0 representing the bottom horizontal edge.

A value of 0.0 indicates the TargetRect should be top-aligned in the viewport. A value of 1.0 indicates it should be bottom-aligned. A value of 0.5 indicates the TargetRect should be vertically centered in the viewport.

All scrolling controls that participate in bringing an element into view are expected to honor the alignment request to the extent possible. This value cannot be modified by event handlers as the event bubbles. If a control cannot fully satisfy the request then it should not alter the requested [VerticalOffset](bringintoviewrequestedeventargs_verticaloffset.md) property as it bubbles up.

## -see-also

## -examples

