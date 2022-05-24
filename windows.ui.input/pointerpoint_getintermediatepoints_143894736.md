---
-api-id: M:Windows.UI.Input.PointerPoint.GetIntermediatePoints(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Input.PointerPoint> GetIntermediatePoints(System.UInt32 pointerId)
-->

# Windows.UI.Input.PointerPoint.GetIntermediatePoints

## -description
Retrieves position and state information for the specified pointer, from the last pointer event up to and including the current pointer event.

In most cases, we recommend that you get pointer info through the event argument of the pointer event handlers in your chosen language framework (Windows app using JavaScript, UWP app using C++, C#, or Visual Basic, or UWP app using DirectX with C++).

If the event argument doesn't intrinsically expose the pointer details required by your app, you can get access to extended pointer data through the [GetCurrentPoint](../windows.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_1761708789.md) and [GetIntermediatePoints](../windows.ui.xaml.input/pointerroutedeventargs_getintermediatepoints_1716242609.md) methods of [PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md). Use these methods to specify the context of the pointer data.

The static [PointerPoint](pointerpoint.md) methods, [GetCurrentPoint](pointerpoint_getcurrentpoint_131721878.md) and GetIntermediatePoints, always use the app context.

## -parameters
### -param pointerId
The ID of the pointer.

## -returns
The transformed pointer properties (current and historic).

## -remarks
GetIntermediatePoints is a static method.

The most recent pointer information retrieved by this method is equivalent to that retrieved by the [GetCurrentPoint](pointerpoint_getcurrentpoint_131721878.md) method.

## -examples

## -see-also
[GetIntermediatePoints(UInt32, IPointerPointTransform)](pointerpoint_getintermediatepoints_614492904.md)
