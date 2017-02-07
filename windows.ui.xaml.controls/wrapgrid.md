---
-api-id: T:Windows.UI.Xaml.Controls.WrapGrid
-api-type: winrt class
---

<!-- Class syntax.
public class WrapGrid : Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel, Windows.UI.Xaml.Controls.IWrapGrid
-->

# Windows.UI.Xaml.Controls.WrapGrid

## -description
Positions child elements sequentially from left to right or top to bottom. When elements extend beyond the container edge, elements are positioned in the next row or column. Can only be used to display items in an [ItemsControl](itemscontrol.md).

> [!NOTE]
> Starting in Windows 8.1, we recommend that you use [ItemsWrapGrid](itemswrapgrid.md) instead of [WrapGrid](wrapgrid.md).

## -xaml-syntax
```xaml
<WrapGrid ...>
  oneOrMoreUIElements
</WrapGrid>
```


## -remarks
> [!NOTE]
> Starting in Windows 8.1, [ItemsWrapGrid](itemswrapgrid.md) is used as the default [ItemsPanel](itemscontrol_itemspanel.md) for [GridView](gridview.md). If you modify the [ItemsPanel](itemscontrol_itemspanel.md), we recommend you use [ItemsStackPanel](itemsstackpanel.md) or [ItemsWrapGrid](itemswrapgrid.md) instead of [VirtualizingStackPanel](virtualizingstackpanel.md) or [WrapGrid](wrapgrid.md).

[WrapGrid](wrapgrid.md) can only be used to display items in an [ItemsControl](itemscontrol.md).

The content of a [WrapGrid](wrapgrid.md) is virtualized. This can improve performance when you work with large data sets. For more info, see [Optimize ListView and GridView](http://msdn.microsoft.com/library/26df15e8-2c05-4174-a714-7df2e8273d32).

In a [WrapGrid](wrapgrid.md), elements are arranged in rows or columns that automatically wrap to a new row or column when the [MaximumRowsOrColumns](wrapgrid_maximumrowsorcolumns.md) value is reached. The [Orientation](wrapgrid_orientation.md) property specifies whether the grid adds its items in rows or columns before wrapping.

When the value is **Vertical**, the grid adds items in columns from top to bottom, then wraps from left to right, like this:<table>
   <tr><td>Item 1</td><td>Item 4</td><td>Item 7</td></tr>
   <tr><td>Item 2</td><td>Item 5</td><td>Item 8</td></tr>
   <tr><td>Item 3</td><td>Item 6</td><td>Item 9</td></tr>
</table>

When the value is **Horizontal**, the grid adds items in rows from left to right, then wraps from top to bottom, like this:<table>
   <tr><td>Item 1</td><td>Item 2</td><td>Item 3</td></tr>
   <tr><td>Item 4</td><td>Item 5</td><td>Item 6</td></tr>
   <tr><td>Item 7</td><td>Item 8</td><td>Item 9</td></tr>
</table>


<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 465778-->
### Windows 8 behavior

For Windows 8, items added to the items lists programmatically at run-time sometimes would start a new row in the internal grid representation, even if the item could have been added to an existing row based on the [MaximumRowsOrColumns](wrapgrid_maximumrowsorcolumns.md) setting.

Starting with Windows 8.1, items added to items lists programmatically at run-time will fill rows in expected ways, starting a new row only when row-column limits are exceeded.

This behavior difference usually has no effect on the layout the user sees, because the items control that contains the [WrapGrid](wrapgrid.md) is ultimately controlling the layout. But the difference can be detected if you are using coordinate-relative techniques to check the layout within the [WrapGrid](wrapgrid.md). For instance, you might see coordinate differences if you are calling [TransformToVisual](../windows.ui.xaml/uielement_transformtovisual.md) or [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md)  API, with the [WrapGrid](wrapgrid.md) as the "relative-to" element.

If you migrate your app code from Windows 8 to Windows 8.1, and you're doing advanced layout verification with [TransformToVisual](../windows.ui.xaml/uielement_transformtovisual.md) or [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md) within a [WrapGrid](wrapgrid.md) you may want to account for this behavior change.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[OrientedVirtualizingPanel](../windows.ui.xaml.controls.primitives/orientedvirtualizingpanel.md), [IScrollSnapPointsInfo](../windows.ui.xaml.controls.primitives/iscrollsnappointsinfo.md), [ItemsControl.ItemsPanel](itemscontrol_itemspanel.md), [ItemsPanelTemplate](itemspaneltemplate.md), [Quickstart: Adding ListView and GridView controls](http://msdn.microsoft.com/library/b237d616-33de-4ddd-9df5-27c47f81b064)