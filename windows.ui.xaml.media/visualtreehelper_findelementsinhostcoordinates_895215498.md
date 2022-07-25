---
-api-id: M:Windows.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates(Windows.Foundation.Rect,Windows.UI.Xaml.UIElement,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.UIElement> FindElementsInHostCoordinates(Windows.Foundation.Rect intersectingRect, Windows.UI.Xaml.UIElement subtree, System.Boolean includeAllElements)
-->

# Windows.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates

## -description
Retrieves a set of objects that are located within a specified [Rect](../windows.foundation/rect.md) frame of an app UI. The set of objects represents the components of a visual tree that share a rectangular area, and might include elements that overdraw.



## -parameters
### -param intersectingRect
The [Rect](../windows.foundation/rect.md) to use as the determination area. This frame is using the coordinate space of the app window, not of any specific element (and not of *subtree* if specified).

### -param subtree
An object to search for. If the *subtree* object exists in the overall set of elements that exist within the specified *intersectingRect*, then the return value contains only the *subtree* object and elements that are drawing on top of its space. If the *subtree* object doesn't exist within the *intersectingRect* frame, the return value will be empty.

### -param includeAllElements
**true** to include all elements that intersect, including those elements considered to be invisible to hit testing. **false** to find only visible, hit-testable elements. The default is **false**.

## -returns
An enumerable set of [UIElement](../windows.ui.xaml/uielement.md) objects that are determined to be located in the visual tree composition in the specified [Rect](../windows.foundation/rect.md) frame.

## -remarks
An element is considered hit-testable if it both occupies space in the layout and "*produces ink*". 
For elements that have a [Brush](./brush.md), any non-**null** Brush is considered something that produces ink, even if the Brush doesn't produce visible pixels. For example, a [SolidColorBrush](./solidcolorbrush.md) with its color set to *Transparent* still produces ink. Only a **null** brush does not produce ink. The Opacity property is not considered. The element still produces ink even if it's Opacity is 0.

When the *includeAllElements* parameter is set to **true**, elements that don't produce ink are considered for hit-testing. In this case, as long as the element meets the spatial requirements (the rect intersects the element bounds), then it and its ancestors are included in the results.

> [!NOTE]
> Some special elements, like [SwapChainPanel](./../windows.ui.xaml.controls/swapchainpanel.md) and [MediaElement](./../windows.ui.xaml.controls/mediaelement.md), don’t have a brush but can still produce ink.

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

Here are some example usages and results from [FindElementsInHostCoordinates](visualtreehelper_findelementsinhostcoordinates_241596294.md), using different *subtree* values:

```csharp
private void Test(object sender, RoutedEventArgs e)
{
    IEnumerable<UIElement> hits;
    hits =  VisualTreeHelper.FindElementsInHostCoordinates(
      new Rect(75,75,50,50), canvas, true);
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
      new Rect(75,75,50,50), center, true);
    foreach (UIElement element in hits) {
        //run logic here, such as log the results
    }
// results in only 'center', because it was 'subtree' and it's also topmost

    hits = VisualTreeHelper.FindElementsInHostCoordinates(
      new Rect(75,75,50,50), bottomright, true);
// results in an empty set, 'bottomright' isn't in the specified rect
}
```



## -see-also
[FindElementsInHostCoordinates(Point, UIElement)](visualtreehelper_findelementsinhostcoordinates_1478853318.md), [FindElementsInHostCoordinates(Rect, UIElement)](visualtreehelper_findelementsinhostcoordinates_241596294.md), [FindElementsInHostCoordinates(Point, UIElement, Boolean)](visualtreehelper_findelementsinhostcoordinates_1662522058.md), [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions)
