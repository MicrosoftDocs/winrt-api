---
-api-id: P:Windows.UI.Xaml.BringIntoViewRequestedEventArgs.VerticalOffset
-api-type: winrt property
---

<!-- Property syntax.
public double VerticalOffset { get;  set; }
-->

# Windows.UI.Xaml.BringIntoViewRequestedEventArgs.VerticalOffset

## -description
Gets or sets the vertical distance to add to the viewport-relative position of the TargetRect after satisfying the requested [VerticalAlignmentRatio](bringintoviewrequestedeventargs_verticalalignmentratio.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.BringIntoViewRequestedEventArgs.VerticalOffset](/windows/winui/api/microsoft.ui.xaml.bringintoviewrequestedeventargs.verticaloffset) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The vertical distance to add to the viewport-relative position of the TargetRect after satisfying the requested [VerticalAlignmentRatio](bringintoviewrequestedeventargs_verticalalignmentratio.md).

## -remarks
This value can be modified by event handlers as the event bubbles. A scrolling control that partially or fully satisfies the request will adjust the requested VerticalOffset to reflect the remaining amount that it could not satisfy.

## -see-also

## -examples

