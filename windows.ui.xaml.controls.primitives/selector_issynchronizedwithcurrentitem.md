---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.Selector.IsSynchronizedWithCurrentItem
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<bool> IsSynchronizedWithCurrentItem { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.Selector.IsSynchronizedWithCurrentItem

## -description
Gets or sets a value that indicates whether a [Selector](selector.md) should keep the [SelectedItem](selector_selecteditem.md) synchronized with the current item in the [Items](../windows.ui.xaml.controls/itemscontrol_items.md) property.



## -xaml-syntax
```xaml
<selector IsSynchronizedWithCurrentItem="bool"/>
- or -
<selector IsSynchronizedWithCurrentItem="{x:Null}"/>
```


## -property-value
**true** if the [SelectedItem](selector_selecteditem.md) is always synchronized with the current item in the [ItemCollection](../windows.ui.xaml.controls/itemcollection.md); **false** if the [SelectedItem](selector_selecteditem.md) is never synchronized with the current item; **null** if the [SelectedItem](selector_selecteditem.md) is synchronized with the current item only if the [Selector](selector.md) uses an [ICollectionView](../windows.ui.xaml.data/icollectionview.md). The default value is **null**/indeterminate.

<!--Projection dochack:-->
If you are programming using C#or Microsoft Visual Basic, the type of this property is projected as **bool?**(a nullable [Boolean](/dotnet/api/system.boolean?view=dotnet-uwp-10.0&preserve-view=true)).

## -remarks
The nullable value for IsSynchronizedWithCurrentItem enables the value to be indeterminate, neither **true** nor **false**. This is indicated by a value of **null** if accessed in code. To set the value to **null** in XAML, use the [{x:Null} markup extension](/windows/uwp/xaml-platform/x-null-markup-extension).

### Selection behavior and CollectionViewSource

List controls that derive from [Selector](selector.md) have a default selection behavior that depends on what the items source is (the type that's used for [ItemsSource](../windows.ui.xaml.controls/itemscontrol_itemssource.md)). If the items source is a [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) instance, then the behavior in the selection control is that the selection will default to the current item. When the list is first displayed, the selection defaults to the first item as current item. If you don't want the first item to be selected in this case, set IsSynchronizedWithCurrentItem to **false** in the [GridView](../windows.ui.xaml.controls/gridview.md), the [ListView](../windows.ui.xaml.controls/listview.md), or other [Selector](selector.md)-based control that is showing the selection.

## -examples

## -see-also
[Nullable](/dotnet/api/system.nullable-1?view=dotnet-uwp-10.0&preserve-view=true), [{x:Null} markup extension](/windows/uwp/xaml-platform/x-null-markup-extension)
