---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.Size
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Size Size { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.Size

## -description
Gets or sets a value that indicates the dimensions of the pen tip ([PenTip](inkdrawingattributes_pentip.md)) used to draw an [InkStroke](inkstroke.md).

## -property-value
The [Width](../windows.foundation/size.md) and [Height](../windows.foundation/size.md) of the pen tip in [](https://msdn.microsoft.com/library/windows/desktop/ff684173.aspx). The default value for each is 2.The shape of the [PenTip](inkdrawingattributes_pentip.md) can be specified as a [Rectangle](pentipshape.md) or a [Circle](pentipshape.md).

## -remarks

## -examples
The following example includes a function that shows how to set the [Size](inkdrawingattributes_size.md) (`strokeSize`) of an [InkStroke](inkstroke.md) (`stroke`).

```

function shapeStroke(stroke, width)
{
    var att = stroke.drawingAttributes;
    var strokeSize = att.size;
    if (strokeSize.width !== width)
    {
        strokeSize.width = strokeSize.height = width;
        att.size = strokeSize;
        stroke.drawingAttributes = att;
        return true;
    }
    else
    {
        return false;
    }
}

```

For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)