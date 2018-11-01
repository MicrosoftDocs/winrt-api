---
-api-id: P:Windows.UI.Xaml.Interop.IBindableIterator.HasCurrent
-api-type: winrt property
---

<!-- Property syntax
public bool HasCurrent { get; }
-->

# Windows.UI.Xaml.Interop.IBindableIterator.HasCurrent

## -description
Gets a value that indicates whether there is a current item or the iterator is at the end of the collection.

## -property-value
**true** if the iterator refers to a valid item that is in the collection; otherwise, **false**.

## -remarks
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1) or implement [IList](https://msdn.microsoft.com/library/system.collections.ilist.aspx) and [INotifyCollectionChanged](https://msdn.microsoft.com/library/system.collections.specialized.inotifycollectionchanged.aspx).

## -examples

## -see-also
[XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854)