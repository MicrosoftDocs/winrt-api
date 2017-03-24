---
-api-id: M:Windows.UI.Input.Inking.InkManager.AddStroke(Windows.UI.Input.Inking.InkStroke)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AddStroke(Windows.UI.Input.Inking.InkStroke stroke)
-->

# Windows.UI.Input.Inking.InkManager.AddStroke

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Adds one or more [InkStroke](inkstroke.md) objects to the collection managed by the [InkManager](inkmanager.md).

## -parameters
### -param stroke
The ink stroke to be added.

*stroke* must be created by using the [Clone](inkstroke_clone.md) method, or through a call to [EndStroke](inkstrokebuilder_endstroke.md) or [ProcessPointerUp](inkmanager_processpointerup.md). Empty or existing strokes are not valid.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)