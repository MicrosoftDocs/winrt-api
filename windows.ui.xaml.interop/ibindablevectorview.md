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
This interface supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1) or implement [IList](https://msdn.microsoft.com/library/system.collections.ilist.aspx) and [INotifyCollectionChanged](https://msdn.microsoft.com/library/system.collections.specialized.inotifycollectionchanged.aspx). For more info, see [Binding to collections](http://msdn.microsoft.com/library/a9d54dec-cd1b-4043-ade4-32cd4977d1bf).

### Interface inheritance

[IBindableVectorView](ibindablevectorview.md) inherits [IBindableIterable](ibindableiterable.md). Types that implement [IBindableVectorView](ibindablevectorview.md) also implement the interface members of [IBindableIterable](ibindableiterable.md) for C++ usage.

## -examples

## -see-also
[IBindableIterable](ibindableiterable.md), [XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854)