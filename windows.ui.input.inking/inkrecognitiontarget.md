---
-api-id: T:Windows.UI.Input.Inking.InkRecognitionTarget
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkRecognitionTarget : int
-->

# InkRecognitionTarget

## -description
Indicates which strokes you want to include in handwriting recognition.

## -enum-fields
### -field All:0
All strokes in the stroke collection are passed to the recognizer.

### -field Selected:1
Selected ([Selected](inkstroke_selected.md)) strokes are passed to the recognizer.

### -field Recent:2
All strokes added after the last recognition pass ([Recognized](inkstroke_recognized.md) is false) are passed to the recognizer.This is useful in incremental recognition scenarios, such as direct tracking of ink input (no indirect controls are used to start recognition).


## -remarks

## -examples

## -see-also
[Windows.UI.Input.Inking Enumerations](windows_ui_input_inking_enumerations.md), [RecognizeAsync(InkRecognitionTarget)](inkmanager_recognizeasync_1262794931.md), [RecognizeAsync(InkStrokeContainer, InkRecognitionTarget)](inkmanager_recognizeasync_1912520635.md), [InkRecognizerContainer.RecognizeAsync](inkrecognizercontainer_recognizeasync.md), [IInkRecognizerContainer.RecognizeAsync](iinkrecognizercontainer_recognizeasync.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink stroke recognition](http://msdn.microsoft.com/library/c2f3f3ce-737f-4652-98b7-5278a462f9d3), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)