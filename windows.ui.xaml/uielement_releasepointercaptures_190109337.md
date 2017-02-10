---
-api-id: M:Windows.UI.Xaml.UIElement.ReleasePointerCaptures
-api-type: winrt method
---

<!-- Method syntax
public void ReleasePointerCaptures()
-->

# Windows.UI.Xaml.UIElement.ReleasePointerCaptures

## -description
Releases all pointer captures held by this element.

## -remarks
Because there are input scenarios such as manipulations that involve more than one pointer point, the Windows Runtime enables capturing more than one pointer at a time. Calling [ReleasePointerCapture](uielement_releasepointercapture.md) removes a specific [Pointer](../windows.ui.xaml.input/pointer.md) from the collection as identified by its ID, whereas [ReleasePointerCaptures](uielement_releasepointercaptures.md) clears the entire collection.

User action that invalidates pointer capture such as releasing from a pointer point also changes capture state. For more info, see [Mouse interactions](http://msdn.microsoft.com/library/c8a158ef-70a9-4ba2-a270-7d08125700ac) and [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82).

The [PointerCaptures](uielement_pointercaptures.md) property exposes a view of which pointer points are currently captured by the [UIElement](uielement.md).

## -examples

## -see-also
[ReleasePointerCapture](uielement_releasepointercapture.md)