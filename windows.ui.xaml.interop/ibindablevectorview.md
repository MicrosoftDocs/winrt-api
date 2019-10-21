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
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1) or implement [IList](https://docs.microsoft.com/dotnet/api/system.collections.ilist?redirectedfrom=MSDN) and [INotifyCollectionChanged](https://docs.microsoft.com/dotnet/api/system.collections.specialized.inotifycollectionchanged?redirectedfrom=MSDN). For more info, see [Binding to collections](https://docs.microsoft.com/windows/uwp/data-binding/data-binding-quickstart).

### Interface inheritance

IBindableVectorView inherits [IBindableIterable](ibindableiterable.md). Types that implement IBindableVectorView also implement the interface members of [IBindableIterable](ibindableiterable.md) for C++ usage.

## -examples

## -see-also
[IBindableIterable](ibindableiterable.md), [XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854)
