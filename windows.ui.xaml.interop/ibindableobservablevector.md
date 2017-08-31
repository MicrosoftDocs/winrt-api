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
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1) or implement [IList](https://msdn.microsoft.com/library/system.collections.ilist.aspx) and [INotifyCollectionChanged](https://msdn.microsoft.com/library/system.collections.specialized.inotifycollectionchanged.aspx). For more info, see [Binding to collections](http://msdn.microsoft.com/library/a9d54dec-cd1b-4043-ade4-32cd4977d1bf).

### Interface inheritance

[IBindableObservableVector](ibindableobservablevector.md) inherits [IBindableVector](ibindablevector.md) and [IBindableIterable](ibindableiterable.md). Types that implement [IBindableObservableVector](ibindableobservablevector.md) also implement the interface members of [IBindableVector](ibindablevector.md) and [IBindableIterable](ibindableiterable.md) for C++ usage, or [IList](https://msdn.microsoft.com/library/system.collections.ilist.aspx) and [IEnumerable](https://msdn.microsoft.com/library/system.collections.ienumerable.aspx) for Microsoft .NET usage.

## -examples

## -see-also
[IBindableVector](ibindablevector.md), [IBindableIterable](ibindableiterable.md), [XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854)