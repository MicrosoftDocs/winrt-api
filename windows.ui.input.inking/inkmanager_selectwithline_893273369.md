---
-api-id: M:Windows.UI.Input.Inking.InkManager.SelectWithLine(Windows.Foundation.Point,Windows.Foundation.Point)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Rect SelectWithLine(Windows.Foundation.Point from, Windows.Foundation.Point to)
-->

# Windows.UI.Input.Inking.InkManager.SelectWithLine

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Selects all strokes intersected by the new stroke.

> [!NOTE]
> The [Selected](inkstroke_selected.md) flag is reset for all other strokes in the collection.

## -parameters
### -param from
The start of the stroke.

### -param to
The end of the stroke.

## -returns
The bounding rectangle of the selected ink strokes.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)