---
-api-id: M:Windows.UI.Input.Inking.InkManager.PasteFromClipboard(Windows.Foundation.Point)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Rect PasteFromClipboard(Windows.Foundation.Point position)
-->

# Windows.UI.Input.Inking.InkManager.PasteFromClipboard

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Adds the [InkStroke](inkstroke.md) content from the clipboard to the [InkStroke](inkstroke.md) collection that is managed by the [InkManager](inkmanager.md) and renders the new strokes..

## -parameters
### -param position
The screen coordinates for the upper-left corner of the bounding rectangle of the clipboard content.

## -returns
The invalidated bounding rectangle of the [InkStroke](inkstroke.md) collection.

## -remarks
The content of the clipboard must be in Ink Serialized Format (ISF) format.

The [InkStroke](inkstroke.md) content from the clipboard is selected. Any existing selection is discarded.

## -examples
Here we show how to test whether the content on the clipboard can be added to an [InkStroke](inkstroke.md) collection before calling the [PasteFromClipboard](inkmanager_pastefromclipboard.md) method.

This example specifies the insertion point for the bounding rectangle at (100, 60), but this can be customized as required.

```

function paste(evt)
{
    var insertionPoint = {x: 100, y: 60};
    var canPaste = inkManager.canPasteFromClipboard();
    if (canPaste)
    {
        inkManager.pasteFromClipboard(insertionPoint);
        sdkSample.displayStatus("Pasted");
        renderAllStrokes();
    }
    else
    {
        sdkSample.displayStatus("Cannot paste");
    }
}
```

For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)