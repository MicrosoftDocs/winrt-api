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
[Input and interactions](/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](https://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](https://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](https://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](https://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](https://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](https://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](https://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](https://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](https://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](https://go.microsoft.com/fwlink/p/?LinkID=267915)
