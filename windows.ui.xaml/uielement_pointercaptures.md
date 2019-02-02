---
-api-id: P:Windows.UI.Xaml.UIElement.PointerCaptures
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Xaml.Input.Pointer> PointerCaptures { get; }
-->

# Windows.UI.Xaml.UIElement.PointerCaptures

## -description
Gets the set of all captured pointers, represented as [Pointer](../windows.ui.xaml.input/pointer.md) values.

## -property-value
The collection of captured pointers, each represented as a [Pointer](../windows.ui.xaml.input/pointer.md) object.
## -remarks
For more info on how to capture a pointer and why you might want to do so, see [CapturePointer](uielement_capturepointer_916768934.md).

Because there are input scenarios such as manipulations that involve more than one pointer point, the Windows Runtime enables capturing more than one pointer at a time. The [PointerCaptures](uielement_pointercaptures.md) property exposes a view of which pointer points are currently captured by the [UIElement](uielement.md).

This property's value is calculated based on the results of other actions. Calling [CapturePointer](uielement_capturepointer_916768934.md) adds to the internal collection that [PointerCaptures](uielement_pointercaptures.md) provides a read-only view of. Calling [ReleasePointerCapture](uielement_releasepointercapture_962192786.md) removes from the collection. [ReleasePointerCaptures](uielement_releasepointercaptures_190109337.md) clears the collection. User action that invalidates pointer capture such as releasing from a pointer point also changes capture state and thus the collection. For more info, see [Mouse interactions](https://msdn.microsoft.com/library/c8a158ef-70a9-4ba2-a270-7d08125700ac) and [Handle pointer input](https://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82).

The collection is not necessarily indexed by [PointerId](../windows.ui.xaml.input/pointer_pointerid.md). To find a specific [PointerId](../windows.ui.xaml.input/pointer_pointerid.md), you must check the items in the collection and reference a specific [Pointer](../windows.ui.xaml.input/pointer.md).

## -examples

## -see-also
[CapturePointer](uielement_capturepointer_916768934.md), [PointerCaptures](uielement_pointercaptures.md), [Pointer](../windows.ui.xaml.input/pointer.md), [Handle pointer input](https://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82)
