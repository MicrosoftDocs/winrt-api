---
-api-id: P:Windows.UI.Xaml.Data.Binding.Source
-api-type: winrt property
---

<!-- Property syntax
public object Source { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.Source

## -description
Gets or sets the data source for the binding.



## -xaml-syntax
```xaml
<Binding Source="sourceReference"/>
```


## -xaml-values
<dl><dt>sourceReference</dt><dd>sourceReferenceA reference to an existing object that serves as the data source. Typically the object is created in a ResourceDictionary and given a key, then referenced by using the {StaticResource} markup extension. For example: &lt;Binding Source="{StaticResource customDataSourceObject}" .../&gt;</dd>
</dl>
## -property-value
The source object that contains the data for the binding.

## -remarks
The Source property is optional on a [Binding](binding.md) object. If the Source property is set on a [Binding](binding.md) object, the data source applies only to the target properties that use that [Binding](binding.md) object.

To create a data source that is inherited by all the child elements in the tree, instead set the [DataContext](../windows.ui.xaml/frameworkelement_datacontext.md) property on the parent element. Then the parent element and all its children look to the [DataContext](../windows.ui.xaml/frameworkelement_datacontext.md) as the source of their bindings. If the Source is set for a child element, it will override the [DataContext](../windows.ui.xaml/frameworkelement_datacontext.md) inheritance in that instance.

The target can bind directly to the Source object if the path is empty or to a property of the Source object as defined by the path. The path is set either in XAML with the binding syntax or when the [Binding](binding.md) object is created.

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples
The following code example demonstrates how to set this property in XAML. For the complete code listing, see the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind).

```xaml
<StackPanel>

  <StackPanel.Resources>
    <CollectionViewSource x:Name="teamsCVS"/>
  </StackPanel.Resources>

  <ListBox x:Name="lbTeams" Height="200" 
    ItemsSource="{Binding Source={StaticResource teamsCVS}}">
    <ListBox.ItemTemplate>
      <DataTemplate><!-- ... --></DataTemplate>
    </ListBox.ItemTemplate>
  </ListBox>

</StackPanel>

```

For an example demonstrates how to set this property in code, see the [Binding](binding.md) class.

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
