---
-api-id: T:Windows.UI.Xaml.Controls.ListViewBase
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewBase : Windows.UI.Xaml.Controls.Primitives.Selector, Windows.UI.Xaml.Controls.IListViewBase, Windows.UI.Xaml.Controls.IListViewBase2, Windows.UI.Xaml.Controls.IListViewBase3, Windows.UI.Xaml.Controls.IListViewBase4, Windows.UI.Xaml.Controls.IListViewBase5, Windows.UI.Xaml.Controls.ISemanticZoomInformation
-->

# Windows.UI.Xaml.Controls.ListViewBase

## -description

Provides the infrastructure for the [ListView](listview.md) and [GridView](gridview.md) classes.



## -remarks

For user interface purposes, ListViewBase should be thought of as an abstract base class. Use [ListView](listview.md) or [GridView](gridview.md) instead. The main difference between [ListView](listview.md) and [GridView](gridview.md) is that [ListView](listview.md) has a vertical/portrait orientation and [GridView](gridview.md) has a horizontal/landscape orientation. For more info, see [ListView and GridView controls](/windows/uwp/controls-and-patterns/listview-and-gridview).

### **ListViewBase** derived classes

ListViewBase is the parent class for [GridView](gridview.md) and [ListView](listview.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | IsDragSource |
| 1607 | 14393 | SingleSelectionFollowsFocus |
| 1703 | 15063 | PrepareConnectedAnimation |
| 1703 | 15063 | TryStartConnectedAnimationAsync |

## -examples

## -see-also

[Selector](../windows.ui.xaml.controls.primitives/selector.md), [ListView](listview.md), [GridView](gridview.md), [ISemanticZoomInformation](isemanticzoominformation.md), [ListView and GridView controls](/windows/uwp/controls-and-patterns/listview-and-gridview), [Drag and drop sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlDragAndDrop)
