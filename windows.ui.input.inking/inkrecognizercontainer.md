---
-api-id: T:Windows.UI.Input.Inking.InkRecognizerContainer
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkRecognizerContainer : Windows.UI.Input.Inking.IInkRecognizerContainer
-->

# Windows.UI.Input.Inking.InkRecognizerContainer

## -description
Provides properties and methods to manage one or more [InkRecognizer](inkrecognizer.md) objects used for handwriting recognition.

[InkRecognizerContainer](inkrecognizercontainer.md) is null if a recognition engine is not available on the system.

## -remarks
If recognition is not required, use an [InkStrokeContainer](inkstrokecontainer.md) object instead of an [InkManager](inkmanager.md). Previous recognition results are still available through [GetRecognitionResults](inkstrokecontainer_getrecognitionresults.md).

If only recognition is required, and not storage, use an [InkRecognizerContainer](inkrecognizercontainer.md) instead of an [InkManager](inkmanager.md).

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also
[Windows.UI.Input.Inking Classes](windows_ui_input_inking_classes.md), [Ink stroke recognition](http://msdn.microsoft.com/library/c2f3f3ce-737f-4652-98b7-5278a462f9d3), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)