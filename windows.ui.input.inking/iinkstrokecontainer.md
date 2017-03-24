---
-api-id: T:Windows.UI.Input.Inking.IInkStrokeContainer
-api-type: winrt interface
-api-device-family-note: xbox
---

<!-- Interface syntax.
public interface IInkStrokeContainer : 
-->

# Windows.UI.Input.Inking.IInkStrokeContainer

## -description
Represents a manager for the collection of [InkStroke](inkstroke.md) objects rendered by the [InkPresenter](inkpresenter.md).

Modifications made to any of the ink strokes in the stroke container are immediately rendered to the drawing surface associated with the [InkPresenter](inkpresenter.md).

## -remarks
For ink recognition, use an [IInkRecognizerContainer](iinkrecognizercontainer.md) object.

## -examples

## -see-also
[Windows.UI.Input.Inking Interfaces](windows_ui_input_inking_interfaces.md), [InkStrokeContainer](inkstrokecontainer.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)