---
-api-id: M:Windows.UI.Input.GestureRecognizer.ProcessMoveEvents(Windows.Foundation.Collections.IVector{Windows.UI.Input.PointerPoint})
-api-type: winrt method
---

<!-- Method syntax
public void ProcessMoveEvents(Windows.Foundation.Collections.IVector<Windows.UI.Input.PointerPoint> value)
-->

# Windows.UI.Input.GestureRecognizer.ProcessMoveEvents

## -description
Processes pointer input and raises the [GestureRecognizer](gesturerecognizer.md) events appropriate to a pointer move action for the gestures and manipulations specified by the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

## -parameters
### -param value
The pointer location history based on the [PointerId](pointerpoint_pointerid.md) . If no history is available then the value is the current location of the input pointer.

## -remarks

## -examples

## -see-also
[Input and interactions](/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](/samples/browse/), [Input: Ink sample](/samples/browse/), [Input: Manipulations and gestures (JavaScript) sample](/samples/browse/), [Input: Simplified ink  sample](/samples/browse/), [Input: Windows 8 gestures sample](/samples/browse/), [Input: XAML user input events sample](/samples/browse/), [XAML scrolling, panning, and zooming sample](/samples/browse/), [DirectX touch input sample](/samples/browse/), [Input: Manipulations and gestures (C++) sample](/samples/browse/), [Input: Touch hit testing sample](/samples/browse/), [Input source identification sample](/samples/browse/), [Touch injection sample](/samples/browse/), [Win32 touch hit-testing sample](/samples/browse/)