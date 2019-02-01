---
-api-id: T:Windows.UI.Input.Inking.InkStroke
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkStroke : Windows.UI.Input.Inking.IInkStroke, Windows.UI.Input.Inking.IInkStroke2, Windows.UI.Input.Inking.IInkStroke3
-->

# Windows.UI.Input.Inking.InkStroke

## -description
A single ink stroke, including the Bézier curve parameters used for final rendering of the stroke.

## -remarks
<table>
   <tr><th>JavaScript (usage)</th></tr>
   <tr><td>var inkStrokes = [Windows.UI.Input.Inking.InkManager.getStrokes](inkmanager_getstrokes_993850152.md);

var inkStroke = inkStrokes[...];</td></tr>
   <tr><td>var inkStrokes = [Windows.UI.Input.Inking.inkRecognitionResult.getStrokes](inkrecognitionresult_getstrokes_993850152.md);

var inkStroke = inkStrokes[...];</td></tr>
   <tr><td>var inkStrokes = [Windows.UI.Input.Inking.inkStrokeContainer.getStrokes](inkstrokecontainer_getstrokes_993850152.md);

var inkStroke = inkStrokes[...];</td></tr>
</table>

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
Here we iterate through each stroke in an [InkManager](inkmanager.md) and process them for final rendering using Bézier curves.



[!code-js[RenderStrokes](../windows.ui.input.inking/code/CaptureInkData_JS/js/InkPage.js#SnippetRenderStrokes)]

## -see-also

[Pen and stylus interactions](https://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

