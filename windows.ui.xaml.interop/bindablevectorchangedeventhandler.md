---
-api-id: T:Windows.UI.Xaml.Interop.BindableVectorChangedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void BindableVectorChangedEventHandler(Windows.UI.Xaml.Interop.IBindableObservableVector vector, System.Object e)
-->
# Windows.UI.Xaml.Interop.BindableVectorChangedEventHandler

## -description
Represents the method that will handle the [VectorChanged](ibindableobservablevector_vectorchanged.md) event.

## -parameters
### -param vector
The object where the handler is attached.

### -param e
Event data, loosely typed.


## -remarks
Analogous to the [VectorChangedEventHandler&lt;T&gt;](../windows.foundation.collections/vectorchangedeventhandler_1.md) delegate. Although the parameter *e* is of type [Object](https://msdn.microsoft.com/library/system.object.aspx), you can cast it to type [IVectorChangedEventArgs](../windows.foundation.collections/ivectorchangedeventargs.md).

This delegate supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1) or implement [IList](https://msdn.microsoft.com/library/system.collections.ilist.aspx) and [INotifyCollectionChanged](https://msdn.microsoft.com/library/system.collections.specialized.inotifycollectionchanged.aspx). For more info, see [Binding to collections](http://msdn.microsoft.com/library/a9d54dec-cd1b-4043-ade4-32cd4977d1bf).

## -examples

## -see-also
[XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854)