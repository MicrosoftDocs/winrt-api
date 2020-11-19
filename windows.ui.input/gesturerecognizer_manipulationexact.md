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

[Touch interactions - Manipulation events](/windows/uwp/design/input/touch-interactions#manipulation-events), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](/samples/browse/), [Input: Ink sample](/samples/browse/), [Input: Manipulations and gestures (JavaScript) sample](/samples/browse/), [Input: Simplified ink  sample](/samples/browse/), [Input: Windows 8 gestures sample](/samples/browse/), [Input: XAML user input events sample](/samples/browse/), [XAML scrolling, panning, and zooming sample](/samples/browse/), [DirectX touch input sample](/samples/browse/), [Input: Manipulations and gestures (C++) sample](/samples/browse/), [Input: Touch hit testing sample](/samples/browse/), [Input source identification sample](/samples/browse/), [Touch injection sample](/samples/browse/), [Win32 touch hit-testing sample](/samples/browse/)