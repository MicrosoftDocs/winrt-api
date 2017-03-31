---
-api-id: T:Windows.UI.Input.Inking.InkManager
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkManager : Windows.UI.Input.Inking.IInkManager, Windows.UI.Input.Inking.IInkRecognizerContainer, Windows.UI.Input.Inking.IInkStrokeContainer
-->

# Windows.UI.Input.Inking.InkManager

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Provides properties and methods to manage the input, manipulation, and processing (including handwriting recognition) of one or more [InkStroke](inkstroke.md) objects.

## -remarks
If recognition is not required, use an [InkStrokeContainer](inkstrokecontainer.md) object instead of an [InkManager](inkmanager.md). Previous recognition results are still available through [GetRecognitionResults](inkstrokecontainer_getrecognitionresults.md).

If only recognition is required, and not storage, use an [InkRecognizerContainer](inkrecognizercontainer.md) instead of an [InkManager](inkmanager.md).

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
This example shows how to create an [InkManager](inkmanager.md) object.

```

var inkManager = new Windows.UI.Input.Inking.InkManager();

```

The following function demonstrates how to select all ink strokes on a [canvas](XREF:TODO:wwa.HTMLCanvasElement) that are part of the stroke collection of this [InkManager](inkmanager.md) (`inkManager`).

```

function selectAll()
{
    inkManager.getStrokes().forEach(
        function (stroke) 
        {
            stroke.selected = 1;
        }
    );
}

```

For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[Windows.UI.Input.Inking Classes](windows_ui_input_inking_classes.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)