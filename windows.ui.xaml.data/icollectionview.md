---
-api-id: T:Windows.UI.Xaml.Data.ICollectionView
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ICollectionView : Windows.Foundation.Collections.IIterable<System.Object>, Windows.Foundation.Collections.IObservableVector<System.Object>, Windows.Foundation.Collections.IVector<System.Object>
-->

# Windows.UI.Xaml.Data.ICollectionView

## -description
Enables collections to support current record management, grouping, and incremental loading (data virtualization).

## -remarks
[ICollectionView](icollectionview.md) is an interface used to represent a collection. It serves to maintain currency for properties like item selection.

To implement custom behavior for selection currency in your data source, your data source should implement [ICollectionViewFactory](icollectionviewfactory.md) instead of implementing [ICollectionView](icollectionview.md) directly. You can set the [CollectionViewSource.Source](collectionviewsource_source.md) property to an [ICollectionViewFactory](icollectionviewfactory.md), but if you set it to an [ICollectionView](icollectionview.md), it will throw an exception.

The [CollectionGroups](icollectionview_collectiongroups.md) property is of type [IObservableVector&lt;object&gt;](../windows.foundation.collections/iobservablevector_1.md), but these objects should implement [ICollectionViewGroup](icollectionviewgroup.md).

### Interface inheritance

[ICollectionView](icollectionview.md) inherits [IObservableVector](../windows.foundation.collections/iobservablevector_1.md), [IVector](../windows.foundation.collections/ivector_1.md) and [IIterable](../windows.foundation.collections/iiterable_1.md) . Types that implement [ICollectionView](icollectionview.md) also implement the interface members of [IObservableVector](../windows.foundation.collections/iobservablevector_1.md), and either [IVector](../windows.foundation.collections/ivector_1.md) and [IIterable](../windows.foundation.collections/iiterable_1.md) for C++ usage or [IList](XREF:TODO:T:System.Collections.Generic.IList`1) and [IEnumerable](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) for Microsoft .NET usage.

## -examples

## -see-also
[IObservableVector&lt;T&gt;](../windows.foundation.collections/iobservablevector_1.md), [IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [CollectionViewSource](collectionviewsource.md), [Binding](binding.md), [XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854), [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)