---
-api-id: P:Windows.UI.Xaml.Data.CollectionViewSource.View
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Data.ICollectionView View { get; }
-->

# Windows.UI.Xaml.Data.CollectionViewSource.View

## -description
Gets the view object that is currently associated with this instance of [CollectionViewSource](collectionviewsource.md).

## -property-value
The view object that is currently associated with this instance of [CollectionViewSource](collectionviewsource.md).

## -remarks
This property is initialized when you set the [Source](collectionviewsource_source.md) property. At that time, a view is generated automatically unless the source collection implements [ICollectionViewFactory](icollectionviewfactory.md). Otherwise, the view is retrieved through the [CreateView](icollectionviewfactory_createview_164792513.md) method.

## -examples

## -see-also
[Binding](binding.md), [XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854), [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)