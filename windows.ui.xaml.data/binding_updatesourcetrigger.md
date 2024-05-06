---
-api-id: P:Windows.UI.Xaml.Data.Binding.UpdateSourceTrigger
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Data.UpdateSourceTrigger UpdateSourceTrigger { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.UpdateSourceTrigger

## -description

Gets or sets a value that determines the timing of binding source updates for two-way bindings.

## -xaml-syntax

```xaml
<Binding UpdateSourceTrigger="updateSourceTriggerMemberName"/>
```
## -xaml-values

<dl><dt>updateSourceTriggerMemberName</dt><dd>updateSourceTriggerMemberNameA named constant from the UpdateSourceTrigger enumeration, such as Explicit.</dd>
</dl>

## -property-value

One of the [UpdateSourceTrigger](updatesourcetrigger.md) values. The default is `Default`, which evaluates as a `PropertyChanged` update behavior for most dependency properties, but evaluates as `LostFocus` for the `TextBox.Text` property.

## -remarks

The default behavior for most dependency properties is `PropertyChanged`. However, the default behavior for the [TextBox.Text](../windows.ui.xaml.controls/textbox_text.md) property is `LostFocus`. For a [Binding](binding.md) to `TextBox.Text`, you can change the `UpdateSourceTrigger` like this:

```xaml
<TextBox Text="{x:Bind MyProperty, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" />
```

However, it won’t have any effect on a `TextBox` in the control template of another control, such as [NumberBox](/windows/winui/api/microsoft.ui.xaml.controls.numberbox). For example, this `UpdateSourceTrigger` setting has no effect.

```xaml
<!-- This UpdateSourceTrigger setting has no effect. -->
<muxc:NumberBox Text="{x:Bind MyProperty, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}"/>
```

Your other choice for an [UpdateSourceTrigger](updatesourcetrigger.md) behavior is to set the value to be `Explicit`. When a two-way binding has its [UpdateSourceTrigger](updatesourcetrigger.md) value as `Explicit`, you must explicitly call [UpdateSource](bindingexpression_updatesource_190615267.md) on the relevant [BindingExpression](bindingexpression.md) to cause the changed target values to update the data source. Use [GetBindingExpression](../windows.ui.xaml/frameworkelement_getbindingexpression_1210399878.md) to get a [BindingExpression](bindingexpression.md) from an object where a [Binding](binding.md) to a dependency property exists and that binding is a two-way binding with `UpdateSourceTrigger="Explicit"`.

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples

## -see-also

[UpdateSource](bindingexpression_updatesource_190615267.md), [Mode](binding_mode.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview), [GetBindingExpression](../windows.ui.xaml/frameworkelement_getbindingexpression_1210399878.md), [BindingOperations.SetBinding](bindingoperations_setbinding_746099660.md)
