---
-api-id: T:Windows.UI.Input.Inking.InkRecognizer
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkRecognizer : Windows.UI.Input.Inking.IInkRecognizer
-->

# Windows.UI.Input.Inking.InkRecognizer

## -description
Manages all aspects of handwriting recognition.

## -remarks
<table>
   <tr><th>JavaScript (usage)</th></tr>
   <tr><td>var inkRecognizers = [Windows.UI.Input.Inking.InkManager.getRecognizers()](inkmanager_getrecognizers_2048895795.md);

var inkRecognizer = inkRecognizers[...];</td></tr>
   <tr><td>var inkRecognizers = [Windows.UI.Input.Inking.inkRecognizerContainer.getRecognizers()](inkrecognizercontainer_getrecognizers_2048895795.md);

var inkRecognizer = inkRecognizers[...];</td></tr>
</table>

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://msdn.microsoft.com/en-us/library/windows/apps/hh771042.aspx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also

[Ink stroke recognition](https://docs.microsoft.com/windows/uwp/input-and-devices/convert-ink-to-text), [Pen and stylus interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

