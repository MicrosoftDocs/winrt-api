---
-api-id: T:Windows.UI.Xaml.Interop.IBindableIterator
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IBindableIterator : 
-->

# Windows.UI.Xaml.Interop.IBindableIterator

## -description
Supports bindable iteration over a collection.

Equivalent WinUI interface: [Microsoft.UI.Xaml.Interop.IBindableIterator](/windows/winui/api/microsoft.ui.xaml.interop.ibindableiterator).

## -remarks
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) or implement [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true). For more info, see [Binding to collections](/windows/uwp/data-binding/data-binding-quickstart).

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
