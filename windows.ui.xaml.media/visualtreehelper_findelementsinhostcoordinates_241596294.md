---
-api-id: M:Windows.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates(Windows.Foundation.Rect,Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.UIElement> FindElementsInHostCoordinates(Windows.Foundation.Rect intersectingRect, Windows.UI.Xaml.UIElement subtree)
-->

# Windows.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates

## -description
Retrieves a set of objects that are located within a specified [Rect](../windows.foundation/rect.md) frame of an app UI. The set of objects represents the components of a visual tree that share a rectangular area, and might include elements that overdraw.



## -parameters
### -param intersectingRect
The [Rect](../windows.foundation/rect.md) to use as the determination area. This frame is using the coordinate space of the app window, not of any specific element (and not of *subtree* if specified).

### -param subtree
An object to search for. If the *subtree* object exists in the overall set of elements that exist within the specified *intersectingRect*, then the return value contains only the *subtree* object and elements that are drawing on top of its space. If the *subtree* object doesn't exist within the *intersectingRect* frame, the return value will be empty.

## -returns
An enumerable set of [UIElement](../windows.ui.xaml/uielement.md) objects that are in the visual tree composition in the specified [Rect](../windows.foundation/rect.md) frame.

## -remarks
The return value is not a single element, it is a collection. The collection can have more than one element because there can be multiple UI elements stacked over each other in a z-order, and also multiple elements fully or partially in the *intersectingRect* frame. The conventional hit-testing techniques exposed by the input event handlers, such as the *sender* value for a [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) event, only account for the topmost element that has the highest z-order. [FindElementsInHostCoordinates](visualtreehelper_findelementsinhostcoordinates_1478853318.md) methods return the whole stack of elements that share that point or area in the app UI, listed by visual tree order (which is usually the same as inverse of XAML declaration order). Using [FindElementsInHostCoordinates](visualtreehelper_findelementsinhostcoordinates_1478853318.md) can thus be useful for examining cases where you've intentionally or unintentionally stacked elements. You may want to correct the order for rendering and hit-testing, or examine that order for other reasons.

[FindElementsInHostCoordinates](visualtreehelper_findelementsinhostcoordinates_1478853318.md) over an area is useful for two scenarios: basic hit testing and hit testing that is filtering for a specific element.

### Basic hit testing

For basic hit testing, the goal is to discover which element is highest in the z-order of an app UI. If you are hit-testing for a mouse interaction you might use a point, but for touch-oriented hit testing it's often appropriate to use a rectangular area. You might have hit testing scenarios where you want to know what element exists at the top z-order before any touch event takes place. Or you might have a point that you want to expand to be a rectangle to see what's near a center point and which element might be the intended target.

For this scenario, you should pass the rectangle you're interested in hit-testing as the value of the *intersectingRect* parameter. For the *subtree* parameter, you can pass it as **null**. Or you can specify *subtree* to be some element that you know is the root visual of a page, or is otherwise some element that you want to be the final stop for hit testing.

The order of element in the returned [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) of [UIElement](../windows.ui.xaml/uielement.md) items is accounting for both coordinate space in the area and for the z-order. So it's possible to get hits for items that are not at the highest z-order and therefore couldn't be the source of input events. To make sure, you can do an element-filtered hit test for any items from the returned list that you're interested in, using the same *intersectingRect* but passing the element of interest as *subtree*.

### Element-filtered hit testing

Sometimes you want to know whether a specific element exists within an area of the UI. If so, you can specify that area for *intersectingRect* and specify the element you're looking for as the *subtree* parameter. If the return value is not empty, that means that the element exists somewhere in that area. When you're hit-testing an area, the order in the return set isn't as useful for determining z-order because the set includes elements at more than one x-y coordinate. The set has a mix of elements drawing at various x-y coordinates and also elements that might be fully or partially overdrawn. To really examine an overdraw situation, use the overloads of [FindElementsInHostCoordinates](visualtreehelper_findelementsinhostcoordinates_1478853318.md) that use a [Point](../windows.foundation/point.md), so that the x-y coordinates and the visual tree order are no longer a factor. See [FindElementsInHostCoordinates(Point,UIElement)](visualtreehelper_findelementsinhostcoordinates_1478853318.md).

If the return value is empty, that means that the *subtree* element didn't exist in the area.

If you are programming using C# or Microsoft Visual Basic, the return value type of this method is projected as an [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) generic collection that contains [UIElement](../windows.ui.xaml/uielement.md) items. If you are programming using Visual C++ component extensions (C++/CX), the return type of this method is [IIterable<UIElement>](../windows.foundation.collections/iiterable_1.md).

## -examples
Given this XAML UI:

```xaml
<Canvas Name="canvas">
  <Rectangle Name="outermost" Fill="Red" Width="200" Height="200"/>
  <Rectangle Canvas.Left="40" Canvas.Top="40" Name="hidden" Fill="Green" Width="120" Height="120"/>
  <Rectangle Canvas.Left="40" Canvas.Top="40" Name="shown" Fill="Orange" Width="120" Height="120"/>
  <Rectangle Canvas.Left="80" Canvas.Top="80" Name="center" Fill="Yellow" Width="40" Height="40"/>
  <Rectangle Canvas.Left="190" Canvas.Top="190" Name="bottomright" Fill="Pink" Width="10" Height="10"/>
</Canvas>
```

Here are some example usages and results from FindElementsInHostCoordinates, using different *subtree* values:

```csharp
private void Test(object sender, RoutedEventArgs e)
{
    IEnumerable<UIElement> hits;
    hits =  VisualTreeHelper.FindElementsInHostCoordinates(
      new Rect(75,75,50,50), canvas);
    foreach (UIElement element in hits)
    {
        //run logic here, such as log the results 
    }
// results in the following set of elements, listed by Name:
// center - the last declared XAML element is first returned, if within the area
// shown - renders, underneath 'center' in part of the area but visible on the edges
// hidden - entirely under 'shown', not visible but part of the area, an overdraw
// outermost - draws under all the above
// canvas - the 'subtree' value, and the last element reported

    hits = VisualTreeHelper.FindElementsInHostCoordinates(
      new Rect(75,75,50,50), center);
    foreach (UIElement element in hits) {
        //run logic here, such as log the results
    }
// results in only 'center', because it was 'subtree' and it's also topmost

    hits = VisualTreeHelper.FindElementsInHostCoordinates(
      new Rect(75,75,50,50), bottomright);
// results in an empty set, 'bottomright' isn't in the specified rect
}
```



## -see-also
[Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions)
