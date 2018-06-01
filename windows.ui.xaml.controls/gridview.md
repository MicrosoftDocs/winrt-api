---
-api-id: T:Windows.UI.Xaml.Controls.GridView
-api-type: winrt class
---

<!-- Class syntax.
public class GridView : Windows.UI.Xaml.Controls.ListViewBase, Windows.UI.Xaml.Controls.IGridView
-->

# Windows.UI.Xaml.Controls.GridView

## -description

Represents a control that displays data items in rows and columns.

## -xaml-syntax

```xaml
<GridView .../>
-or-
<GridView ...>
  oneOrMoreItems
</GridView>
```

## -remarks

Use a **GridView** to display a collection of items in rows and columns that can scroll vertically. Data is stacked horizontally until it fills the columns, then continues with the next row. It's often used when you need to show a rich visualization of each item that takes more space, such as a photo gallery.

<img alt="Grid view control" src="images/controls/GridViewBasic.png" />

[GridView](gridview.md) is an [ItemsControl](itemscontrol.md), so it can contain a collection of items of any type. To populate the view, add items to the [Items](itemscontrol_items.md) collection, or set the [ItemsSource](itemscontrol_itemssource.md) property to a data source.

By default, a data item is displayed in the [GridView](gridview.md) as the string representation of the data object it's bound to. To specify exactly how items in the [GridView](gridview.md) are displayed, you create a [DataTemplate](../windows.ui.xaml/datatemplate.md) to define the layout of controls used to display an individual item. The controls in the layout can be bound to properties of a data object, or have content defined inline. You assign the [DataTemplate](../windows.ui.xaml/datatemplate.md) to the [ItemTemplate](itemscontrol_itemtemplate.md) property of the [GridView](gridview.md). For common templates you can use in your app, see [Item templates for GridView](https://docs.microsoft.com/windows/uwp/controls-and-patterns/item-templates-gridview).

> [!NOTE]
> If you populate the [GridView](gridview.md) by setting the [ItemsSource](itemscontrol_itemssource.md) property, the [ItemTemplate](itemscontrol_itemtemplate.md) is applied to every item. If you populate the [Items](itemscontrol_items.md) collection directly, the [ItemTemplate](itemscontrol_itemtemplate.md) is applied only if the item is not a [GridViewItem](gridviewitem.md). See Examples for more info.

If you use the [GridView](gridview.md) to display large sets of data, see [Optimize ListView and GridView](http://msdn.microsoft.com/library/26df15e8-2c05-4174-a714-7df2e8273d32) for tips to maintain a smooth and responsive user experience.

> <div id="main">
> <strong>Fall Creators Update (Windows 10) - Behavior change</strong>
> </div>
> By default, instead of performing selection, an active pen now scrolls/pans a list in UWP apps (like touch, touchpad, and passive pen).
> If your app depends on the previous behavior, you can override pen scrolling and revert to the previous behavior. See the [Scroll​Viewer](scrollviewer.md) class reference for details.

By default, a user can select a single item in a [GridView](gridview.md). You can set the [SelectionMode](listviewbase_selectionmode.md) property to a [ListViewSelectionMode](listviewselectionmode.md) enumeration value to allow multi-selection or to disable selection. You can also change the [GridView](gridview.md) interaction mode to make items respond to a user click like a button instead of being selected.

This table shows the ways a user can interact with a [GridView](gridview.md), and how you can respond to the interaction.<table>
   <tr><th>To enable this interaction:</th><th>Use these settings:</th><th>Handle this event:</th><th>Use this property to get the selected item:</th></tr>
   <tr><td>No interaction</td><td>[SelectionMode](listviewbase_selectionmode.md) = [None](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False**</td><td>N/A</td><td>N/A</td></tr>
   <tr><td>Single selection</td><td>[SelectionMode](listviewbase_selectionmode.md) = [Single](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False**</td><td>[SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md)</td><td>[SelectedItem](../windows.ui.xaml.controls.primitives/selector_selecteditem.md), [SelectedIndex](../windows.ui.xaml.controls.primitives/selector_selectedindex.md)</td></tr>
   <tr><td>Contiguous multi-selection</td><td>[SelectionMode](listviewbase_selectionmode.md) = [Multiple](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False**</td><td>[SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md)</td><td>[SelectedItems](listviewbase_selecteditems.md)</td></tr>
   <tr><td>Non-contiguous multi-selection</td><td>[SelectionMode](listviewbase_selectionmode.md) = [Extended](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False**</td><td>[SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md)</td><td>[SelectedItems](listviewbase_selecteditems.md)</td></tr>
   <tr><td>Click</td><td>[SelectionMode](listviewbase_selectionmode.md) = [None](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **True**</td><td>[ItemClick](listviewbase_itemclick.md)</td><td>N/A</td></tr>
</table>

> [!NOTE]
> The [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event does not bubble up from a [GridView](gridview.md). This means that a control that has a [GridView](gridview.md) inside of it does not receive mouse wheel change messages if the pointer is over the [GridView](gridview.md). For example, if you put a [GridView](gridview.md) inside of a [ScrollViewer](scrollviewer.md), you can't scroll the [ScrollViewer](scrollviewer.md) with the mouse wheel when the pointer is over the [GridView](gridview.md).

> [!NOTE]
> When you set the [Padding](control_padding.md) property on a [GridView](gridview.md) control, the value for **right** padding is ignored; only the values for left, top, and bottom padding are applied.

[GridView](gridview.md) supports data virtualization to improve performance with large data sets. Random access virtualization is supported when the data source implements the appropriate interfaces, which vary depending on the programming language:

+ Visual C++ component extensions (C++/CX) apps should implement [IObservableVector](../windows.foundation.collections/iobservablevector_1.md).
+ C# or Visual Basic apps should implement [INotifyCollectionChanged](https://msdn.microsoft.com/library/system.collections.specialized.inotifycollectionchanged.aspx) and [System.Collections.IList](https://msdn.microsoft.com/library/system.collections.ilist.aspx) (not [IList<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1). Virtualization requires both of these interfaces.
 Incremental loading virtualization is supported when the data source implements the [ISupportIncrementalLoading](../windows.ui.xaml.data/isupportincrementalloading.md) interface. When incremental loading is supported, you can use these members to control data loading: [DataFetchSize](listviewbase_datafetchsize.md), [IncrementalLoadingThreshold](listviewbase_incrementalloadingthreshold.md), [IncrementalLoadingTrigger](listviewbase_incrementalloadingtrigger.md), [LoadMoreItemsAsync](listviewbase_loadmoreitemsasync.md).

> **Windows 8**
> In Windows 8, when the data item in a selected [GridViewItem](gridviewitem.md) is replaced, the [SelectedIndex](../windows.ui.xaml.controls.primitives/selector_selectedindex.md) value is not cleared. In Windows 8.1, the [SelectedIndex](../windows.ui.xaml.controls.primitives/selector_selectedindex.md) value is cleared.

[GridView](gridview.md) implements the [ISemanticZoomInformation](isemanticzoominformation.md) interface, so it can be used as a view in a [SemanticZoom](semanticzoom.md) control. When it's used in a [SemanticZoom](semanticzoom.md) control, always set the [ScrollViewer.IsHorizontalScrollChainingEnabled](scrollviewer_ishorizontalscrollchainingenabled.md) attached property to **false** on the [ScrollViewer](scrollviewer.md) that's in the [GridView](gridview.md) 's control template, like this: `<GridView ScrollViewer.IsHorizontalScrollChainingEnabled="False">`. These members have an effect only when the [GridView](gridview.md) is hosted in a [SemanticZoom](semanticzoom.md) control: [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChange](listviewbase_completeviewchange.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto.md), [InitializeViewChange](listviewbase_initializeviewchange.md), [MakeVisible](listviewbase_makevisible.md), [StartViewChangeFrom](listviewbase_startviewchangefrom.md), [StartViewChangeTo](listviewbase_startviewchangeto.md).

The default template for [GridView](gridview.md) includes existing transition animations. Specifically, the default [ItemContainerTransitions](itemscontrol_itemcontainertransitions.md) value already contains values for [AddDeleteThemeTransition](../windows.ui.xaml.media.animation/adddeletethemetransition.md), [ContentThemeTransition](../windows.ui.xaml.media.animation/contentthemetransition.md), [ReorderThemeTransition](../windows.ui.xaml.media.animation/reorderthemetransition.md) and [EntranceThemeTransition](../windows.ui.xaml.media.animation/entrancethemetransition.md) (with `IsStaggeringEnabled="False"`). If you are setting a new value for [ItemContainerTransitions](itemscontrol_itemcontainertransitions.md) on [GridView](gridview.md), consider reproducing these same theme animations as a starting point. If you are setting the property yourself, those defaults get overwritten unless you include them again in your definition.

### Selection behavior and CollectionViewSource

List controls that derive from [Selector](../windows.ui.xaml.controls.primitives/selector.md) have a default selection behavior that depends on what the items source is (the type that's used for [ItemsSource](itemscontrol_itemssource.md)). If the items source is a [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) instance, then the behavior in the selection control is that the selection will default to the current item. When the list is first displayed, the selection defaults to the first item as current item. If you don't want the first item to be selected in this case, set [IsSynchronizedWithCurrentItem](../windows.ui.xaml.controls.primitives/selector_issynchronizedwithcurrentitem.md) to **false** in the [GridView](gridview.md).

## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to open the app and see the <a href="xamlcontrolsgallery:/item/GridView">GridView</a> in action.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

Here, a [GridView](gridview.md) is bound to a grouped [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) named `cvsProjects`. The appearance of individual items in each group is defined by the [ItemTemplate](itemscontrol_itemtemplate.md). The [ItemsPanel](itemscontrol_itemspanel.md) specifies how the groups are arranged in the [GridView](gridview.md). The [GroupStyle.Panel](groupstyle_panel.md) specifies how individual items are arranged within each group. The [GroupStyle.ContainerStyle](groupstyle_containerstyle.md) is used to add a border around each group, and set its minimum size and margins. The [HidesIfEmpty](groupstyle_hidesifempty.md) property is set to **true** to hide any empty groups.

[!code-xml[GroupedGridViewXAML](../windows.ui.xaml.controls/code/ItemsControlGroupingSnippets/csharp/MainPage.xaml#SnippetGroupedGridViewXAML)]

```xaml
<GridView>
    <GridView.ItemTemplate>
        <DataTemplate>
            <Grid>
                <Border Background="LightGray" Height="200" Width="200">
                    <TextBlock Text="{Binding}" 
                               FontSize="48" Foreground="Green"/>
                </Border>
            </Grid>
        </DataTemplate>
    </GridView.ItemTemplate>
    <GridView.Items>
        <x:String>One</x:String>
        <GridViewItem>Two</GridViewItem>
    </GridView.Items>
</GridView>
```

## -see-also
[List view and grid view](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/listview-and-gridview), [ListViewBase](listviewbase.md), [ISemanticZoomInformation](isemanticzoominformation.md), [GridView styles and templates](http://msdn.microsoft.com/library/3ea83c39-3300-4c3c-89b3-24d4777c7067), [Item templates for GridView](https://docs.microsoft.com/windows/uwp/controls-and-patterns/item-templates-gridview), [Data binding overview](http://msdn.microsoft.com/library/a9d54dec-cd1b-4043-ade4-32cd4977d1bf), [ListView](listview.md), [SemanticZoom](semanticzoom.md), [ListView and GridView sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlListView)