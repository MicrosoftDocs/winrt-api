---
-api-id: T:Windows.UI.Xaml.Data.BindableAttribute
-api-type: winrt class
---

<!-- Class syntax.
public class BindableAttribute : System.Attribute
-->

# Windows.UI.Xaml.Data.BindableAttribute

## -description
Specifies that a type defined in C++ can be used for binding.



## -remarks
Apply this attribute to C++-based data classes to enable their use as binding sources. Common language runtime (CLR) types, including all types defined in C# and Microsoft Visual Basic, are bindable by default. You can also make a type bindable by implementing [ICustomPropertyProvider](icustompropertyprovider.md). For more info, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).

## -examples
The following code example shows the typical usage pattern for this attribute. For the complete code listing, see the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind).

If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/intro-to-using-cpp-with-winrt), then you need to add the **BindableAttribute** only if you're using the [{Binding}](/windows/uwp/xaml-platform/binding-markup-extension) markup extension. If you're using the [{x:Bind}](/windows/uwp/xaml-platform/x-bind-markup-extension) markup extension, then you don't need **BindableAttribute** (for more info, see [XAML controls; bind to a C++/WinRT property](/windows/uwp/cpp-and-winrt-apis/binding-property)).

```cppwinrt
// MyColors.idl
namespace MyColorsApp
{
    [bindable]
    [default_interface]
    runtimeclass MyColors : Windows.UI.Xaml.Data.INotifyPropertyChanged
    {
        MyColors();
        Windows.UI.Xaml.Media.SolidColorBrush Brush1;
    }
}
```

```cppcx
[Windows::UI::Xaml::Data::Bindable]
public ref class Employee sealed : Windows::UI::Xaml::Data::INotifyPropertyChanged
{
    // ...
}
```

## -see-also
[Attribute](/dotnet/api/system.attribute?view=dotnet-uwp-10.0&preserve-view=true), [Binding](binding.md), [ICustomPropertyProvider](icustompropertyprovider.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [XAML controls; bind to a C++/WinRT property](/windows/uwp/cpp-and-winrt-apis/binding-property)
