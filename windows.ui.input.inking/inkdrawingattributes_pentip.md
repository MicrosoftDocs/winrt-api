---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.PenTip
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.PenTipShape PenTip { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.PenTip

## -description
Gets or sets a value that indicates the shape of the pen tip when you draw an [InkStroke](inkstroke.md).

## -property-value
The shape of the pen/stylus tip. The default is [Circle](pentipshape.md).
<!--{annotation author="kbridge" time="12/6/2011 6:14:40 PM"}default?-->

## -remarks
Support various calligraphic effects using the [PenTipShape](pentipshape.md) property with [PenTip](inkdrawingattributes_pentip.md).

## -examples
The following example demonstrates how to set the [PenTip](inkdrawingattributes_pentip.md) attribute for all strokes managed by an [InkManager](inkmanager.md) object (`inkManager`).

```

var inkManager = new Windows.UI.Input.Inking.InkManager();
var drawingAttributes = new Windows.UI.Input.Inking.InkDrawingAttributes();
drawingAttributes.penTip = Windows.UI.Input.Inking.PenTipShape.rectangle;
inkManager.setDefaultDrawingAttributes(drawingAttributes);

```


<!--{annotation author="kbridge" time="1/3/2012 4:26:35 PM"}Snippet is hard coded. Need snippet host.-->
For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[PenTipTransform](inkdrawingattributes_pentiptransform.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)