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

Specifically, [GestureRecognizer](gesturerecognizer.md) objects can be recycled for UI elements that do not support or can no longer process a double tap gesture. For example, if [CanBeDoubleTap](gesturerecognizer_canbedoubletap.md) returns true for the most recent [PointerPoint](pointerpoint.md), it’s not safe to recycle the [GestureRecognizer](gesturerecognizer.md) because a double tap is still a viable interaction based on subsequent input. If [CanBeDoubleTap](gesturerecognizer_canbedoubletap.md) returns false, the [GestureRecognizer](gesturerecognizer.md) can be safely recycled.

This method is not required if [GestureRecognizer](gesturerecognizer.md) object pool management is not implemented.

## -examples

## -see-also
