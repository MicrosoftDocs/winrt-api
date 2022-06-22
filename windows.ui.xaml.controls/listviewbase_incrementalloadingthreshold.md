---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.IncrementalLoadingThreshold
-api-type: winrt property
---

<!-- Property syntax
public double IncrementalLoadingThreshold { get;  set; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.IncrementalLoadingThreshold

## -description
Gets or sets the threshold range that governs when the [ListViewBase](listviewbase.md) class will begin to prefetch more items.



## -xaml-syntax
```xaml
<listViewBase IncrementalLoadingThreshold="double" />
```


## -property-value
The loading threshold, in terms of pages.

## -remarks
The meaning of the page count given for IncrementalLoadingThreshold is that the [ListViewBase](listviewbase.md) does not need to request more items via [LoadMoreItemsAsync](listviewbase_loadmoreitemsasync_1264491126.md) until the trigger condition (see [IncrementalLoadingTrigger](listviewbase_incrementalloadingtrigger.md)) gets within the IncrementalLoadingThreshold page range. Setting a larger number (for instance 10 or more) represents a belief that the user might attempt to scroll through the list very quickly, and it is worthwhile devoting resources to loading more items as quickly as possible. Setting a smaller number (for instance 5 or less) represents a belief that the user will scroll through the list less quickly, and that the user's scroll rate will permit the items collection to catch up without being as resource intensive.

IncrementalLoadingThreshold and [DataFetchSize](listviewbase_datafetchsize.md) both contribute to the possible resource load that is the result of prefetch operations.

## -examples

## -see-also
[DataFetchSize](listviewbase_datafetchsize.md), [IncrementalLoadingTrigger](incrementalloadingtrigger.md), [LoadMoreItemsAsync](listviewbase_loadmoreitemsasync_1264491126.md), [Using virtualization with a list or grid](/previous-versions/windows/apps/hh780657(v=win.10))
