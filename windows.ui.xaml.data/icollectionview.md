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
ICollectionView is an interface used to represent a collection. It serves to maintain currency for properties like item selection.

To implement custom behavior for selection currency in your data source, your data source should implement [ICollectionViewFactory](icollectionviewfactory.md) instead of implementing ICollectionView directly. You can set the [CollectionViewSource.Source](collectionviewsource_source.md) property to an [ICollectionViewFactory](icollectionviewfactory.md), but if you set it to an ICollectionView, it will throw an exception.

The [CollectionGroups](icollectionview_collectiongroups.md) property is of type [IObservableVector<object>](../windows.foundation.collections/iobservablevector_1.md), but these objects should implement [ICollectionViewGroup](icollectionviewgroup.md).

### Interface inheritance

ICollectionView inherits [IObservableVector](../windows.foundation.collections/iobservablevector_1.md), [IVector](../windows.foundation.collections/ivector_1.md) and [IIterable](../windows.foundation.collections/iiterable_1.md) . Types that implement ICollectionView also implement the interface members of [IObservableVector](../windows.foundation.collections/iobservablevector_1.md), and either [IVector](../windows.foundation.collections/ivector_1.md) and [IIterable](../windows.foundation.collections/iiterable_1.md) for C++ usage or [IList](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)and [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET usage.

## -examples

## -see-also
[IObservableVector&lt;T&gt;](../windows.foundation.collections/iobservablevector_1.md), [IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [CollectionViewSource](collectionviewsource.md), [Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
