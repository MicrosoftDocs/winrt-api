---
-api-id: M:Windows.UI.Xaml.Data.ICollectionViewFactory.CreateView
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Data.ICollectionView CreateView()
-->

# Windows.UI.Xaml.Data.ICollectionViewFactory.CreateView

## -description
Creates an [ICollectionView](icollectionview.md) instance using default settings.



## -returns
The default view.

## -remarks
This method is called when you set the [CollectionViewSource.Source](collectionviewsource_source.md) property to an [ICollectionViewFactory](icollectionviewfactory.md) implementation. The returned [ICollectionView](icollectionview.md) implementation is used to manage sorting, filtering, grouping, and currency for the bound collection. When using the [CollectionViewSource](collectionviewsource.md) class, you can access the [View](collectionviewsource_view.md) property to retrieve the [ICollectionView](icollectionview.md) implementation.

## -examples

## -see-also
