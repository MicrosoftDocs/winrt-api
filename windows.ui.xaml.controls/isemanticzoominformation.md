---
-api-id: T:Windows.UI.Xaml.Controls.ISemanticZoomInformation
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ISemanticZoomInformation : 
-->

# Windows.UI.Xaml.Controls.ISemanticZoomInformation

## -description
Communicates the info needed for a view to serve as one of the two possible views ([ZoomedOutView](semanticzoom_zoomedoutview.md) or [ZoomedInView](semanticzoom_zoomedinview.md)) of a [SemanticZoom](semanticzoom.md).



## -remarks
The ISemanticZoomInformation interface provides info for a single view of a [SemanticZoom](semanticzoom.md) control. However, it doesn't provide info to synchronize the two views of a [SemanticZoom](semanticzoom.md). The [ZoomedInView](semanticzoom_zoomedinview.md) and [ZoomedOutView](semanticzoom_zoomedoutview.md) should be synchronized, so if a user selects a group in the [ZoomedOutView](semanticzoom_zoomedoutview.md), the details of that group are shown in the [ZoomedInView](semanticzoom_zoomedinview.md). You can use a [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) or add code to synchronize the views. Any controls that you bind to the same [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) will always have the same current item. If both views use the same [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) as the their data source, the [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md) will synchronize the views automatically. Otherwise, you can handle the [SemanticZoom.ViewChangeStarted](semanticzoom_viewchangestarted.md) event and synchronize the items in the event handler. See [SemanticZoom](semanticzoom.md) for more info.



## -examples

## -see-also
[SemanticZoom](semanticzoom.md), [GridView](gridview.md), [ListView](listview.md), [Hub](hub.md)
