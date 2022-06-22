---
-api-id: M:Windows.UI.Xaml.Input.PointerRoutedEventArgs.GetCurrentPoint(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Input.PointerPoint GetCurrentPoint(Windows.UI.Xaml.UIElement relativeTo)
-->

# Windows.UI.Xaml.Input.PointerRoutedEventArgs.GetCurrentPoint

## -description
Retrieves a [PointerPoint](../windows.ui.input/pointerpoint.md) object that provides basic info on the pointer associated with the event.



## -parameters
### -param relativeTo
Any [UIElement](../windows.ui.xaml/uielement.md)-derived object that is connected to the same object tree. To specify the object relative to the overall coordinate system, use a *relativeTo*  value of **null**.

## -returns
A [PointerPoint](../windows.ui.input/pointerpoint.md) value that represents the pointer point associated with this event. If **null** was passed as *relativeTo*, the coordinates are in the frame of reference of the overall window. If a *relativeTo* value other than **null** was passed, the coordinates are relative to the object referenced by *relativeTo*.

## -remarks

## -examples

## -see-also
