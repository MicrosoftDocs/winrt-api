---
-api-id: T:Windows.UI.Input.Inking.InkRecognitionResult
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkRecognitionResult : Windows.UI.Input.Inking.IInkRecognitionResult
-->

# Windows.UI.Input.Inking.InkRecognitionResult

## -description
Provides properties and methods to manage [InkStroke](inkstroke.md) handwriting recognition data.

Recognition results are produced for each word detected by an [InkRecognizer](inkrecognizer.md).

## -remarks
<table>
   <tr><th>JavaScript (usage)</th></tr>
   <tr><td>var inkRecognitionResults = [Windows.UI.Input.Inking.InkManager.getRecognitionResults()](inkmanager_getrecognitionresults_1073930605.md);

var inkRecognitionResult = inkRecognitionResults[...];</td></tr>
   <tr><td>var inkRecognitionResults =[Windows.UI.Input.Inking.InkStrokeContainer.getRecognitionResults()](inkstrokecontainer_getrecognitionresults_1073930605.md);

var inkRecognitionResult = inkRecognitionResults[...];</td></tr>
</table>

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also

[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

