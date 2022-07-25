---
-api-id: P:Windows.UI.Xaml.Data.Binding.ConverterParameter
-api-type: winrt property
---

<!-- Property syntax
public object ConverterParameter { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.ConverterParameter

## -description
Gets or sets a parameter that can be used in the [Converter](binding_converter.md) logic.



## -xaml-syntax
```xaml
<Binding ConverterParameter="parameter"/>
-or-
<Binding ConverterParameter="parameterReference"/>
```


## -xaml-values
<dl><dt>parameter</dt><dd>parameterA parameter value that is either a primitive value, or can be type converted from a string.</dd>
<dt>parameterReference</dt><dd>parameterReferenceA parameter value that is obtained as a reference to an already existing object. Typically the object is created in a ResourceDictionary and given a key, then referenced by using the {StaticResource} markup extension.</dd>
</dl>
## -property-value
A parameter to be passed to the [Converter](binding_converter.md). This can be used in the conversion logic. The default is **null**.

## -remarks
Passing parameters to a converter is a relatively advanced and uncommon scenarios. Most converters used for data binding simply type-convert a source object to a desired target type based solely on the characteristics of the source object, and knowing what the intended destination type is for a particular binding scenario.

If a value for ConverterParameter is specified, this value is used for the *parameter* value when invoking the converter logic. Specifically, this provides the value of the *parameter* parameter of the [Convert](ivalueconverter_convert_101701969.md) or [ConvertBack](ivalueconverter_convertback_2106225504.md) methods of the specific converter that is requested with the [Converter](binding_converter.md) property.

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples

## -see-also
[Converter](binding_converter.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
