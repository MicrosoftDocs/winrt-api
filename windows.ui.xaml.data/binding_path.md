---
-api-id: P:Windows.UI.Xaml.Data.Binding.Path
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.PropertyPath Path { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.Path

## -description
Gets or sets the path to the binding source property.

## -xaml-syntax
```xaml
<Binding Path="propertyPath"/>
```


## -xaml-values
<dl><dt>propertyPath</dt><dd>propertyPathA string that describes a property on the binding source. This can be a simple property name, or a "dotted-down" property path to a sub-property. For details on how to reference sub-properties, see Property-path syntax.</dd>
</dl>
## -property-value
The property path for the source of the binding.

## -remarks
The path can be a direct property of the source object, or sub-properties of that object that you traverse to using the property path syntax. For Microsoft .NET data sources, paths can also use an indexer syntax to reference specific items in a collection. For details on the property path format, see [Property-path syntax](https://msdn.microsoft.com/library/ff3ecf47-d81f-46e3-be01-c839e0398025).

To set the data source to be the [Source](binding_source.md) object, the path should be defined with an empty string ("").

When using the [{Binding} markup extension](https://msdn.microsoft.com/library/3bafe7b5-af33-487f-9ad5-beafd65d04c3), the [Path](binding_path.md) value can be set using the argument immediately following the `{Binding` part of the extension usage, you don't need to explicitly include `Path=`. For example, `{Binding Albums}` sets the [Path](binding_path.md) value of that binding to be a [PropertyPath](../windows.ui.xaml/propertypath.md) constructed from the string "Albums" (no other [Binding](binding.md) properties are set).

Most usages of [Path](binding_path.md) involve setting its value. For scenarios where you are getting the value to examine the properties of an existing binding, the [PropertyPath.Path](../windows.ui.xaml/propertypath_path_1221375020.md) value contains the string that represents the path.

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples
The following XAML demonstrates how to set the [Path](binding_path.md) using the [{Binding} markup extension](https://msdn.microsoft.com/library/3bafe7b5-af33-487f-9ad5-beafd65d04c3). For the complete code listing, see the [XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854).

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

The following XAML demonstrates how to set the [Path](binding_path.md) using integer and string indexers. For the complete code listing, see the [XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854).

> [!NOTE]
> Visual C++ component extensions (C++/CX) does not currently support indexer binding. See the sample for a workaround.

```xaml
<StackPanel>

  <StackPanel Orientation="Horizontal">

    <TextBlock Text="Team name:" 
      Style="{StaticResource DescriptionTextStyle}" 
      Margin="5" FontWeight="Bold"/>

    <TextBlock Text="{Binding Path=[3].Name}" 
      Style="{StaticResource DescriptionTextStyle}" Margin="5" />

  </StackPanel>

  <StackPanel Orientation="Horizontal">

    <TextBlock Text="Team manager:" 
      Style="{StaticResource DescriptionTextStyle}" 
      Margin="5" FontWeight="Bold"/>

    <TextBlock Text="{Binding Path=[3][Gaffer]}" 
      Style="{StaticResource DescriptionTextStyle}" Margin="5"/>

  </StackPanel>

</StackPanel>
```



## -see-also
[PropertyPath](../windows.ui.xaml/propertypath.md), [XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854), [Data binding in depth](https://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)
