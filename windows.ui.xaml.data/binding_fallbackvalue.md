---
-api-id: P:Windows.UI.Xaml.Data.Binding.FallbackValue
-api-type: winrt property
---

<!-- Property syntax
public object FallbackValue { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.FallbackValue

## -description
Gets or sets the value to use when the binding is unable to return a value.



## -xaml-syntax
```xaml
<Binding FallbackValue="fallbackValue" />
- or -
<Binding>
  <Binding.FallbackValue>
    fallbackValue
    </Binding.FallbackValue>
</Binding>
```


## -xaml-values
<dl><dt>fallbackValue</dt><dd>fallbackValueAn attribute or object element value of the same type as the target property. This varies with each Binding. See the documentation for the property you're binding to and use that XAML syntax for the XAML in your FallbackValue. That property might support attribute syntax for values, or might only support object element syntax. You can also use another Binding or a {StaticResource} markup extension reference to fill the attribute syntax by using an existing object from a ResourceDictionary.</dd>
</dl>
## -property-value
The value to use when the binding is unable to return a value.

## -remarks
Usually you specify FallbackValue for bindings that display strings in UI. For this case the FallbackValue is also a string. You might want to use a resource so that it's easier to localize this string.

If you do specify a literal string for FallbackValue, you must use alternate quotes for the FallbackValue value within the [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) usage if your string contains spaces, because the [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) usage for an attribute is already within quotes. For example, `<object property="{Binding FallbackValue='A literal string'}" />`.

If used within a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) usage, the value for FallbackValue can use any implicit string conversions that are already available to XAML, such as treating 0 as a string for a string binding, or converting enum values. For example, `<object property="{Binding Path=Visibility, FallbackValue=Collapsed}" />` is valid because the parser can evaluate the string "Collapsed" and return [Visibility.Collapsed](../windows.ui.xaml/visibility.md) as the fallback for a [Visibility](../windows.ui.xaml/uielement_visibility.md) value.

[TargetNullValue](binding_targetnullvalue.md) is a similar property with similar scenarios. The difference is that a binding uses FallbackValue for cases where the [Path](binding_path.md) doesn't evaluate on the data source at all, or if attempting to set it on the source with a two-way binding throws an exception that's caught by the data binding engine. FallbackValue is also used if the source value is the dependency property sentinel value [DependencyProperty.UnsetValue](../windows.ui.xaml/dependencyproperty_unsetvalue.md). A binding uses [TargetNullValue](binding_targetnullvalue.md) if the [Path](binding_path.md) and [Source](binding_source.md) do evaluate, but the value found there is **null**.

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples

## -see-also
[TargetNullValue](binding_targetnullvalue.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
