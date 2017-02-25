---
-api-id: T:Windows.UI.Input.Inking.InkHighContrastAdjustment
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkHighContrastAdjustment : int
-->

# InkHighContrastAdjustment

## -description
Specifies how the [InkPresenter](inkpresenter.md) object handles input (standard and modified) from the associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control when system is in high contrast mode.

## -enum-fields
### -field UseSystemColorsWhenNecessary:0
For standard strokes, use selected color if contrast is sufficient against the background. Otherwise, use system color.

For highlighter strokes ([InkDrawingAttributes.DrawAsHighlighter](inkdrawingattributes_drawashighlighter.md)), use selected color if contrast is sufficient against the background. Otherwise, use system color.

### -field UseSystemColors:1
For standard strokes, use system color.

For highlighter strokes ([InkDrawingAttributes.DrawAsHighlighter](inkdrawingattributes_drawashighlighter.md)), use system highlighter color.

### -field UseOriginalColors:2
For standard strokes, use the selected color.

For highlighter strokes ([InkDrawingAttributes.DrawAsHighlighter](inkdrawingattributes_drawashighlighter.md)), use the selected color.


## -remarks

## -examples

## -see-also
- [InkPresenter.InkHighContrastAdjustment](inkpresenter_highcontrastadjustment.md)