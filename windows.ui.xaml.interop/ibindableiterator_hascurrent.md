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
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) or implement [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
