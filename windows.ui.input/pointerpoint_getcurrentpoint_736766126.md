---
-api-id: M:Windows.UI.Input.PointerPoint.GetCurrentPoint(System.UInt32,Windows.UI.Input.IPointerPointTransform)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Input.PointerPoint GetCurrentPoint(System.UInt32 pointerId, Windows.UI.Input.IPointerPointTransform transform)
-->

# Windows.UI.Input.PointerPoint.GetCurrentPoint

## -description
Retrieves the transformed information for the specified pointer.

In most cases, we recommend that you obtain pointer info through the pointer event handlers of your chosen Windows 8 language framework (Windows app using JavaScript, Windows Store app using C++, C#, or Visual Basic, or Windows Store app using DirectX with C++).

If the event argument doesn't expose the pointer details required by your app, you can get access to extended pointer data from the event argument through the [getCurrentPoint](XREF:TODO:wwa.MSPointerEvent_getCurrentPoint) and [getIntermediatePoints](XREF:TODO:wwa.MSPointerEvent_getIntermediatePoints) methods or [currentPoint](XREF:TODO:wwa.MSPointerEvent_currentPoint) and [intermediatePoints](XREF:TODO:ie.MSPointerEvent_intermediatePoints) properties. We recommend using the [getCurrentPoint](XREF:TODO:wwa.MSPointerEvent_getCurrentPoint) and [getIntermediatePoints](XREF:TODO:wwa.MSPointerEvent_getIntermediatePoints) methods as you can specify the context of the pointer data.

The static [PointerPoint](pointerpoint.md) methods, [GetCurrentPoint](pointerpoint_getcurrentpoint.md) and [GetIntermediatePoints](pointerpoint_getintermediatepoints.md), always use the context of the app.

## -parameters
### -param pointerId
The ID of the pointer.

### -param transform
The transform to apply to the pointer.

## -returns
The pointer property values.

## -remarks
[GetCurrentPoint](pointerpoint_getcurrentpoint_736766126.md) is a static method.

This method is useful for getting pointer information relative to a specific element.

## -examples

## -see-also
[GetCurrentPoint(UInt32)](pointerpoint_getcurrentpoint_131721878.md)