---
-api-id: M:Windows.UI.Xaml.FrameworkElement.SetBinding(Windows.UI.Xaml.DependencyProperty,Windows.UI.Xaml.Data.BindingBase)
-api-type: winrt method
---

<!-- Method syntax
public void SetBinding(Windows.UI.Xaml.DependencyProperty dp, Windows.UI.Xaml.Data.BindingBase binding)
-->

# Windows.UI.Xaml.FrameworkElement.SetBinding

## -description
Attaches a binding to a [FrameworkElement](frameworkelement.md), using the provided binding object
<!--, and returns a <see cref="T:Windows.UI.Xaml.Data.BindingExpressionBase"/> for possible later use-->
.

## -parameters
### -param dp
The dependency property identifier of the property that is data bound.

### -param binding
The binding to use for the property.

## -remarks
This method is a convenience method that calls [BindingOperations.SetBinding](../windows.ui.xaml.data/bindingoperations_setbinding_746099660.md), passing the current instance as the *target* parameter.

The type of the *binding* parameter is [BindingBase](../windows.ui.xaml.data/bindingbase.md) for compatibility reasons, but in the Windows Runtime you always pass a [Binding](../windows.ui.xaml.data/binding.md) instance. [Binding](../windows.ui.xaml.data/binding.md) is derived from [BindingBase](../windows.ui.xaml.data/bindingbase.md).

The *dp* parameter takes a dependency property identifier. For more info on dependency properties and how a [DependencyProperty](dependencyproperty.md) value serves as the identifier, see [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).

You can bind to custom dependency properties or custom attached properties, the identifier you pass as the *dp* parameter doesn't have to be a Windows Runtime defined property.

Whether a binding created from code will be able to use an acting data context depends on object lifetime considerations. For example, a [DataContext](frameworkelement_datacontext.md) value that is set from XAML won't be available until the XAML is parsed. In that case you may want to use a [Loaded](frameworkelement_loaded.md) handler to add bindings from code.



> [!NOTE]
> Calling the [SetBinding](frameworkelement_setbinding_28713777.md) method and passing in a new [Binding](../windows.ui.xaml.data/binding.md) object won't necessarily remove an existing binding. Instead, you should first call the [DependencyObject.ClearValue](dependencyobject_clearvalue_1095854009.md) method, then call [SetBinding](frameworkelement_setbinding_28713777.md).

### Binding to attached properties

You can put data bindings on any attached properties that a target object supports. Technically an [DependencyObject](dependencyobject.md) supports all the possible attached properties, but you'd usually only set a binding on an attached property that's relevant to that object or your scenario. For example you would set a binding on [Grid.Row](../windows.ui.xaml.controls/grid_row.md) only if you anticipate that the target element has a [Grid](../windows.ui.xaml.controls/grid.md) parent that will use that info. Specify the *dp* parameter as the dependency property identifier that exists on the attached property's owner class (for the [Grid.Row](../windows.ui.xaml.controls/grid_row.md) example, that identifier is [Grid.RowProperty](../windows.ui.xaml.controls/grid_rowproperty.md)). You won't find that identifier on the target because it's an attached property. For more info on attached properties, see [Attached properties overview](http://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2).

## -examples
This example establishes a binding to a dependency property on an object by calling [SetBinding](frameworkelement_setbinding_28713777.md).



[!code-csharp[BindingObject](../windows.ui.xaml/code/BindingInCode/csharp/Page.xaml.cs#SnippetBindingObject)]

[!code-vb[BindingObject](../windows.ui.xaml/code/BindingInCode/vbnet/BlankPage.xaml.vb#SnippetBindingObject)]

## -see-also
[Binding](../windows.ui.xaml.data/binding.md), [BindingOperations](../windows.ui.xaml.data/bindingoperations.md), [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011), [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e)
9e66-f71c-4daa-9994-617c886fda7e)
