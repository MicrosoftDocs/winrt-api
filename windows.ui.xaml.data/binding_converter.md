---
-api-id: P:Windows.UI.Xaml.Data.Binding.Converter
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Data.IValueConverter Converter { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.Converter

## -description
Gets or sets the converter object that is called by the binding engine to modify the data as it is passed between the source and target, or vice versa.



## -xaml-syntax
```xaml
<Binding Converter="converterReference"/>
```


## -xaml-values
<dl><dt>converterReference</dt><dd>converterReferenceA reference to an existing object that implements IValueConverter and functions as a converter. Typically the object is created in a ResourceDictionary and given a key, then referenced by using the {StaticResource} markup extension. For example: &lt;Binding Converter="{StaticResource myConverter}" .../&gt;</dd>
</dl>
## -property-value
The [IValueConverter](ivalueconverter.md) object that modifies the data.

## -remarks
Create a converter by implementing the [IValueConverter](ivalueconverter.md) interface and implementing the [Convert](ivalueconverter_convert_101701969.md) method. That method should return an object that is of the same type as the dependency property that the binding targets, or at least a type that can be implicitly coerced or converted to the target type.

## -examples
To use your converter in a binding, first create an instance of your converter class. The following example shows this as a resource in a XAML file.



[!code-xaml[ConverterResource](../windows.ui.xaml.controls.primitives/code/Binding_Collection/csharp/BlankPage.xaml#SnippetConverterResource)]



[!code-xaml[SetConverter](../windows.ui.xaml.controls.primitives/code/Binding_Collection/csharp/BlankPage.xaml#SnippetSetConverter)]



[!code-csharp[1](../windows.ui.xaml.controls.primitives/code/Binding_Collection/csharp/DataConverter.cs#Snippet1)]

[!code-vb[1](../windows.ui.xaml.controls.primitives/code/Binding_Collection/vbnet/DataConverter.vb#Snippet1)]

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
b4f1-6caf-4128-a61a-4e400b149011)
