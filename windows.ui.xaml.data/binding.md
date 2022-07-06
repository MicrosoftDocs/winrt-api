---
-api-id: T:Windows.UI.Xaml.Data.Binding
-api-type: winrt class
---

<!-- Class syntax.
public class Binding : Windows.UI.Xaml.Data.BindingBase, Windows.UI.Xaml.Data.IBinding, Windows.UI.Xaml.Data.IBinding2
-->

# Windows.UI.Xaml.Data.Binding

## -description
Defines a binding that connects the properties of binding targets and data sources.



## -xaml-syntax
```xaml
<Binding .../>
- or -
<dependencyobject dependencyproperty="{Binding bindingArgs}" />
```


## -remarks
The [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) enables you to specify a Binding value as a single attribute string in XAML, including setting Binding properties such as [Path](binding_path.md) and [Source](binding_source.md). For more info about data binding concepts, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).

The Binding class might be considered the code-behind exposure of the [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension). If a binding is already applied to a target (which happens when the XAML is loaded), you can't set the read-write properties of a Binding object to change how a binding behaves at run-time. Any XAML-defined binding should be considered immutable. But you can create a new Binding object, set its properties, and establish a new binding on a specific UI element target using [FrameworkElement.SetBinding](../windows.ui.xaml/frameworkelement_setbinding_28713777.md). For more info, see [Creating bindings in code](/windows/uwp/data-binding/data-binding-in-depth).

A Binding object connects a dependency property of a [FrameworkElement](../windows.ui.xaml/frameworkelement.md) directly to a data object so that updates to the data object are automatically propagated to the property that uses data binding. The Binding class defines the properties of a binding. Each binding must have a target element, target property, and data source, although some values are provided by default if you don't specify them.

To bind to a property or a sub-property on a data object, set the [Path](binding_path.md) property of the Binding object. For more info on how to set [Path](binding_path.md) in code or in XAML, see [Property-path syntax](/windows/uwp/xaml-platform/property-path-syntax) or [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension).

You can apply an instance of a Binding class to multiple targets. However, you cannot modify the property values of a Binding object after you attach it to a target element.

> [!NOTE]
> Calling the [FrameworkElement.SetBinding](../windows.ui.xaml/frameworkelement_setbinding_28713777.md) method and passing in a new Binding object won't necessarily remove an existing binding. Instead, you should use the [DependencyObject.ClearValue](../windows.ui.xaml/dependencyobject_clearvalue_1095854009.md) method.

For more info on XAML attribute usage for properties that can take a Binding, or that can otherwise be set to a data-bound value, see [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension).

The property that is the target of a data binding must be a dependency property. For more info, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

## -examples
The following code example demonstrates how to create a binding in XAML. For the complete code listing, see the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind).

```xaml
<StackPanel Margin="5">

  <TextBlock Text="Name:" Style="{StaticResource DescriptionTextStyle}" 
    Margin="5" HorizontalAlignment="Left" VerticalAlignment="Top"/>

  <TextBox Text="{Binding Path=Name, Mode=TwoWay}" 
    Width="350" Margin="5" HorizontalAlignment="Left" VerticalAlignment="Top"/>

  <TextBlock Text="Organization:" Style="{StaticResource DescriptionTextStyle}" 
    Margin="5" HorizontalAlignment="Left" VerticalAlignment="Top"/>

  <!-- You can omit the 'Path=' portion of the binding expression. --> 
  <TextBox Text="{Binding Organization, Mode=TwoWay}" Width="350" 
    Margin="5" HorizontalAlignment="Left" VerticalAlignment="Top"/>

</StackPanel>
```

The following example code demonstrates how to create a binding in code.



[!code-csharp[BindingObject](../windows.ui.xaml/code/BindingInCode/csharp/Page.xaml.cs#SnippetBindingObject)]

[!code-cpp[BindingObject](../windows.ui.xaml/code/BindingInCode/cpp/MainPage.xaml.cpp#SnippetBindingObject)]

[!code-vb[BindingObject](../windows.ui.xaml/code/BindingInCode/vbnet/BlankPage.xaml.vb#SnippetBindingObject)]

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview), [Property-path syntax](/windows/uwp/xaml-platform/property-path-syntax), [BindingOperations.SetBinding](bindingoperations_setbinding_746099660.md)
