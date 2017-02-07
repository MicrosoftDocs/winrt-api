---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewItemPresenter : Windows.UI.Xaml.Controls.ContentPresenter, Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenter, Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenter2
-->

# Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter

## -description
Represents the visual elements of a [ListViewItem](../windows.ui.xaml.controls/listviewitem.md). When developing for Windows 10, use [ListViewItemPresenter](listviewitempresenter.md) instead of [GridViewItemPresenter](gridviewitempresenter.md) in your item container style, both for [ListView](../windows.ui.xaml.controls/listview.md) and for [GridView](../windows.ui.xaml.controls/gridview.md). If you edit a copy of the default item container styles then you will get the correct type.

## -xaml-syntax
```xaml
<ListViewItemPresenter .../>
```


## -remarks
The XAML usage shown is intended to be part of a XAML template or style for a [ListView](../windows.ui.xaml.controls/listview.md) control (or derived type) and its items. For more info, see [ListView](../windows.ui.xaml.controls/listview.md).

For a custom [ListViewItemPresenter](listviewitempresenter.md), use the name of your class as the string within the object element syntax for XAML. You'll probably have to map an **xmlns** definition with a prefix to refer to your class definition. For more info, see [XAML namespaces and namespace mapping](http://msdn.microsoft.com/library/a19dff78-e692-47ae-8221-ab5ea9470e8b).

## -examples

## -see-also
[ContentPresenter](../windows.ui.xaml.controls/contentpresenter.md)