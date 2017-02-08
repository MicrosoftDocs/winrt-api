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

For ballpoint pen and pencil strokes, [MaxStrokeWidth](inktoolbarpenbutton_maxstrokewidth.md) specifies both the maximum [Height](../windows.foundation/size.md) and [Width](../windows.foundation/size.md) of a [Rectangle](../windows.ui.input.inking/pentipshape.md) pen tip.

For highlighter strokes, [MaxStrokeWidth](inktoolbarpenbutton_maxstrokewidth.md) specifies the maximum height of a [Rectangle](../windows.ui.input.inking/pentipshape.md) pen tip, while [MaxStrokeWidth](inktoolbarpenbutton_maxstrokewidth.md)/3 specifies the maximum width.

Custom pen stroke dimensions can be set as required.

## -property-value
The maximum possible width of the ink stroke. The default is 0.

## -remarks

## -examples

## -see-also
