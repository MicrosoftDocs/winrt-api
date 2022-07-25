---
-api-id: T:Windows.UI.Xaml.Data.BindingExpression
-api-type: winrt class
---

<!-- Class syntax.
public class BindingExpression : Windows.UI.Xaml.Data.BindingExpressionBase, Windows.UI.Xaml.Data.IBindingExpression
-->

# Windows.UI.Xaml.Data.BindingExpression

## -description
Contains information about a single instance of a [Binding](binding.md).



## -remarks
The [Binding](binding.md) class is the high-level class for the declaration of a binding. The BindingExpression class is the underlying object that maintains the connection between the binding source and the binding target. A [Binding](binding.md) contains all the information that can be shared across several BindingExpression objects. A BindingExpression is an instance expression that cannot be shared and that contains all the instance information about the [Binding](binding.md).

You can obtain a BindingExpression object by calling the [GetBindingExpression](../windows.ui.xaml/frameworkelement_getbindingexpression_1210399878.md) method on an object, specifying the dependency property that has the binding.

<!--Worth mentioning that because GetBindingExpression is on FE, you can't use the Explicit update technique on custom elements that derive from DO rather than FE?, because you can't get the BindingExpression? BindingOperations.SetBinding in WPF used to return the BindingExpression and perhaps that was the reason.-->

## -examples

## -see-also
[BindingExpressionBase](bindingexpressionbase.md)
