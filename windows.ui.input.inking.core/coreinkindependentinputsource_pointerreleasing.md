---
-api-id: E:Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource.PointerReleasing
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PointerReleasing<Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource,  Windows.UI.Core.PointerEventArgs>
-->

# Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource.PointerReleasing

## -description
Can occur as a pointer associated with a [PointerPressing](coreinkindependentinputsource_pointerpressing.md) event is lifted, or released, while within the hit test, or bounding, area of the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) associated with the [InkPresenter](coreinkindependentinputsource_inkpresenter.md) object.

[PointerReleasing](coreinkindependentinputsource_pointerreleasing.md) is not guaranteed to occur in concert with [PointerPressing](coreinkindependentinputsource_pointerpressing.md), as [PointerLost](coreinkindependentinputsource_pointerlost.md) or [PointerExiting](coreinkindependentinputsource_pointerexiting.md) might occur instead. You should handle all events that can conclude [PointerPressing](coreinkindependentinputsource_pointerpressing.md).

Some reasons why [PointerReleasing](coreinkindependentinputsource_pointerreleasing.md) might not occur include: 
+ Differences in how specific hardware handles input
+ A programmatic pointer capture from a different pointer
+ User actions that change the relationship of the display area, such as changing resolution or monitor settings
+ Input interactions such as a stylus touching the same surface as a previous touch action


## -remarks

## -examples

## -see-also
[Pen and stylus interactions](https://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620314)
