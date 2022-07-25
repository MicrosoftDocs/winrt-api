---
-api-id: T:Windows.UI.Xaml.Controls.ItemsStackPanel
-api-type: winrt class
---

<!-- Class syntax.
public class ItemsStackPanel : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IItemsStackPanel, Windows.UI.Xaml.Controls.IItemsStackPanel2
-->

# Windows.UI.Xaml.Controls.ItemsStackPanel

## -description
Arranges child elements of an [ItemsControl](itemscontrol.md) into a single line that can be oriented horizontally or vertically. Supports pixel-based UI virtualization and grouped layouts.



## -xaml-syntax
```xaml
<ItemsStackPanel .../>
```


## -remarks
ItemsStackPanel can be used only as the [ItemsPanel](itemscontrol_itemspanel.md) of an [ItemsControl](itemscontrol.md) that displays more than one item at a time. It can't be used with an [ItemsControl](itemscontrol.md) that displays only one item at a time, such as a [ComboBox](combobox.md) or [FlipView](flipview.md). ItemsStackPanel is the default [ItemsPanel](itemscontrol_itemspanel.md) for [ListView](listview.md).

By default, the ItemsStackPanel stacks items vertically from top to bottom. You can set the [Orientation](itemsstackpanel_orientation.md) property to **Horizontal** to stack items from left to right.

## -examples
This example shows how to use an ItemsStackPanel to display [ListView](listview.md) items stacked horizontally.

```xaml
<ListView>
    <ListView.ItemsPanel> 
        <ItemsPanelTemplate>
            <ItemsStackPanel Orientation="Horizontal"/>  
        </ItemsPanelTemplate> 
    </ListView.ItemsPanel> 
</ListView> 

```



## -see-also
[Panel](panel.md), [Orientation enumeration](orientation.md)
