---
-api-id: P:Windows.UI.Input.GestureRecognizer.CrossSlideExact
-api-type: winrt property
---

<!-- Property syntax
public bool CrossSlideExact { get;  set; }
-->

# Windows.UI.Input.GestureRecognizer.CrossSlideExact

## -description
Gets or sets a value that indicates whether the exact distance from initial contact to end of the cross-slide interaction is reported.By default, a small distance threshold is subtracted from the first position reported by the system for cross-slide interactions. If this flag is set, the distance threshold is not subtracted from the initial position.

> [!NOTE]
> This distance threshold is intended to account for any slight movement of the contact after initial detection. It helps the system differentiate between cross-sliding and panning, and helps ensure that a tap gesture is not interpreted as either.

## -property-value
True if the distance threshold is not subtracted; otherwise false. The default value is false.

## -remarks

## -examples

## -see-also
[Input and interactions](https://docs.microsoft.com/windows/uwp/design/input/), [User interaction mode sample](https://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](https://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](https://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](https://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](https://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](https://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](https://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](https://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](https://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](https://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](https://go.microsoft.com/fwlink/p/?LinkID=267915)
