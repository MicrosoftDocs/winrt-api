---
-api-id: T:Windows.UI.Input.Inking.InkPresenterProtractor
-api-type: winrt class
---

<!-- Class syntax.
public class InkPresenterProtractor : Windows.UI.Input.Inking.IInkPresenterProtractor, Windows.UI.Input.Inking.IInkPresenterStencil
-->

# Windows.UI.Input.Inking.InkPresenterProtractor

## -description
Represents a visual stencil, in the form of a protractor for drawing arcs and curves, displayed as a semi-transparent overlay on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

The stencil transforms how an ink stroke is rendered:

- It snaps the ink stroke to the stencil edge if the pen tip is within a distance threshold (gutter).
- It acts as a mask and prevents the drawing of an ink stroke within the area obscured by the stencil.


The [InkPresenterRuler](inkpresenterruler.md) can be manipulated both programmatically and by the user. It also scales and translates with the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

## -remarks
The opacity of the stencil is set at 75% when static, and 50% during manipulation.

## -examples

## -see-also

[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

