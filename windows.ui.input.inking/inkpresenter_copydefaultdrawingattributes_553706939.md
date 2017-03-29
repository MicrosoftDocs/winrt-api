---
-api-id: M:Windows.UI.Input.Inking.InkPresenter.CopyDefaultDrawingAttributes
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Inking.InkDrawingAttributes CopyDefaultDrawingAttributes()
-->

# Windows.UI.Input.Inking.InkPresenter.CopyDefaultDrawingAttributes

## -description
Retrieves the [InkDrawingAttributes](inkdrawingattributes.md) used by the [InkPresenter](inkpresenter.md) when rendering a new [InkStroke](inkstroke.md) on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

This method is used in conjunction with [UpdateDefaultDrawingAttributes](inkpresenter_updatedefaultdrawingattributes.md) to set drawing attributes at run time.

## -returns
The drawing attributes applied to a new ink stroke.

## -remarks
This method does not return the attributes of existing, or currently drawing, ink strokes.

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)