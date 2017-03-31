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
   <tr><td>var inkRecognitionResults = [Windows.UI.Input.Inking.InkManager.getRecognitionResults()](inkmanager_getrecognitionresults.md);

var inkRecognitionResult = inkRecognitionResults[...];</td></tr>
   <tr><td>var inkRecognitionResults =[Windows.UI.Input.Inking.InkStrokeContainer.getRecognitionResults()](inkstrokecontainer_getrecognitionresults.md);

var inkRecognitionResult = inkRecognitionResults[...];</td></tr>
</table>

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also
[Windows.UI.Input.Inking Classes](windows_ui_input_inking_classes.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink stroke recognition](http://msdn.microsoft.com/library/c2f3f3ce-737f-4652-98b7-5278a462f9d3), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)