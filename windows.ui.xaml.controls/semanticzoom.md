---
-api-id: T:Windows.UI.Xaml.Controls.SemanticZoom
-api-type: winrt class
---

<!-- Class syntax.
public class SemanticZoom : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.ISemanticZoom
-->

# Windows.UI.Xaml.Controls.SemanticZoom

## -description
Represents a scrollable control that incorporates two views that have a semantic relationship. For example, the [ZoomedOutView](semanticzoom_zoomedoutview.md) might be an index of titles, and the [ZoomedInView](semanticzoom_zoomedinview.md) might include details and summaries for each of the title entries. Views can be changed using zoom or other interactions.


## -xaml-syntax
```xaml
<SemanticZoom ...>
  <SemanticZoom.ZoomedOutView>
    zoomedOutViewContent
  </SemanticZoom.ZoomedOutView>
  <SemanticZoom.ZoomedInView>
    zoomedInViewContent
  </SemanticZoom.ZoomedInView>
</SemanticZoom>

```


## -remarks
The SemanticZoom control enables the user to zoom between two different views of the same content so that they can quickly navigate through a large data set. The *zoomed-in* view is the main view of the content. You show the complete data set in this view. The *zoomed-out* view is a higher-level view of the same content. You typically show the group headers for a grouped data set in this view. For example, when viewing an address book, the user could zoom in on a letter and see the names associated with that letter.

To define the zoomed-in view and the zoomed-out view of the SemanticZoom control, you can use any two controls that implement the [ISemanticZoomInformation](isemanticzoominformation.md) interface. The Extensible Application Markup Language (XAML) framework provides several controls that implement this interface: [ListView](/previous-versions/windows/apps/br211837(v=win.10)), [GridView](gridview.md), and [Hub](hub.md). You set these controls to the [ZoomedInView](semanticzoom_zoomedinview.md) and [ZoomedOutView](semanticzoom_zoomedoutview.md) properties of the SemanticZoom.

The user can switch between views with touch using the pinch-in and pinch-out gestures. By default, the zoomed-in view also shows a button that the user can press to activate the zoomed-out view. You can hide the zoom-out button by setting the [IsZoomOutButtonEnabled](semanticzoom_iszoomoutbuttonenabled.md) property to **false**. You can switch between views programmatically by setting the [IsZoomedInViewActive](semanticzoom_iszoomedinviewactive.md) property.

The [ZoomedInView](semanticzoom_zoomedinview.md) and [ZoomedOutView](semanticzoom_zoomedoutview.md) should be synchronized, so if a user selects a group in the [ZoomedOutView](semanticzoom_zoomedoutview.md), the details of that group are shown in the [ZoomedInView](semanticzoom_zoomedinview.md). You can use a [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) or add code to synchronize the views. Any controls that you bind to the same [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) will always have the same current item. If both views use the same [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) as the their data source, the [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) will synchronize the views automatically. Otherwise, you can handle the [ViewChangeStarted](semanticzoom_viewchangestarted.md) event and synchronize the items in the event handler like this.



```csharp
private void SemanticZoom_ViewChangeStarted(object sender, SemanticZoomViewChangedEventArgs e)
{
    if (e.IsSourceZoomedInView == false)
    {
        e.DestinationItem.Item = e.SourceItem.Item;
    }
}
```

When you use a [GridView](gridview.md) in a SemanticZoom control, always set the [ScrollViewer.IsHorizontalScrollChainingEnabled](scrollviewer_ishorizontalscrollchainingenabled.md) attached property to **false** on the [ScrollViewer](scrollviewer.md) that's in the [GridView](gridview.md)'s control template, like this: `<GridView ScrollViewer.IsHorizontalScrollChainingEnabled="False">`. When you use a [ListView](listview.md) in a SemanticZoom control, always set the [ScrollViewer.IsVerticalScrollChainingEnabled](scrollviewer_isverticalscrollchainingenabled.md) attached property to **false**, like this: `<ListView ScrollViewer.IsVerticalScrollChainingEnabled="False">`.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Semantic zoom](/windows/apps/design/controls/semantic-zoom).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the SemanticZoom in action](winui2gallery:/item/SemanticZoom)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

## -see-also
[Control](control.md), [Semantic zoom overview](/windows/uwp/design/controls-and-patterns/semantic-zoom), [GridView](gridview.md), [Hub](hub.md), [ListView](listview.md),
