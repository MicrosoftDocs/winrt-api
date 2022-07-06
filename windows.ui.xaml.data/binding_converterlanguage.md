---
-api-id: P:Windows.UI.Xaml.Data.Binding.ConverterLanguage
-api-type: winrt property
---

<!-- Property syntax
public string ConverterLanguage { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.ConverterLanguage

## -description
Gets or sets a value that names the language to pass to any converter specified by the [Converter](binding_converter.md) property.



## -xaml-syntax
```xaml
<Binding ConverterLanguage="string"/>
```


## -property-value
A string that names a language. Interpretation of this value is ultimately up to the converter logic.

## -remarks
If a value for ConverterLanguage is specified, this value is used for the *language* value when invoking the converter logic. Specifically, this provides the value of the *language* parameter of the [Convert](ivalueconverter_convert_101701969.md) or [ConvertBack](ivalueconverter_convertback_2106225504.md) methods of the specific converter that is requested with the [Converter](binding_converter.md) property. By default and in the absence of ConverterLanguage being set, the value passed for *language* is an empty string. 
<!--TBW flesh out this scenario better.-->

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples

## -see-also
[Converter](binding_converter.md), [Convert](ivalueconverter_convert_101701969.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
