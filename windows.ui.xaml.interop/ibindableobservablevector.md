---
-api-id: T:Windows.UI.Xaml.Interop.IBindableObservableVector
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IBindableObservableVector : Windows.UI.Xaml.Interop.IBindableIterable, Windows.UI.Xaml.Interop.IBindableVector
-->

# Windows.UI.Xaml.Interop.IBindableObservableVector

## -description
Extends [IBindableVector](ibindablevector.md) by adding a [VectorChanged](ibindableobservablevector_vectorchanged.md) event for change notification.



## -remarks
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) or implement [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true). For more info, see [Binding to collections](/windows/uwp/data-binding/data-binding-quickstart).

### Interface inheritance

IBindableObservableVector inherits [IBindableVector](ibindablevector.md) and [IBindableIterable](ibindableiterable.md). Types that implement IBindableObservableVector also implement the interface members of [IBindableVector](ibindablevector.md) and [IBindableIterable](ibindableiterable.md) for C++ usage, or [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [IEnumerable](/dotnet/api/system.collections.ienumerable?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET usage.

## -examples

## -see-also
[IBindableVector](ibindablevector.md), [IBindableIterable](ibindableiterable.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
