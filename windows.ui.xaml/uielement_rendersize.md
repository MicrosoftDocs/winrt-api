---
-api-id: P:Windows.UI.Xaml.UIElement.RenderSize
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Size RenderSize { get; }
-->

# Windows.UI.Xaml.UIElement.RenderSize

## -description
Gets the final render size of a [UIElement](uielement.md). Use is not recommended, see Remarks.



## -property-value
The rendered size for this object. There is no default value.

## -remarks
RenderSize is not the property to use to obtain size information about a UI element for most scenarios, because in the current implementation it doesn't have a safe technique for knowing when the value is current. For general UI purposes, use [ActualHeight](frameworkelement_actualheight.md) and [ActualWidth](frameworkelement_actualwidth.md) instead, and do so only at points in object lifetime where object layout is complete. Examples of safe timing for checking [ActualHeight](frameworkelement_actualheight.md) or [ActualWidth](frameworkelement_actualwidth.md) are user input events or the [Loaded](frameworkelement_loaded.md) event. Or you can handle [SizeChanged](frameworkelement_sizechanged.md), which has updated size information in its event data. For layout method override purposes (for example [MeasureOverride](frameworkelement_measureoverride_1586581644.md)), use [DesiredSize](uielement_desiredsize.md).

## -examples

## -see-also
