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
[Input and interactions](/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Device%20capabilities%20sample), [Input: Simplified ink  sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Input%20Simplified%20ink%20sample), [Input: Windows 8 gestures sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%23%5D-Windows%208%20app%20samples/C%23/Windows%208%20app%20samples/Input%20Windows%208%20gestures%20sample%20(Windows%208)/C%23), [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample), [XAML scrolling, panning, and zooming sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/XAML%20scrolling%2C%20panning%2C%20and%20zooming%20sample), [DirectX touch input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/DirectX%20touch%20input%20sample%20(Windows%208)/C%2B%2B), [Input: Manipulations and gestures (C++) sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Input%20Manipulations%20and%20gestures%20(C%2B%2B)%20sample%20(Windows%208)/C%2B%2B), [Input: Touch hit testing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Input%20Touch%20hit%20testing%20sample%20(Windows%208)/C%2B%2B), [Input source identification sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20desktop%20samples/%5BC%2B%2B%5D-Windows%208%20desktop%20samples/C%2B%2B/Windows%208%20desktop%20samples/Input%20Source%20identification%20sample/C%2B%2B), [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample), [Win32 touch hit-testing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Input%20Touch%20hit%20testing%20sample%20(Windows%208)/C%2B%2B)