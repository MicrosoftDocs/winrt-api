---
-api-id: P:Windows.UI.Xaml.Controls.ItemsStackPanel.ItemsUpdatingScrollMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ItemsUpdatingScrollMode ItemsUpdatingScrollMode { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsStackPanel.ItemsUpdatingScrollMode

## -description
Gets or sets a value that specifies scrolling behavior when the [ItemsSource](itemscontrol_itemssource.md) is updated.



## -xaml-syntax
```xaml
<ItemsStackPanel ItemsUpdatingScrollMode="itemsUpdatingScrollModeMemberName" />
```


## -property-value
A value of the enumeration. The default is **KeepItemsInView**.

## -remarks
This property controls how the [ItemsStackPanel](itemsstackpanel.md) responds when the user has scrolled the items, and new items are added to the [ItemsSource](itemscontrol_itemssource.md).

For example, if a user scrolls down a list of emails, and the [ItemsSource](itemscontrol_itemssource.md) updates, adding a new email to the top of the list: 
+ If ItemsUpdatingScrollMode is **KeepItemsInView**, then the scroll offset is adjusted to keep the first visible item showing at the top of the view.
+ If ItemsUpdatingScrollMode is **KeepScrollOffset**, then the scroll offset relative to the top of the list is maintained. As a result, the items on the screen are pushed down to account for the new item added at the top.


In other cases, like in a chat app, items are added to the bottom of the list. In this case, you can set ItemsUpdatingScrollMode to **KeepLastItemInView**. This adjusts the scroll offset to keep the last visible item showing at the bottom of the view. (**KeepLastItemInView** is available starting with Windows 10, version 1607.)

> [!TIP]
> In Windows 8, the [ListView](listview.md) control uses [VirtualizingStackPanel](virtualizingstackpanel.md) as its default [ItemsPanel](itemscontrol_itemspanel.md); in Windows 8.1, the [ListView](listview.md) control uses [ItemsStackPanel](itemsstackpanel.md) as its default [ItemsPanel](itemscontrol_itemspanel.md). When upgrading a [ListView](listview.md) in a Windows 8 app to use [ItemsStackPanel](itemsstackpanel.md), set the ItemsUpdatingScrollMode property to [KeepScrollOffset](itemsupdatingscrollmode.md) if you need to keep the behavior of the Windows 8  [ListView](listview.md).

## -examples

## -see-also
