---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.IsHorizontalRailEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsHorizontalRailEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.IsHorizontalRailEnabled

## -description
Gets or sets a value that indicates whether the scroll rail is enabled for the horizontal axis.



## -xaml-syntax
```xaml
<ScrollViewer IsHorizontalRailEnabled="bool" />
-or-
<object ScrollViewer.IsHorizontalRailEnabled="bool"/>
```


## -property-value
**True** to enable the horizontal scroll rail; otherwise, **false**. The default is **true**.

## -remarks

When content is scrolled without manipulating the scrollbar directly, for example, by touch, we call it panning. Because content can be both wider and taller than the display area, two-dimensional panning (horizontal and vertical) is often necessary. _Rails_ improve the user experience in these cases by locking the panning to the axis of motion, either vertical or horizontal, as if the content were on a rail.

The following diagram demonstrates the concept of rails.

![diagram of a screen with rails that constrain panning](images/ux-panning-rails.png)

For more info, see [Guidelines for panning](/windows/uwp/design/input/guidelines-for-panning).

## -examples

## -see-also

[Scroll viewer controls](/windows/uwp/design/controls-and-patterns/scroll-controls), [Guidelines for panning](/windows/uwp/design/input/guidelines-for-panning)
