---
-api-id: T:Windows.UI.Xaml.Data.IValueConverter
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IValueConverter : 
-->

# Windows.UI.Xaml.Data.IValueConverter

## -description
Exposes methods that allow the data to be modified as it passes through the binding engine.

## -examples
The following example shows how to implement the IValueConverter interface and use the converter when data binding to a collection of objects.

> [!NOTE]
> If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) (or C++/CX), then see [Formatting or converting data values for display](/windows/uwp/data-binding/data-binding-quickstart#formatting-or-converting-data-values-for-display) for more code examples of authoring your own value converter. That topic also discusses how you could use the [ConverterParameter](binding_converterparameter.md) attribute with C++ string-formatting functions.

[!code-xaml[1](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/csharp/Page.xaml#Snippet1)]

[!code-cpp[2](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/cpp/MainPage.xaml.h#Snippet2)]

[!code-csharp[2](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/csharp/Page.xaml.cs#Snippet2)]

[!code-vb[2](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/vbnet/Page.xaml.vb#Snippet2)]

## -remarks
You can create a class that allows you to convert the format of your data between the source and the target by inheriting from IValueConverter. For example, you might want to have a list of colors that you store as **RGBA** values, but display them with color names in the UI. By implementing [Convert](ivalueconverter_convert_101701969.md) and [ConvertBack](ivalueconverter_convertback_2106225504.md), you can change the format of the data values as they are passed between the target and source by the binding engine.
You should always implement [Convert](ivalueconverter_convert_101701969.md) with a functional implementation, but it's fairly common to implement [ConvertBack](ivalueconverter_convertback_2106225504.md) so that it reports a not-implemented exception. You only need a [ConvertBack](ivalueconverter_convertback_2106225504.md) method in your converter if you are using the converter for two-way bindings, or using XAML for serialization.

[UnsetValue](../windows.ui.xaml/dependencyproperty_unsetvalue.md) should be returned from an IValueConverter implementation that provides conversion in a data binding to a dependency property, in any case where the converter is unable to convert a source value. Converters shouldn't throw exceptions for that case in [Convert](ivalueconverter_convert_101701969.md); these will surface as run-time exceptions that you'd need to add handling for in [UnhandledException](../windows.ui.xaml/application_unhandledexception.md) or worse yet appear to users as actual run-time exceptions. Converter implementations should follow the general binding pattern that any failed binding does nothing and does not provide a value, and [UnsetValue](../windows.ui.xaml/dependencyproperty_unsetvalue.md) rather than **null** is the sentinel value for that case that the binding engine understands. For more info, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).


> [!NOTE]
> To data-bind to a custom value converter that is written in Visual C++ component extensions (C++/CX), the header file in which the IValueConverter implementation class is defined must be included, directly or indirectly, in one of the code-behind files. For more info, see [Create your first  using C++](https://docs.microsoft.com/previous-versions/windows/hh465045(v=win.10)).

> [!TIP]
> Some of the default project templates for a UWP app include a helper class, BooleanToVisibilityConverter. This class is an IValueConverter implementation that handles a common custom-control scenario where you use Boolean values from your control logic class to set the [Visibility](../windows.ui.xaml/uielement_visibility.md) value in XAML control templates.

### Migration notes

In the Windows Runtime, the language parameters for IValueConverter methods use strings, as opposed to using [CultureInfo](https://docs.microsoft.com/dotnet/api/system.globalization.cultureinfo?redirectedfrom=MSDN) objects as they do in the Windows Presentation Foundation (WPF) and Microsoft Silverlight definitions of the interface.

## -see-also
[Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](https://docs.microsoft.com/windows/uwp/data-binding/data-binding-in-depth)
b4f1-6caf-4128-a61a-4e400b149011)
