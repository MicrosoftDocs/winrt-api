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
[InkPresenter.InkHighContrastAdjustment](inkpresenter_highcontrastadjustment.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

