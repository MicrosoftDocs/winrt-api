---
-api-id: P:Windows.UI.Xaml.Controls.ItemsControl.ItemsSource
-api-type: winrt property
---

<!-- Property syntax
public object ItemsSource { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsControl.ItemsSource

## -description
Gets or sets an object source used to generate the content of the [ItemsControl](itemscontrol.md).

Equivalent WinUI property: [Microsoft.UI.Xaml.Controls.ItemsControl.ItemsSource](/windows/winui/api/microsoft.ui.xaml.controls.itemscontrol.itemssource).

## -xaml-syntax
```xaml
<itemsControl ItemsSource="bindingDeclaration"/>
-or-
<itemsControl ItemsSource="resourceReferenceToSource"/>
```


## -xaml-values
<dl><dt>bindingDeclaration</dt><dd>bindingDeclarationA Binding declaration using a {Binding ....} markup extension. For more information, see {Binding} markup extension.</dd>
<dt>resourceReferenceToSource</dt><dd>resourceReferenceToSourceA resource reference to an existing iterable/enumerable items source from a resources collection. The resource reference must specify the desired items source by key.</dd>
</dl>

## -property-value
The object that is used to generate the content of the [ItemsControl](itemscontrol.md). The default is `null`.

## -remarks

The type of the object that you set the **ItemsSource** property to must implement one of these interfaces.

|.NET|C++/WinRT|C++/CX|
|-|-|-|
|[IEnumerable\<Object\>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true)|[IVector](/uwp/api/windows.foundation.collections.ivector_t_)\<[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)\>|[IIterable](/uwp/api/windows.foundation.collections.iiterable_t_)\<[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)\>|
|[IEnumerable](/dotnet/api/system.collections.ienumerable?view=dotnet-uwp-10.0&preserve-view=true)|[IBindableObservableVector](/uwp/api/windows.ui.xaml.interop.ibindableobservablevector)|[IBindableIterable](/uwp/api/windows.ui.xaml.interop.ibindableiterable)|

The **ItemsControl** can provide better performance if the **ItemsSource** property value also implements a random-access list interface.

|.NET|C++/WinRT|C++/CX|
|-|-|-|
|[IList\<Object\>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)|[IVector](/uwp/api/windows.foundation.collections.ivector_t_)\<[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)\>|[IVector](/uwp/api/windows.foundation.collections.ivector_t_)\<[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)\>|
|[IReadOnlyCollection\<Object\>](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true)|[IVector](/uwp/api/windows.foundation.collections.ivector_t_)\<[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)\>|[IVectorView](/uwp/api/windows.foundation.collections.ivectorview_t_)\<[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)\>|
|[IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true)|[IBindableObservableVector](/uwp/api/windows.ui.xaml.interop.ibindableobservablevector)|[IBindableVector](/uwp/api/windows.ui.xaml.interop.ibindablevector)|
|[IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true)|[IBindableObservableVector](/uwp/api/windows.ui.xaml.interop.ibindableobservablevector)|[IBindableVectorView](/uwp/api/windows.ui.xaml.interop.ibindablevectorview)|
||||

The **ItemsControl** can raise collection-changed notification events if the **ItemsSource** property value also implements a collection-changed notification interface.

|.NET|C++/WinRT|C++/CX|
|-|-|-|
|[INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true)|[IObservableVector](/uwp/api/windows.foundation.collections.iobservablevector_t_)\<[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)\>|[IObservableVector](/uwp/api/windows.foundation.collections.iobservablevector_t_)\<[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)\>|

For .NET, in order for the collection-changed events to be handled, the **ItemsSource** property must also implement the non-generic [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) interface.

## -examples

## -see-also
