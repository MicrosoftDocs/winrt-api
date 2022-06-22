---
-api-id: T:Windows.UI.Xaml.Interop.IBindableVectorView
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IBindableVectorView : Windows.UI.Xaml.Interop.IBindableIterable
-->

# Windows.UI.Xaml.Interop.IBindableVectorView

## -description
Represents a read-only vector collection of objects that is bindable.



## -remarks
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) or implement [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true). For more info, see [Binding to collections](/windows/uwp/data-binding/data-binding-quickstart).

### Interface inheritance

IBindableVectorView inherits [IBindableIterable](ibindableiterable.md). Types that implement IBindableVectorView also implement the interface members of [IBindableIterable](ibindableiterable.md) for C++ usage.

## -examples

## -see-also
[IBindableIterable](ibindableiterable.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
