---
-api-id: M:Windows.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates(Windows.Foundation.Point,Windows.UI.Xaml.UIElement,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.UIElement> FindElementsInHostCoordinates(Windows.Foundation.Point intersectingPoint, Windows.UI.Xaml.UIElement subtree, System.Boolean includeAllElements)
-->

# Windows.UI.Xaml.Media.VisualTreeHelper.FindElementsInHostCoordinates

## -description
Retrieves a set of objects that are located within a specified x-y coordinate point of an app UI. The set of objects represents the components of a visual tree that share that point.



## -parameters
### -param intersectingPoint
The point to use as the determination point. This point is using the coordinate space of the app window, not of any specific element (and not of *subtree* if specified).

### -param subtree
An object to search for. If the *subtree* object exists in the overall set of elements that exist at the specified *intersectingPoint* coordinates, then the return value contains only the *subtree* object and any objects that have a higher z-order than *subtree*, listed by inverse of z-order. If the *subtree* object doesn't exist at *intersectingPoint* coordinates, the return value will be empty.

### -param includeAllElements
**true** to include all elements that intersect, including those elements considered to be invisible to hit testing. **false** to find only visible, hit-testable elements. The default is **false**.

## -returns
An enumerable set of [UIElement](../windows.ui.xaml/uielement.md) objects that are determined to be located in the visual tree composition at the specified point, listed by inverse of z-order.

## -remarks
An element is considered hit-testable if it both occupies space in the layout and "*produces ink*". 
For elements that have a [Brush](./brush.md), any non-**null** Brush is considered something that produces ink, even if the Brush doesn't produce visible pixels. For example, a [SolidColorBrush](./solidcolorbrush.md) with its color set to *Transparent* still produces ink. Only a **null** brush does not produce ink. The Opacity property is not considered. The element still produces ink even if it's Opacity is 0.

When the *includeAllElements* parameter is set to **true**, elements that don't produce ink are considered for hit-testing. In this case, as long as the element meets the spatial requirements (the point intersects the element bounds), then it and its ancestors are included in the results.

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

Here are some example usages and results from FindElementsInHostCoordinates, using different *subtree* values:

```csharp
private void Test(object sender, RoutedEventArgs e)
{
    IEnumerable<UIElement> hits;
    hits =  VisualTreeHelper.FindElementsInHostCoordinates(
      new Point(100,100), canvas, true);
    foreach (UIElement element in hits)
    {
        //run logic here, such as log the results 
    }
// results in the following set of elements, listed by Name:
// center - the element that is topmost in z-order at 100,100
// shown - also renders at 100,100 but is underneath 'center'
// hidden - is entirely underneath 'shown', 
//   and lower in z-order because 'hidden' declared before 'shown' in XAML
// outermost - draws under all the above at 100,100
// canvas - the 'subtree' value, so that's the last element reported

    hits = VisualTreeHelper.FindElementsInHostCoordinates(
      new Point(100, 100), center, true);
    foreach (UIElement element in hits) {
        //run logic here, such as log the results
    }
// results in 'center', because it is 'subtree' and also topmost

    hits = VisualTreeHelper.FindElementsInHostCoordinates(
      new Point(100, 100), bottomright, true);
// results in an empty set, 'bottomright' doesn't render at 100,100
}
```



## -see-also
[Point](../windows.foundation/point.md), [FindElementsInHostCoordinates(Point, UIElement)](visualtreehelper_findelementsinhostcoordinates_1478853318.md), [FindElementsInHostCoordinates(Rect, UIElement)](visualtreehelper_findelementsinhostcoordinates_241596294.md), [FindElementsInHostCoordinates(Rect, UIElement, Boolean)](visualtreehelper_findelementsinhostcoordinates_895215498.md), [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions)
