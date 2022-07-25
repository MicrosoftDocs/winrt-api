---
-api-id: M:Windows.UI.Xaml.Interop.IBindableIterator.MoveNext
-api-type: winrt method
---

<!-- Method syntax
public bool MoveNext()
-->

# Windows.UI.Xaml.Interop.IBindableIterator.MoveNext

## -description
Moves the iterator forward to the next item and returns [HasCurrent](ibindableiterator_hascurrent.md).



## -returns
**true** if the iterator refers to a valid item that is in the collection; otherwise, **false**.

## -remarks
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) or implement [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
