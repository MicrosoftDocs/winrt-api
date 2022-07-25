---
-api-id: M:Windows.UI.Xaml.Data.BindingExpression.UpdateSource
-api-type: winrt method
---

<!-- Method syntax
public void UpdateSource()
-->

# Windows.UI.Xaml.Data.BindingExpression.UpdateSource

## -description
Sends the current binding target value to the binding source property in **TwoWay** bindings.



## -remarks
If the [UpdateSourceTrigger](binding_updatesourcetrigger.md) value of a two-way binding is set to **Explicit**, you must call the UpdateSource method or the changes will not propagate back to the source.

Calling this method does nothing if the [Mode](binding_mode.md) value of the binding is not **TwoWay**.

## -examples

## -see-also
[UpdateSourceTrigger](binding_updatesourcetrigger.md)
