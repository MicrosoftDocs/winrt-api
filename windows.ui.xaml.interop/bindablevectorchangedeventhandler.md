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
Analogous to the [VectorChangedEventHandler&lt;T&gt;](../windows.foundation.collections/vectorchangedeventhandler_1.md) delegate. Although the parameter *e* is of type [Object](https://docs.microsoft.com/dotnet/api/system.object?redirectedfrom=MSDN), you can cast it to type [IVectorChangedEventArgs](../windows.foundation.collections/ivectorchangedeventargs.md).

This delegate supports the creation of data bindable collections in C++. When programming with .NET, you should use [ObservableCollection(Of T)](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1) or implement [IList](https://docs.microsoft.com/dotnet/api/system.collections.ilist?redirectedfrom=MSDN) and [INotifyCollectionChanged](https://docs.microsoft.com/dotnet/api/system.collections.specialized.inotifycollectionchanged?redirectedfrom=MSDN). For more info, see [Binding to collections](https://docs.microsoft.com/windows/uwp/data-binding/data-binding-quickstart).

## -examples

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind)
