---
-api-id: P:Windows.UI.Input.Inking.InkManager.BoundingRect
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Rect BoundingRect { get; }
-->

# Windows.UI.Input.Inking.InkManager.BoundingRect

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Gets the bounding rectangle of the [InkStroke](inkstroke.md) collection that is managed by the [InkManager](inkmanager.md).

## -property-value
The bounding rectangle of the [InkStroke](inkstroke.md) collection.

## -remarks

## -examples
This example shows how to get the [BoundingRect](inkmanager_boundingrect.md) for the [InkStroke](inkstroke.md) collection of an [InkManager](inkmanager.md) object.

```
var rect = inkManager.boundingRect;
```

For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)