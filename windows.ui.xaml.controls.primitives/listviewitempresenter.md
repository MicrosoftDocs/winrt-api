---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewItemPresenter : Windows.UI.Xaml.Controls.ContentPresenter, Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenter, Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenter2
-->

# Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter

## -description
Represents the visual elements of a [ListViewItem](../windows.ui.xaml.controls/listviewitem.md). When developing for Windows 10, use ListViewItemPresenter instead of [GridViewItemPresenter](gridviewitempresenter.md) in your item container style, both for [ListView](../windows.ui.xaml.controls/listview.md) and for [GridView](../windows.ui.xaml.controls/gridview.md). If you edit a copy of the default item container styles then you will get the correct type.



## -xaml-syntax
```xaml
<ListViewItemPresenter .../>
```


## -remarks
The XAML usage shown is intended to be part of a XAML template or style for a [ListView](../windows.ui.xaml.controls/listview.md) control (or derived type) and its items. For more info, see [ListView](../windows.ui.xaml.controls/listview.md).

For a custom ListViewItemPresenter, use the name of your class as the string within the object element syntax for XAML. You'll probably have to map an **xmlns** definition with a prefix to refer to your class definition. For more info, see [XAML namespaces and namespace mapping](/windows/uwp/xaml-platform/xaml-namespaces-and-namespace-mapping).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | RevealBackground |
| 1709 | 16299 | RevealBackgroundShowsAboveContent |
| 1709 | 16299 | RevealBorderBrush |
| 1709 | 16299 | RevealBorderThickness |

## -examples

## -see-also
[ContentPresenter](../windows.ui.xaml.controls/contentpresenter.md)
