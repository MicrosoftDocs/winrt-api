---
-api-id: T:Windows.UI.Xaml.Controls.ListView
-api-type: winrt class
---

<!-- Class syntax.
public class ListView : Windows.UI.Xaml.Controls.ListViewBase, Windows.UI.Xaml.Controls.IListView
-->

# Windows.UI.Xaml.Controls.ListView

## -description

Represents a control that displays data items in a vertical stack.


## -xaml-syntax

```xaml
<ListView .../>
-or-
<ListView ...>
  oneOrMoreItems
</ListView>
```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [List view and grid view](/windows/uwp/design/controls-and-patterns/listview-and-gridview).

Use a ListView to display a collection of items stacked vertically or horizontally. To display a collection in rows and columns, use a [GridView](gridview.md).

<img alt="List view control" src="images/controls/ListViewBasic.png" />

ListView is an [ItemsControl](itemscontrol.md), so it can contain a collection of items of any type. To populate the view, add items to the [Items](itemscontrol_items.md) collection, or set the [ItemsSource](itemscontrol_itemssource.md) property to a data source.

By default, a data item is displayed in the ListView as the string representation of the data object it's bound to. To specify exactly how items in the ListView are displayed, you create a [DataTemplate](../windows.ui.xaml/datatemplate.md) to define the layout of controls used to display an individual item. The controls in the layout can be bound to properties of a data object, or have content defined inline. You assign the [DataTemplate](../windows.ui.xaml/datatemplate.md) to the [ItemTemplate](itemscontrol_itemtemplate.md) property of the ListView. For common templates you can use in your app, see [Item templates for ListView](/windows/uwp/controls-and-patterns/item-templates-listview).

> [!NOTE]
> If you populate the ListView by setting the [ItemsSource](itemscontrol_itemssource.md) property, the [ItemTemplate](itemscontrol_itemtemplate.md) is applied to every item. If you populate the [Items](itemscontrol_items.md) collection directly, the [ItemTemplate](itemscontrol_itemtemplate.md) is applied only if the item is not a [ListViewItem](listviewitem.md). See Examples for more info.

If you use the ListView to display large sets of data, see [Optimize ListView and GridView](/windows/uwp/debug-test-perf/optimize-gridview-and-listview) for tips to maintain a smooth and responsive user experience.

> <div id="main">
> <strong>Windows 10, version 1709 (SDK 16299) - Behavior change</strong>
> </div>
> By default, instead of performing selection, an active pen now scrolls/pans a list in UWP apps (like touch, touchpad, and passive pen).
> If your app depends on the previous behavior, you can override pen scrolling and revert to the previous behavior. See [ScrollViewer](scrollviewer.md) for details.

By default, a user can select a single item in a ListView. You can set the [SelectionMode](listviewbase_selectionmode.md) property to a [ListViewSelectionMode](listviewselectionmode.md) enumeration value to allow multi-selection or to disable selection. You can also change the ListView interaction mode to make items respond to a user click like a button instead of being selected.

This table shows the ways a user can interact with a ListView, and how you can respond to the interaction.

| To enable this interaction: | Use these settings: | Handle this event: | Use this property to get the selected item: |
| - | - | - | - |
| No interaction | [SelectionMode](listviewbase_selectionmode.md) = [None](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | N/A | N/A |
| Single selection | [SelectionMode](listviewbase_selectionmode.md) = [Single](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | [SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md) | [SelectedItem](../windows.ui.xaml.controls.primitives/selector_selecteditem.md), [SelectedIndex](../windows.ui.xaml.controls.primitives/selector_selectedindex.md) |
| Contiguous multi-selection | [SelectionMode](listviewbase_selectionmode.md) = [Multiple](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | [SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md) | [SelectedItems](listviewbase_selecteditems.md) |
| Non-contiguous multi-selection | [SelectionMode](listviewbase_selectionmode.md) = [Extended](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | [SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md) | [SelectedItems](listviewbase_selecteditems.md) |
| Click | [SelectionMode](listviewbase_selectionmode.md) = [None](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **True** | [ItemClick](listviewbase_itemclick.md) | N/A |

> [!NOTE]
> The [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event does not bubble up from a ListView. This means that a control that has a ListView inside of it does not receive mouse wheel change messages if the pointer is over the ListView. For example, if you put a ListView inside of a [ScrollViewer](scrollviewer.md), you can't scroll the [ScrollViewer](scrollviewer.md) with the mouse wheel when the pointer is over the ListView.

ListView supports data virtualization to improve performance with large data sets. Random access virtualization is supported when the data source implements the appropriate interfaces, which vary depending on the programming language:

+ Visual C++ component extensions (C++/CX) apps should implement [IObservableVector](../windows.foundation.collections/iobservablevector_1.md).
+ C# or Visual Basic apps should implement [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true) and [System.Collections.IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) (not [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)). Virtualization requires both of these interfaces.
 Incremental loading virtualization is supported when the data source implements the [ISupportIncrementalLoading](../windows.ui.xaml.data/isupportincrementalloading.md) interface. When incremental loading is supported, you can use these members to control data loading: [DataFetchSize](listviewbase_datafetchsize.md), [IncrementalLoadingThreshold](listviewbase_incrementalloadingthreshold.md), [IncrementalLoadingTrigger](listviewbase_incrementalloadingtrigger.md), [LoadMoreItemsAsync](listviewbase_loadmoreitemsasync_1264491126.md).

> **Windows 8**
> In Windows 8, when the data item in a selected [ListViewItem](listviewitem.md) is replaced, the [SelectedIndex](../windows.ui.xaml.controls.primitives/selector_selectedindex.md) value is not cleared. In Windows 8.1 or later, the [SelectedIndex](../windows.ui.xaml.controls.primitives/selector_selectedindex.md) value is cleared.

ListView implements the [ISemanticZoomInformation](isemanticzoominformation.md) interface, so it can be used as a view in a [SemanticZoom](semanticzoom.md) control. When it's used in a [SemanticZoom](semanticzoom.md) control, always set the [ScrollViewer.IsVerticalScrollChainingEnabled](scrollviewer_isverticalscrollchainingenabled.md) attached property to **false** on the [ScrollViewer](scrollviewer.md) that's in the ListView's control template, like this: `<ListView ScrollViewer.IsVerticalScrollChainingEnabled="False">`. These members have an effect only when the ListView is hosted in a [SemanticZoom](semanticzoom.md) control: [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChange](listviewbase_completeviewchange_1917507883.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom_788425485.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto_41306206.md), [InitializeViewChange](listviewbase_initializeviewchange_1165335344.md), [MakeVisible](listviewbase_makevisible_1148837317.md), [StartViewChangeFrom](listviewbase_startviewchangefrom_1386295791.md), [StartViewChangeTo](listviewbase_startviewchangeto_1504058226.md).

If you need to handle pointer events for a [UIElement](../windows.ui.xaml/uielement.md) in a scrollable view (such as a ScrollViewer), you must explicitly disable support for manipulation events on the element in the view by calling [UIElement.CancelDirectmanipulation()](../windows.ui.xaml/uielement_canceldirectmanipulations_1164631120.md). To re-enable manipulation events in the view, call [UIElement.TryStartDirectManipulation()](../windows.ui.xaml/uielement_trystartdirectmanipulation_1983346775.md).

### Selection behavior and CollectionViewSource

List controls that derive from [Selector](../windows.ui.xaml.controls.primitives/selector.md) have a default selection behavior that depends on what the items source is (the type that's used for [ItemsSource](itemscontrol_itemssource.md)). If the items source is a [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) instance, then the behavior in the selection control is that the selection will default to the current item. When the list is first displayed, the selection defaults to the first item as current item. If you don't want the first item to be selected in this case, set [IsSynchronizedWithCurrentItem](../windows.ui.xaml.controls.primitives/selector_issynchronizedwithcurrentitem.md) to **false** in the ListView.

### Visual updates in WinUI 2.6
In [WinUI 2.6](/windows/apps/winui/winui2/release-notes/), new APIs and styles were added to update the visuals and design of ListView. These updated visuals include rounded corners, a selection indicator, and more. 

If you'd like to use these new styles, first ensure that you're using WinUI 2.6 in your app. To get set up with WinUI 2, see [Getting started with the Windows UI 2.x Library](/windows/apps/winui/winui2/getting-started). 


You can always modify the look of a ListView by specifying Xaml resources in your app. A new resource that is available in WinUI 2.6 is `ListViewItemCornerRadius`, which controls the level of rounding on ListViewItem corners. By default, this theme resource is set to 4px. 


## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [List View](/windows/apps/design/controls/listview-and-gridview).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see ListView in action](winui2gallery:/item/ListView)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

In this example, the [ItemTemplate](itemscontrol_itemtemplate.md) of a ListView is defined inline. Because the [ItemsSource](itemscontrol_itemssource.md) is set, the [ItemTemplate](itemscontrol_itemtemplate.md) is applied to every item.

[!code-xaml[ListViewItemTemplate](../windows.ui.xaml.controls/code/ListAndGridViewSnippets/csharp/MainPage.xaml#SnippetListViewItemTemplate)]

```xaml
<ListView>
    <ListView.ItemTemplate>
        <DataTemplate>
            <Grid>
                <Border Background="LightGray" Height="200" Width="200">
                    <TextBlock Text="{Binding}" 
                               FontSize="48" Foreground="Green"/>
                </Border>
            </Grid>
        </DataTemplate>
    </ListView.ItemTemplate>
    <ListView.Items>
        <x:String>One</x:String>
        <ListViewItem>Two</ListViewItem>
    </ListView.Items>
</ListView>
```

In the following example, the corners of items in every ListView throughout the app are rounded to 5px.

```xml
<Application.Resources>
    <CornerRadius x:Key="ListViewItemCornerRadius">5</CornerRadius>
</Application.Resources>
```

## -see-also

[Lists overview](/windows/uwp/controls-and-patterns/lists), [ListViewBase](listviewbase.md), [Item templates for ListView](/windows/uwp/controls-and-patterns/item-templates-listview), [Data binding overview](/windows/uwp/data-binding/data-binding-quickstart), [ListView and GridView sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619900), [Navigation menu (XAML) sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619902)
