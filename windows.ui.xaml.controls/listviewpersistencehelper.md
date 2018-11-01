---
-api-id: T:Windows.UI.Xaml.Controls.ListViewPersistenceHelper
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewPersistenceHelper : Windows.UI.Xaml.Controls.IListViewPersistenceHelper
-->

# Windows.UI.Xaml.Controls.ListViewPersistenceHelper

## -description
Represents a helper class to save and retrieve the relative scroll position of the [ListView](listview.md).

## -remarks
If the [ItemsStackPanel.ItemsUpdatingScrollMode](itemsstackpanel_itemsupdatingscrollmode.md) property is set to **KeepItemsInView**, [ListViewPersistenceHelper](listviewpersistencehelper.md) attempts to restore the scroll position using the key of the first visible item. If [ItemsUpdatingScrollMode](itemsstackpanel_itemsupdatingscrollmode.md) is **KeepLastItemInView**, it attempts to restore the scroll position using the key of the last visible item.

## -examples
For a complete implementation, see the [Restore scroll position sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlListView/cs/Samples/RestoreScrollPositionSample) in the [ListView and GridView sample repository](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlListView).

## -see-also
+ [ListView Class](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.listview#Definition)
+ [ListView and GridView](https://docs.microsoft.com/windows/uwp/controls-and-patterns/listview-and-gridview)