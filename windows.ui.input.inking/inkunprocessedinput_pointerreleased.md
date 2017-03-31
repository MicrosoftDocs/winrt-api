---
-api-id: E:Windows.UI.Input.Inking.InkUnprocessedInput.PointerReleased
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PointerReleased<Windows.UI.Input.Inking.InkUnprocessedInput,  Windows.UI.Core.PointerEventArgs>
-->

# Windows.UI.Input.Inking.InkUnprocessedInput.PointerReleased

## -description
Can occur when a pointer associated with a [PointerPressed](inkunprocessedinput_pointerpressed.md) event is lifted, or released, while within the hit test, or bounding, area of an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

[PointerReleased](inkunprocessedinput_pointerreleased.md) is not guaranteed to occur in concert with [PointerPressed](inkunprocessedinput_pointerpressed.md), as [PointerLost](inkunprocessedinput_pointerlost.md) or [PointerExited](inkunprocessedinput_pointerexited.md) might occur instead. You should handle all events that can conclude [PointerPressed](inkunprocessedinput_pointerpressed.md).

Some reasons why [PointerReleased](inkunprocessedinput_pointerreleased.md) might not occur include: 
+ Differences in how specific hardware handles input
+ A programmatic pointer capture from a different pointer
+ User actions that change the relationship of the display area, such as changing resolution or monitor settings
+ Input interactions such as a stylus touching the same surface as a previous touch action


## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)