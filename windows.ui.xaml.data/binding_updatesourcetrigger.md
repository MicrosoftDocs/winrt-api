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
One of the [UpdateSourceTrigger](updatesourcetrigger.md) values. The default is **Default**, which evaluates as a **PropertyChanged** update behavior.

## -remarks
Your other choice for an [UpdateSourceTrigger](updatesourcetrigger.md) behavior is to set the value to be **Explicit**. When a two-way binding has its [UpdateSourceTrigger](updatesourcetrigger.md) value as **Explicit**, you must explicitly call [UpdateSource](bindingexpression_updatesource_190615267.md) on the relevant [BindingExpression](bindingexpression.md) to cause the changed target values to update the data source. Use [GetBindingExpression](../windows.ui.xaml/frameworkelement_getbindingexpression_1210399878.md) to get a [BindingExpression](bindingexpression.md) from an object where a [Binding](binding.md) to a dependency property exists and that binding is a two-way binding with `UpdateSourceTrigger="Explicit"`.

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples

## -see-also
[UpdateSource](bindingexpression_updatesource_190615267.md), [Mode](binding_mode.md), [XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854), [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011), [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e), [GetBindingExpression](../windows.ui.xaml/frameworkelement_getbindingexpression_1210399878.md), [BindingOperations.SetBinding](bindingoperations_setbinding_746099660.md)