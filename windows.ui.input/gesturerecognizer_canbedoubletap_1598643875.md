---
-api-id: M:Windows.UI.Input.GestureRecognizer.CanBeDoubleTap(Windows.UI.Input.PointerPoint)
-api-type: winrt method
---

<!-- Method syntax
public bool CanBeDoubleTap(Windows.UI.Input.PointerPoint value)
-->

# Windows.UI.Input.GestureRecognizer.CanBeDoubleTap

## -description
Identifies whether a tap can still be interpreted as the second tap of a double tap gesture.

## -parameters
### -param value
The last input pointer.

## -returns
True if a UI element supports the double tap gesture and the time threshold to complete the gesture has not been crossed; otherwise false.

## -remarks
This method supports [GestureRecognizer](gesturerecognizer.md) object pool management, where [GestureRecognizer](gesturerecognizer.md) objects are dynamically assigned to a set of UI elements.

Specifically, [GestureRecognizer](gesturerecognizer.md) objects can be recycled for UI elements that do not support or can no longer process a double tap gesture. For example, if CanBeDoubleTap returns true for the most recent [PointerPoint](pointerpoint.md), it’s not safe to recycle the [GestureRecognizer](gesturerecognizer.md) because a double tap is still a viable interaction based on subsequent input. If CanBeDoubleTap returns false, the [GestureRecognizer](gesturerecognizer.md) can be safely recycled.

This method is not required if [GestureRecognizer](gesturerecognizer.md) object pool management is not implemented.

## -examples

## -see-also
[Input and interactions](/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](/samples/browse/), [Input: Ink sample](/samples/browse/), [Input: Manipulations and gestures (JavaScript) sample](/samples/browse/), [Input: Simplified ink  sample](/samples/browse/), [Input: Windows 8 gestures sample](/samples/browse/), [Input: XAML user input events sample](/samples/browse/), [XAML scrolling, panning, and zooming sample](/samples/browse/), [DirectX touch input sample](/samples/browse/), [Input: Manipulations and gestures (C++) sample](/samples/browse/), [Input: Touch hit testing sample](/samples/browse/), [Input source identification sample](/samples/browse/), [Touch injection sample](/samples/browse/), [Win32 touch hit-testing sample](/samples/browse/)