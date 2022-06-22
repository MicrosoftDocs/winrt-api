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
Analogous to the [VectorChangedEventHandler<T>](../windows.foundation.collections/vectorchangedeventhandler_1.md) delegate. Although the parameter *e* is of type [Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true), you can cast it to type [IVectorChangedEventArgs](../windows.foundation.collections/ivectorchangedeventargs.md).

This delegate supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) or implement [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) and [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true). For more info, see [Binding to collections](/windows/uwp/data-binding/data-binding-quickstart).

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
