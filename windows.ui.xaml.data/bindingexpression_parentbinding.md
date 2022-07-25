---
-api-id: P:Windows.UI.Xaml.Data.BindingExpression.ParentBinding
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Data.Binding ParentBinding { get; }
-->

# Windows.UI.Xaml.Data.BindingExpression.ParentBinding

## -description
Gets the [Binding](binding.md) object of this [BindingExpression](bindingexpression.md).



## -property-value
The [Binding](binding.md) object of the current binding expression.

## -remarks
You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception. Any [Binding](binding.md) value you get back from ParentBinding is by definition a binding that's already been applied to a target, because you obtained the [BindingExpression](bindingexpression.md) by calling [FrameworkElement.GetBindingExpression](../windows.ui.xaml/frameworkelement_getbindingexpression_1210399878.md).

## -examples

## -see-also
