---
-api-id: P:Windows.UI.Xaml.Data.CollectionViewSource.View
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Data.ICollectionView View { get; }
-->

# Windows.UI.Xaml.Data.CollectionViewSource.View

## -description
Gets the view object that is currently associated with this instance of [CollectionViewSource](collectionviewsource.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Data.CollectionViewSource.View](/windows/winui/api/microsoft.ui.xaml.data.collectionviewsource.view) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The view object that is currently associated with this instance of [CollectionViewSource](collectionviewsource.md).

## -remarks
This property is initialized when you set the [Source](collectionviewsource_source.md) property. At that time, a view is generated automatically unless the source collection implements [ICollectionViewFactory](icollectionviewfactory.md). Otherwise, the view is retrieved through the [CreateView](icollectionviewfactory_createview_164792513.md) method.

## -examples

## -see-also
[Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
