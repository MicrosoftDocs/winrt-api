---
-api-id: T:Windows.UI.Xaml.Controls.ItemsWrapGrid
-api-type: winrt class
---

<!-- Class syntax.
public class ItemsWrapGrid : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IItemsWrapGrid, Windows.UI.Xaml.Controls.IItemsWrapGrid2
-->

# Windows.UI.Xaml.Controls.ItemsWrapGrid

## -description
Positions child elements sequentially from left to right or top to bottom in an [ItemsControl](itemscontrol.md) that shows multiple items. When elements extend beyond the container edge, elements are positioned in the next row or column. Supports pixel-based UI virtualization and grouped layouts.



## -xaml-syntax
```xaml
<ItemsWrapGrid .../>

```


## -remarks
ItemsWrapGrid can be used only as the [ItemsPanel](itemscontrol_itemspanel.md) of an [ItemsControl](itemscontrol.md) that displays more than one item at a time. It can't be used with an [ItemsControl](itemscontrol.md) that displays only one item at a time, such as a [ComboBox](combobox.md) or [FlipView](flipview.md). ItemsWrapGrid is the default [ItemsPanel](itemscontrol_itemspanel.md) for [GridView](gridview.md).

In an ItemsWrapGrid, elements are arranged in rows or columns that automatically wrap to a new row or column when the elements reach the container edge. If the [MaximumRowsOrColumns](itemswrapgrid_maximumrowsorcolumns.md) property is set, items wrap when the specified number of rows or columns is reached instead.

### Orientation

You set the [Orientation](itemswrapgrid_orientation.md) property to specify whether the grid adds its items in rows or columns before wrapping. The default is [Orientation.Vertical](orientation.md).

> [!NOTE]
> For Universal Windows Platform (UWP) app on Windows 10, the default [GridView](gridview.md) template sets the [Orientation](itemswrapgrid_orientation.md) to **Horizontal**.

When the value is **Vertical**, the grid adds items in columns from top to bottom, then wraps from left to right. Columns of items scroll or pan horizontally.<table>
   <tr><td>Item 1</td><td>Item 4</td><td>Item 7</td></tr>
   <tr><td>Item 2</td><td>Item 5</td><td>Item 8</td></tr>
   <tr><td>Item 3</td><td>Item 6</td><td>Item 9</td></tr>
</table>

When the value is **Horizontal**, the grid adds items in rows from left to right, then wraps from top to bottom. Rows of items scroll or pan vertically. <table>
   <tr><td>Item 1</td><td>Item 2</td><td>Item 3</td></tr>
   <tr><td>Item 4</td><td>Item 5</td><td>Item 6</td></tr>
   <tr><td>Item 7</td><td>Item 8</td><td>Item 9</td></tr>
</table>

## -examples
```xaml
<GridView>
    <GridView.ItemsPanel> 
        <ItemsPanelTemplate>
            <ItemsWrapGrid Orientation="Horizontal"/>  
        </ItemsPanelTemplate> 
    </GridView.ItemsPanel> 
</GridView> 

```



## -see-also
[Panel](panel.md), [Orientation enumeration](orientation.md)
