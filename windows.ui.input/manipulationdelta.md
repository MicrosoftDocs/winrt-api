---
-api-id: T:Windows.UI.Input.ManipulationDelta
-api-type: winrt struct
---

<!-- Structure syntax.
public struct ManipulationDelta 
-->

# ManipulationDelta

## -description
Contains the accumulated transformations for the current manipulation.

## -struct-fields

### -field Translation

The change in x-y screen coordinates, in device-independent pixel (DIP).

### -field Scale

The change in distance between touch contacts, as a percentage. For example, if the distance between two contacts changes from 100 device-independent pixel (DIP) to 200 device-independent pixel (DIP) during a manipulation, the value of **Scale** would be 1.0.

### -field Rotation

The change in angle of rotation, in degrees.

### -field Expansion

The change in distance between touch contacts, as device-independent pixel (DIP). For example, if the distance between two contacts changes from 100 device-independent pixel (DIP) to 200 device-independent pixel (DIP) during a manipulation, the value of **Expansion** would be 100.0.

## -remarks

## -examples

## -see-also

[Touch interactions - Manipulation events](https://docs.microsoft.com/windows/uwp/design/input/touch-interactions#manipulation-events), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915)