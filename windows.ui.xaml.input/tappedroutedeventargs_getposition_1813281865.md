---
-api-id: M:Windows.UI.Xaml.Input.TappedRoutedEventArgs.GetPosition(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Point GetPosition(Windows.UI.Xaml.UIElement relativeTo)
-->

# Windows.UI.Xaml.Input.TappedRoutedEventArgs.GetPosition

## -description
Returns the x- and y-coordinates of the pointer position, optionally evaluated against a coordinate origin of a supplied [UIElement](../windows.ui.xaml/uielement.md).



## -parameters
### -param relativeTo
Any [UIElement](../windows.ui.xaml/uielement.md)-derived object that is connected to the same object tree. To specify the object relative to the overall coordinate system, use a *relativeTo*  value of **null**.

## -returns
A [Point](../windows.foundation/point.md) that represents the current x- and y-coordinates of the mouse pointer position. If **null** was passed as *relativeTo*, this coordinate is for the overall window. If a value other than **null** for *relativeTo* was passed, this coordinate is relative to the object referenced by *relativeTo*.

## -remarks

## -examples

## -see-also
[Point](../windows.foundation/point.md)
