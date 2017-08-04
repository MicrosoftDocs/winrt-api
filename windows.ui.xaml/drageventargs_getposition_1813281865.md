---
-api-id: M:Windows.UI.Xaml.DragEventArgs.GetPosition(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Point GetPosition(Windows.UI.Xaml.UIElement relativeTo)
-->

# Windows.UI.Xaml.DragEventArgs.GetPosition

## -description
Returns a drop point that is relative to a specified [UIElement](uielement.md).

## -parameters
### -param relativeTo
The [UIElement](uielement.md) for which to get a relative drop point.

## -returns
A point in the coordinate system that is relative to the element specified in *relativeTo*.

## -remarks
For drag-drop operations involving a UI container, you typically call [GetPosition](drageventargs_getposition.md) using a *relativeTo* reference to the object that is the *sender* of the event. This gives the relative position within the container.

If this [DragEventArgs](drageventargs.md) is associated with the [UIElement.Drop](uielement_drop.md) event, then the return value of [GetPosition](drageventargs_getposition.md) is the drop point.


## -examples

## -see-also
[Point](../windows.foundation/point.md)