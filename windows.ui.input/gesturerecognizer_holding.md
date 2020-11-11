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
To support Holding with touch and pen/stylus input, specify [Hold](gesturesettings.md) in the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

To support Holding with mouse input, specify [HoldWithMouse](gesturesettings.md) in the [GestureSettings](gesturerecognizer_gesturesettings.md) property.

The Holding event is fired twice: Once when holding starts ([started](holdingstate.md)) and again when holding ends ([completed](holdingstate.md) or [canceled](holdingstate.md)).

## -examples

## -see-also
[TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [HoldingEventArgs](holdingeventargs.md), [Input and interactions](/windows/uwp/design/input/), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](/samples/browse/), [Input: Ink sample](/samples/browse/), [Input: Manipulations and gestures (JavaScript) sample](/samples/browse/), [Input: Simplified ink  sample](/samples/browse/), [Input: Windows 8 gestures sample](/samples/browse/), [Input: XAML user input events sample](/samples/browse/), [XAML scrolling, panning, and zooming sample](/samples/browse/), [DirectX touch input sample](/samples/browse/), [Input: Manipulations and gestures (C++) sample](/samples/browse/), [Input: Touch hit testing sample](/samples/browse/), [Input source identification sample](/samples/browse/), [Touch injection sample](/samples/browse/), [Win32 touch hit-testing sample](/samples/browse/)