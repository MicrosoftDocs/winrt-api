---
-api-id: P:Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxStrokeWidth
-api-type: winrt property
---

<!-- Property syntax
public double MaxStrokeWidth { get;  set; }
-->

# Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxStrokeWidth

## -description
Gets or sets the maximum possible [Size](../windows.ui.input.inking/inkdrawingattributes_size.md) of an ink stroke.

For ballpoint pen and pencil strokes, MaxStrokeWidth specifies both the maximum [Height](../windows.foundation/size.md) and [Width](../windows.foundation/size.md) of a [Rectangle](../windows.ui.input.inking/pentipshape.md) pen tip.

For highlighter strokes, MaxStrokeWidth specifies the maximum height of a [Rectangle](../windows.ui.input.inking/pentipshape.md) pen tip, while MaxStrokeWidth/3 specifies the maximum width.

Custom pen stroke dimensions can be set as required.

## -property-value
The maximum possible width of the ink stroke. The default is 0.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [MaxStrokeWidthProperty](inktoolbarpenbutton_maxstrokewidthproperty.md), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)

