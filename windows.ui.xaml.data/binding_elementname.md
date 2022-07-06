---
-api-id: P:Windows.UI.Xaml.Data.Binding.ElementName
-api-type: winrt property
---

<!-- Property syntax
public string ElementName { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.ElementName

## -description
Gets or sets the name of the element to use as the binding source for the [Binding](binding.md).



## -xaml-syntax
```xaml
<Binding ElementName="nameString"/>
```


## -xaml-values
<dl><dt>nameString</dt><dd>nameStringThe value of the Name property or x:Name attribute for the element you want to use as the binding source.</dd>
</dl>
## -property-value
The value of the [Name](../windows.ui.xaml/frameworkelement_name.md) property or [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) for the element you want to use as the binding source. The default is an empty string.

## -remarks
When you set this property, the specified value must refer to an element in one of the following locations: 
+ The current XAML namescope.
+ The XAML namescope of the templated parent if the binding target is in a data template or control template.
 Because of this restriction, you cannot use the ElementName property to bind to elements that are not created by using XAML. To bind to elements created programmatically, use the [Source](binding_source.md) property instead. [Source](binding_source.md), [RelativeSource](binding_relativesource.md), and ElementName are mutually exclusive in a binding. If you have set one of these attributes, then setting either of the other two in a binding (through XAML or through code) will cause an exception.

Bindings that use an ElementName value almost always include a simple [Path](binding_path.md) that names a property that exists on the object being referenced. It's common that the source property from the named element and the destination property on the target have the same name and use the same value type, this is a scenario you see fairly often in control template definitions that composite control parts but surface properties from the parts. If the source and destination properties use different types, specify a [Converter](binding_converter.md) value that can resolve the type difference and return an appropriate value for the destination.

For more info about XAML namescopes and how they influence bindings and other programmatic access to objects created from XAML, see [XAML namescopes](/windows/uwp/xaml-platform/xaml-namescopes).

The value of ElementName can technically be any string, but the values of [Name](../windows.ui.xaml/frameworkelement_name.md) and [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) are enforced to be valid in the *XamlName grammar*, so you're typically bound by that grammar for an ElementName value too. For more info on what's valid for an element name, see the "XamlName grammar" section in the [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) reference.

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples
The following code example demonstrates how to establish a two-way binding between a [TextBox](../windows.ui.xaml.controls/textbox.md) and a [Slider](../windows.ui.xaml.controls/slider.md) control. For the complete code listing, see scenario 1 in the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind).

```xaml
<Slider x:Name="slider1" Minimum="1" Maximum="100"/>
<TextBox Text="{Binding ElementName=slider1, Path=Value, Mode=TwoWay}"/>

```



## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [XAML namescopes](/windows/uwp/xaml-platform/xaml-namescopes), [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute)
