---
-api-id: M:Windows.UI.Input.Inking.InkStroke.GetRenderingSegments
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Input.Inking.InkStrokeRenderingSegment> GetRenderingSegments()
-->

# Windows.UI.Input.Inking.InkStroke.GetRenderingSegments

## -description
Gets the rendering segments of the stroke.

> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), use [GetInkPoints](inkstroke_getinkpoints.md) (see remarks).

## -returns
The collection of [InkStrokeRenderingSegment](inkstrokerenderingsegment.md) objects.

## -remarks
If [FitToCurve](inkdrawingattributes_fittocurve.md) is set to true, this method returns an [InkStrokeRenderingSegment](inkstrokerenderingsegment.md) that approximates the Bezier curve of the stroke.

If [FitToCurve](inkdrawingattributes_fittocurve.md) is set to false, this method returns a collection of [InkStrokeRenderingSegment](inkstrokerenderingsegment.md) objects that represent the original raw pointer data as line segments.

For Universal Windows app using Extensible Application Markup Language (XAML), avoid changing the state of an ink stroke to retrieve the raw pointer data by using [GetInkPoints](inkstroke_getinkpoints.md) instead.

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)