---
-api-id: M:Windows.UI.Xaml.Media.Animation.ConnectedAnimation.TryStart(Windows.UI.Xaml.UIElement,Windows.Foundation.Collections.IIterable{Windows.UI.Xaml.UIElement})
-api-type: winrt method
---

<!-- Method syntax.
public bool ConnectedAnimation.TryStart(UIElement destination, IIterable<UIElement> coordinatedElements)
-->

# Windows.UI.Xaml.Media.Animation.ConnectedAnimation.TryStart

## -description
Attempts to start the animation on the destination element and specified secondary elements.



## -parameters

### -param destination
The element that is animated into view.

### -param coordinatedElements

The collection of secondary elements. These elements will play an entrance animation where they travel alongside the connected animation target in a "coordinated animation".

## -returns
**true** if the animation started; **false** if the animation has already been started, if it is no longer active, or if the destination element is the same as the source element.

## -remarks

## -see-also

## -examples

