---
-api-id: M:Windows.UI.Xaml.Interop.IBindableVectorView.IndexOf(System.Object,System.UInt32@)
-api-type: winrt method
---

<!-- Method syntax
public bool IndexOf(System.Object value, System.UInt32 index)
-->

# Windows.UI.Xaml.Interop.IBindableVectorView.IndexOf

## -description
Returns the index of a specified item in the vector.



## -parameters
### -param value
The item to find in the vector.

### -param index
The zero-based index of the item if found. 0 is returned if the item is not found, so be sure to check the return value.

## -returns
**true** if the item is found; **false** if the item is not found.

## -remarks
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) or implement [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
