---
-api-id: T:Windows.UI.Xaml.Data.CollectionViewSource
-api-type: winrt class
---

<!-- Class syntax.
public class CollectionViewSource : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Data.ICollectionViewSource
-->

# Windows.UI.Xaml.Data.CollectionViewSource

## -description
Provides a data source that adds grouping and current-item support to collection classes.

## -xaml-syntax
```xaml
<CollectionViewSource .../>
```


## -remarks
Use CollectionViewSource when you want to bind list controls to collections, but you want to display those collections in groups and maintain a current item independent from the list control. This is particularly useful when you want to bind multiple controls to the same collection and you want the current item in one control to change the current item in the other bound controls. You typically define a CollectionViewSource as a XAML resource and bind to it using the [{StaticResource} markup extension](https://docs.microsoft.com/windows/uwp/xaml-platform/staticresource-markup-extension). You can then set its [Source](collectionviewsource_source.md) property in code-behind to a supported collection type.

Any controls that you bind to the same CollectionViewSource will always have the same current item. You can access the current item programmatically through the [ICollectionView.CurrentItem](icollectionview_currentitem.md) property of the [CollectionViewSource.View](collectionviewsource_view.md) property value.

If the items in the collection are collections themselves, or are objects that contain collections, you can display the collections as groups within the larger collection. To do this, set the [IsSourceGrouped](collectionviewsource_issourcegrouped.md) property to **true**. If the items contain collections but are not collections themselves, you must also set the [ItemsPath](collectionviewsource_itemspath.md) property to the name of the collection property.

> [!NOTE]
> Setting the [Source](collectionviewsource_source.md) property to another CollectionViewSource instance is not supported.

## -examples
The following code example demonstrates how to bind a [ListBox](../windows.ui.xaml.controls/listbox.md) control to the results of a grouping LINQ query. In this example, a collection of teams is grouped by city and displayed with the city name as the group headers. For the complete code listing, see the [XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854). For additional example code on grouping, see the [XAML GridView grouping and SemanticZoom sample](https://go.microsoft.com/fwlink/p/?linkid=226564).

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
[Binding](binding.md), [Data binding in depth](https://docs.microsoft.com/windows/uwp/data-binding/data-binding-in-depth), [XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854), [XAML GridView grouping and SemanticZoom sample](https://go.microsoft.com/fwlink/p/?linkid=226564)
