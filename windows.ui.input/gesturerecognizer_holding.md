---
-api-id: E:Windows.UI.Input.GestureRecognizer.Holding
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Holding<Windows.UI.Input.GestureRecognizer,  Windows.UI.Input.HoldingEventArgs>
-->

# Windows.UI.Input.GestureRecognizer.Holding

## -description
Occurs when a user performs a press and hold gesture (with a single touch, mouse, or pen/stylus contact).

## -remarks
To support [Holding](gesturerecognizer_holding.md) with touch and pen/stylus input, specify [Hold](gesturesettings.md) in the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

To support [Holding](gesturerecognizer_holding.md) with mouse input, specify [HoldWithMouse](gesturesettings.md) in the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

The [Holding](gesturerecognizer_holding.md) event is fired twice: Once when holding starts ([started](holdingstate.md)) and again when holding ends ([completed](holdingstate.md) or [canceled](holdingstate.md)).

## -examples

## -see-also
[TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [HoldingEventArgs](holdingeventargs.md), [Input and interactions](https://docs.microsoft.com/windows/uwp/design/input/), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915)