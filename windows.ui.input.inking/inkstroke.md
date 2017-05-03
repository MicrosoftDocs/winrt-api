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
   <tr><td>var inkStrokes = [Windows.UI.Input.Inking.InkManager.getStrokes](inkmanager_getstrokes.md);

var inkStroke = inkStrokes[...];</td></tr>
   <tr><td>var inkStrokes = [Windows.UI.Input.Inking.inkRecognitionResult.getStrokes](inkrecognitionresult_getstrokes.md);

var inkStroke = inkStrokes[...];</td></tr>
   <tr><td>var inkStrokes = [Windows.UI.Input.Inking.inkStrokeContainer.getStrokes](inkstrokecontainer_getstrokes.md);

var inkStroke = inkStrokes[...];</td></tr>
</table>

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
Here we iterate through each stroke in an [InkManager](inkmanager.md) and process them for final rendering using Bézier curves.



[!code-js[RenderStrokes](../windows.ui.input.inking/code/CaptureInkData_JS/js/InkPage.js#SnippetRenderStrokes)]

## -see-also
[Windows.UI.Input.Inking Classes](windows_ui_input_inking_classes.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)
