---
-api-id: T:Windows.UI.Input.Inking.InkStrokeContainer
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkStrokeContainer : Windows.UI.Input.Inking.IInkStrokeContainer, Windows.UI.Input.Inking.IInkStrokeContainer2, Windows.UI.Input.Inking.IInkStrokeContainer3
-->

# Windows.UI.Input.Inking.InkStrokeContainer

## -description
Provides properties and methods to store and manage the collection of [InkStroke](inkstroke.md) objects rendered by the [InkPresenter](inkpresenter.md).

Modifications made to any of the ink strokes in the stroke container are immediately rendered to the drawing surface associated with the [InkPresenter](inkpresenter.md).

## -remarks
For ink recognition, use an [InkRecognizerContainer](inkrecognizercontainer.md) object.

The [StrokesCollected](inkpresenter_strokescollected.md) event is fired when ink strokes are processed ("wet" to "dry") on the UI thread.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also
[Windows.UI.Input.Inking Classes](windows_ui_input_inking_classes.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)