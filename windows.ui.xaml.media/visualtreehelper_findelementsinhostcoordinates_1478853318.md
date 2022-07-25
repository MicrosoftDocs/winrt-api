---
-api-id: M:Windows.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates(Windows.Foundation.Point,Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.UIElement> FindElementsInHostCoordinates(Windows.Foundation.Point intersectingPoint, Windows.UI.Xaml.UIElement subtree)
-->

# Windows.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates

## -description
Retrieves a set of objects that are located within a specified x-y coordinate point of an app UI. The set of objects represents the components of a visual tree that share that point.



## -parameters
### -param intersectingPoint
The point to use as the determination point. This point is using the coordinate space of the app window, not of any specific element (and not of *subtree* if specified).

### -param subtree
An object to search for. If the *subtree* object exists in the overall set of elements that exist at the specified *intersectingPoint* coordinates, then the return value contains only the *subtree* object and any objects that have a higher z-order than *subtree*, listed by inverse of z-order. If the *subtree* object doesn't exist at *intersectingPoint* coordinates, the return value will be empty.

## -returns
An enumerable set of [UIElement](../windows.ui.xaml/uielement.md) objects in the visual tree composition at the specified point, listed by inverse of z-order.

## -remarks
The return value is not a single element, it is a collection. The collection can have more than one element because there can be multiple UI elements stacked over each other in a z-order. The conventional hit-testing techniques exposed by the input event handlers, such as the *sender* value for a [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) event, only account for the topmost element that has the highest z-order. FindElementsInHostCoordinates methods return the whole stack of elements that share that point or area in the app UI, listed by inverse of z-order. Using FindElementsInHostCoordinates can thus be useful for examining cases where you've intentionally or unintentionally stacked elements. You may want to correct the order for rendering and hit-testing, or examine that order for other reasons.

FindElementsInHostCoordinates is useful for three scenarios: basic hit testing, hit testing that is filtering for a specific element, and determining whether there are elements in a visual tree that are overdrawing at the same point.

### Basic hit testing

For basic hit testing, the goal is to discover which element is highest in the z-order of an app UI at a given point in x-y coordinates. In addition to being the element that draws topmost in the rendered UI, this element is also important because it's the reported event source if there are user interactions such as pointer events. You might have hit testing scenarios where you want to know what element exists at the top z-order before any input event takes place, so that you can anticipate it and perhaps correct any mistakes in z-order placement.

For this scenario, you should pass the point you're interested in hit-testing as the value of the *intersectingPoint* parameter. For the *subtree* parameter, you can pass it as **null**. Or you can specify *subtree* to be some element that you know is the root visual of a page, or is otherwise some element that you want to be the final stop for hit testing.

The element that is topmost in the z-order is always the first element in the returned [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) of [UIElement](../windows.ui.xaml/uielement.md) items. So for basic hit testing you're usually only interested in that very first item. Any additional items in the [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) are other elements that are also at that point but are further back in the z-order and are drawing underneath that first item. The elements further back wouldn't report themselves as the source for an input event at that point, only the topmost element would.

### Element-filtered hit testing

Sometimes you want to know whether a specific element exists at a certain point in the UI. If so, you can specify that point for *intersectingPoint* and specify the element you're looking for as the *subtree* parameter. If the return value is not empty, that means that the element does exist at that point in the UI. If the element is the first item in the return value, that means the element is topmost in the z-order at *intersectingPoint*. If there are other items in the return value and *subtree* isn't first, the other items represent the elements rendering at *intersectingPoint* that are higher in z-order (visually, these render on top of the *subtree* element). In that case *subtree* is the last element in the returned [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true), not the first.

If the return value is empty, that means that the *subtree* element didn't exist there, at any z-order value.

### Looking for overdraw or looking at the complete visual tree

A UI can be dynamic, especially if you're using collections from data binding for UI population. So there's occasionally a need to know which element is currently on top. You might be anticipating points in the app where the user might interact and verifying that the interactions you intend are currently possible. For this scenario, you typically specify a [Point](../windows.foundation/point.md) value that represents some known point such as (0,0) that is currently a valid coordinate that's within your app window. For the *subtree* parameter, you can pass it as **null**. Or you can specify *subtree* to be some element that you know is the root visual of a page, or is otherwise some element that you want to be the final stop for hit testing.

> [!NOTE]
> If you pass **null** for *subtree*, you might see that the visual tree contains elements that aren't defined by page-level XAML, such as a [Frame](../windows.ui.xaml.controls/frame.md) element and [ContentPresenter](../windows.ui.xaml.controls/contentpresenter.md). These come from the typical app initialization code that exists in most of the Microsoft Visual Studio project templates for a UWP app, which first creates the [Frame](../windows.ui.xaml.controls/frame.md) to be the [Window.Content](../windows.ui.xaml/window_content.md) value. The visual tree as shown by FindElementsInHostCoordinates methods extends all the way to [Window.Content](../windows.ui.xaml/window_content.md) unless you otherwise filter it with a *subtree* element such as a [Page](../windows.ui.xaml.controls/page.md) root.

In the return value, you might be interested in each of the items within. So you could use **foreach** or similar language-specific techniques to iterate the collection and run your own logic on each of these elements. Remember that the first element in that collection is the one that is topmost in z-order.

If you are programming using C# or Microsoft Visual Basic, the return value type of this method is projected as an [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) generic collection that contains [UIElement](../windows.ui.xaml/uielement.md) items. If you are programming using Visual C++ component extensions (C++/CX), the return type of this method is [IIterable<UIElement>](../windows.foundation.collections/iiterable_1.md).

## -examples
This is an example utility method that determines whether an element of a given [Name](../windows.ui.xaml/frameworkelement_name.md) exists anywhere in the z-order at a [Point](../windows.foundation/point.md) in the UI of an app.

```csharp
private bool DoesPointContainElement(Point testPoint, string elementName, UIElement referenceFrame)
{
    IEnumerable<UIElement> elementStack = 
      VisualTreeHelper.FindElementsInHostCoordinates(testPoint, referenceFrame);
    foreach (UIElement item in elementStack)
    {
        FrameworkElement feItem = item as FrameworkElement; 
//cast to FrameworkElement, need the Name property
        if (feItem != null)
        {
            if (feItem.Name.Equals(elementName))
            {
                 return true;
            }
        }
     }
     // elementName was not in this stack 
     return false;
}
```



## -see-also
[Point](../windows.foundation/point.md), [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions)
