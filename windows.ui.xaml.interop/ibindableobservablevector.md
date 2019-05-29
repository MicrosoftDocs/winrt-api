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
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1) or implement [IList](https://docs.microsoft.com/dotnet/api/system.collections.ilist?redirectedfrom=MSDN) and [INotifyCollectionChanged](https://docs.microsoft.com/dotnet/api/system.collections.specialized.inotifycollectionchanged?redirectedfrom=MSDN). For more info, see [Binding to collections](https://docs.microsoft.com/windows/uwp/data-binding/data-binding-quickstart).

### Interface inheritance

IBindableObservableVector inherits [IBindableVector](ibindablevector.md) and [IBindableIterable](ibindableiterable.md). Types that implement IBindableObservableVector also implement the interface members of [IBindableVector](ibindablevector.md) and [IBindableIterable](ibindableiterable.md) for C++ usage, or [IList](https://docs.microsoft.com/dotnet/api/system.collections.ilist?redirectedfrom=MSDN) and [IEnumerable](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable?redirectedfrom=MSDN) for Microsoft .NET usage.

## -examples

## -see-also
[IBindableVector](ibindablevector.md), [IBindableIterable](ibindableiterable.md), [XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854)
