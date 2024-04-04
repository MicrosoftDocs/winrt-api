---
-api-id: P:Windows.UI.Xaml.Data.CollectionViewSource.IsSourceGrouped
-api-type: winrt property
---

<!-- Property syntax
public bool IsSourceGrouped { get;  set; }
-->

# Windows.UI.Xaml.Data.CollectionViewSource.IsSourceGrouped

## -description
Gets or sets a value that indicates whether source data is grouped.



## -xaml-syntax
```xaml
<CollectionViewSource IsSourceGrouped="bool" .../>
```


## -property-value
**true** if data is grouped. **false** if data is not grouped.

## -remarks

## -examples
The following code example demonstrates how to bind a [ListBox](../windows.ui.xaml.controls/listbox.md) control to the results of a grouping LINQ query. In this example, a collection of teams is grouped by city and displayed with the city name as the group headers. For the complete code listing, see the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind). For additional example code on grouping, see the [Grouped GridView sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20GridView%20grouping%20and%20SemanticZoom%20sample).

```xaml
<Grid>

  <Grid.Resources>
    <CollectionViewSource x:Name="groupInfoCVS" IsSourceGrouped="true"/>
  </Grid.Resources>

  <ListBox x:Name="lbGroupInfoCVS" 
    ItemsSource="{Binding Source={StaticResource groupInfoCVS}}">

    <ListBox.GroupStyle>
      <GroupStyle>
        <GroupStyle.HeaderTemplate>
          <DataTemplate>

            <TextBlock Text="{Binding Key}"/>

          </DataTemplate>
        </GroupStyle.HeaderTemplate>
      </GroupStyle>
    </ListBox.GroupStyle>

    <ListBox.ItemTemplate>
      <DataTemplate>

        <Border Background="{Binding Color}" 
          Width="200" CornerRadius="10" HorizontalAlignment="Left">

          <TextBlock Text="{Binding Name}" 
            Style="{StaticResource DescriptionTextStyle}" 
            HorizontalAlignment="Center" FontWeight="Bold"/>

        </Border>
      </DataTemplate>
    </ListBox.ItemTemplate>

  </ListBox>

</Grid>

```

```csharp
Teams teams = new Teams();
var result = 
    from t in teams 
    group t by t.City into g 
    orderby g.Key 
    select g;
groupInfoCVS.Source = result;

```



## -see-also
[Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
