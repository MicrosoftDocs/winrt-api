---
-api-id: M:Windows.UI.Xaml.Data.IValueConverter.Convert(System.Object,Windows.UI.Xaml.Interop.TypeName,System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax
public object Convert(System.Object value, Windows.UI.Xaml.Interop.TypeName targetType, System.Object parameter, System.String language)
-->

# Windows.UI.Xaml.Data.IValueConverter.Convert

## -description
Modifies the source data before passing it to the target for display in the UI.



## -parameters
### -param value
The source data being passed to the target.

### -param targetType
The type of the target property, as a type reference ([System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for C++/CX and C++/WinRT).

### -param parameter
An optional parameter to be used in the converter logic.

### -param language
The language of the conversion.

## -returns
The value to be passed to the target dependency property.

## -remarks
The *targetType* parameter of the Convert method uses different techniques of reporting the type system info, depending on whether you're programming with Microsoft .NET or C++.
+ For Microsoft .NET, this parameter passes an instance of the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) type.
+ For C++/CX and C++/WinRT, this parameter passes a [TypeName](../windows.ui.xaml.interop/typename.md) structure value. `TypeName::Kind` contains the simple string name of the type, similar to Microsoft .NET's `Type.Name`.
When the converter is invoked by the binding engine, the *targetType* value is passed by looking up the property type of the target dependency property. You might use this value in your Convert implementation for one of two reasons:
+ Your converter has the expectation that it's always going to return objects of a specific type, and you want to verify that the binding that the converter is called for is using the converter correctly. If not, you might return a fallback value, or throw an exception (but see "Exceptions from converters" below).
+ Your converter can return more than one type, and you want the usage to inform your converter which type it should return. For example, you could implement an object-to-object conversion and an object-to-string conversion within the same converter code.


*language* comes from the [ConverterLanguage](binding_converterlanguage.md) value of a specific binding, not system values, so you should expect that it might be an empty string.

*parameter* comes from the [ConverterParameter](binding_converterparameter.md) value of a specific binding, and is **null** by default. If your converter uses parameters to modify what it returns, this usually requires some convention for validating what is passed by the binding and handled by the converter. A common convention is to pass strings that name modes for your converter that result in different return values. For example you might have "Simple" and "Verbose" modes that return different length strings that are each appropriate for display in different UI control types and layouts.

### Exceptions from converters

The data binding engine does not catch exceptions that are thrown by a user-supplied converter. Any exception that is thrown by the Convert method, or any uncaught exceptions that are thrown by methods that the Convert method calls, are treated as run-time errors. If you are using the converter in situations where the binding can use fallbacks or otherwise show reasonable results even if a conversion failure occurs, consider having your converter return [DependencyProperty.UnsetValue](../windows.ui.xaml/dependencyproperty_unsetvalue.md) and not throw exceptions. [DependencyProperty.UnsetValue](../windows.ui.xaml/dependencyproperty_unsetvalue.md) is a sentinel value that has special meaning in the dependency property system, and bindings that are passed this value will use [FallbackValue](binding_fallbackvalue.md).

Another alternative to throwing exceptions is to return the original *value* unchanged, and let the binding instance handle what it might do with that value. In most cases UI bindings that fail won't be error cases. They just won't use the source value and will instead use [DependencyProperty.UnsetValue](../windows.ui.xaml/dependencyproperty_unsetvalue.md) to show nothing, or use fallbacks.

**try/catch** based on doing something to *value* is a common implementation pattern for the Convert method, but you shouldn't rethrow, for the reasons mentioned above.

For an example that shows how to implement the Convert method using the *parameter* and *language* parameters, see the [IValueConverter](ivalueconverter.md) interface.

## -examples
The following example shows how to implement the Convert method using the *parameter* and *language* parameters.



[!code-cpp[2](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/cpp/MainPage.xaml.h#Snippet2)]

[!code-csharp[2](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/csharp/Page.xaml.cs#Snippet2)]

[!code-vb[2](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/vbnet/Page.xaml.vb#Snippet2)]

## -see-also
[ConvertBack](ivalueconverter_convertback_2106225504.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)

