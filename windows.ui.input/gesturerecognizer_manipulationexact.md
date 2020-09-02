---
-api-id: P:Windows.UI.Input.GestureRecognizer.ManipulationExact
-api-type: winrt property
---

<!-- Property syntax
public bool ManipulationExact { get;  set; }
-->

# Windows.UI.Input.GestureRecognizer.ManipulationExact

## -description
Gets or sets a value that indicates whether the exact distance from initial contact to end of the interaction is reported.By default, a small distance threshold is subtracted from the first delta reported by the system. This distance threshold is intended to account for slight movements of the contact when processing a tap gesture. If this flag is set, the distance threshold is not subtracted from the first delta.

## -property-value
True if the distance threshold is subtracted; otherwise false. The default value is false.

## -remarks

## -examples

## -see-also

[Touch interactions - Manipulation events](/windows/uwp/design/input/touch-interactions#manipulation-events), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](https://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](https://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](https://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](https://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](https://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](https://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](https://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](https://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](https://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](https://go.microsoft.com/fwlink/p/?LinkID=267915)
