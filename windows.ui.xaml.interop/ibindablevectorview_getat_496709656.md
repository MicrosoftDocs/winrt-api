---
-api-id: M:Windows.UI.Xaml.Interop.IBindableVectorView.GetAt(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public object GetAt(System.UInt32 index)
-->

# Windows.UI.Xaml.Interop.IBindableVectorView.GetAt

## -description
Returns the item at the specified index in the vector.



## -parameters
### -param index
The zero-based index of the item in the vector to return.

## -returns
The item at the specified index.

## -remarks
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) or implement [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
