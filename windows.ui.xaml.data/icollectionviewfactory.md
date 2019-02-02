---
-api-id: T:Windows.UI.Xaml.Data.ICollectionViewFactory
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ICollectionViewFactory : 
-->

# Windows.UI.Xaml.Data.ICollectionViewFactory

## -description
Supports creation of the relevant [ICollectionView](icollectionview.md) implementation.

## -remarks
The [CreateView](icollectionviewfactory_createview_164792513.md) method is called when you set the [CollectionViewSource.Source](collectionviewsource_source.md) property to an [ICollectionViewFactory](icollectionviewfactory.md) implementation. The returned [ICollectionView](icollectionview.md) implementation is used to manage sorting, filtering, grouping, and currency for the bound collection. When using the [CollectionViewSource](collectionviewsource.md) class, you can access the [View](collectionviewsource_view.md) property to retrieve the [ICollectionView](icollectionview.md) implementation.

## -examples

## -see-also
[CollectionViewSource](collectionviewsource.md), [Binding](binding.md), [XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854), [Data binding in depth](https://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)
