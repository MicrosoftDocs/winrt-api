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

In most cases, we recommend that you obtain pointer info through the pointer event handlers of your chosen Windows 8 language framework (Windows app using JavaScript, Windows Store app using C++, C#, or Visual Basic, or Windows Store app using DirectX with C++).

If the event argument doesn't expose the pointer details required by your app, you can get access to extended pointer data from the event argument through the [getCurrentPoint](XREF:TODO:wwa.MSPointerEvent_getCurrentPoint) and [getIntermediatePoints](XREF:TODO:wwa.MSPointerEvent_getIntermediatePoints) methods or [currentPoint](XREF:TODO:wwa.MSPointerEvent_currentPoint) and [intermediatePoints](XREF:TODO:ie.MSPointerEvent_intermediatePoints) properties. We recommend using the [getCurrentPoint](XREF:TODO:wwa.MSPointerEvent_getCurrentPoint) and [getIntermediatePoints](XREF:TODO:wwa.MSPointerEvent_getIntermediatePoints) methods as you can specify the context of the pointer data.

The static [PointerPoint](pointerpoint.md) methods, [GetCurrentPoint](pointerpoint_getcurrentpoint.md) and [GetIntermediatePoints](pointerpoint_getintermediatepoints.md), always use the context of the app.

## -parameters
### -param pointerId
The ID of the pointer.

## -returns
The transformed pointer properties (current and historic).

## -remarks
[GetIntermediatePoints](pointerpoint_getintermediatepoints_143894736.md) is a static method.

The most recent pointer information retrieved by this method is equivalent to that retrieved by the [GetCurrentPoint](pointerpoint_getcurrentpoint_131721878.md) method.

## -examples

## -see-also
[GetIntermediatePoints(UInt32, IPointerPointTransform)](pointerpoint_getintermediatepoints_614492904.md)