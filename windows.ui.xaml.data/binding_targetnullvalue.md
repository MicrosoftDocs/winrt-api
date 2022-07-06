---
-api-id: P:Windows.UI.Xaml.Data.Binding.TargetNullValue
-api-type: winrt property
---

<!-- Property syntax
public object TargetNullValue { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.TargetNullValue

## -description
Gets or sets the value that is used in the target when the value of the source is **null**.



## -xaml-syntax
```xaml
<Binding TargetNullValue="nullValueString" />
- or -
<Binding>
  <Binding.TargetNullValue>
    nullValue
  </Binding.TargetNullValue>
</Binding>
```


## -xaml-values
<dl><dt>nullValueString</dt><dd>nullValueStringA string that can be converted to provide a value for the Binding target in XAML, in cases where the source was null.</dd>
<dt>nullValue</dt><dd>nullValueAn object element instance that can provide a value for the Binding target in XAML, in cases where the source was null.</dd>
</dl>
## -property-value
The value that is used in the binding target when the value of the source is **null**.

## -remarks
TargetNullValue might be used for bindings that bind a collection and the source data uses **null** for missing info only in some of the items. It might also be used for general cases where the data is coming from a database that uses **null** values as source info to signify something, such as a record that needs more info from the user and isn't complete in the source.

There are two recommended patterns for using TargetNullValue behavior in a [Binding](binding.md):
+ The binding source provides a separate value that is accessed by a different path, which acts as the singleton value that can substitute for any **null** value coming from a specific data item in the source. For example:

```xaml
<Button Content="{Binding Path=NextItem, Mode=OneWay, TargetNullValue={Binding Path=NullValue}}"/>
```

 Here, `NullValue` is the path to the substitute value, and is referenced by another [Binding](binding.md).
+ Use resources to provide a value that's specific to your app in cases where the data source provided **null** and has no suitable property in another path to use as the substitution value. For example:

```xaml
<Button Content="{Binding Path=NextItem, Mode=OneWay, TargetNullValue={StaticResource AppStringForNullInAStringABinding}}"/>
```

 Here, `AppStringForNullInAStringABinding` is a resource string something like "(value not available)" that lets the user know that there should be data there in most of the data but this particular item didn't have that data from its source. Use resources so that the value can be localized.


[FallbackValue](binding_fallbackvalue.md) is a similar property with similar scenarios. The difference is that a binding uses [FallbackValue](binding_fallbackvalue.md) for cases where the [Path](binding_path.md) and [Source](binding_source.md) doesn't evaluate on the data source at all, or if attempting to set it on the source with a two-way binding throws an exception. It uses TargetNullValue if the [Path](binding_path.md) does evaluate, but the value found there is **null**.

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples

## -see-also
[FallbackValue](binding_fallbackvalue.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
