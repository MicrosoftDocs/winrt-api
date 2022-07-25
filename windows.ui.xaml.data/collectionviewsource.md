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

Use CollectionViewSource when you want to bind list controls to collections, but you want to display those collections in groups and maintain a current item independent from the list control. This is particularly useful when you want to bind multiple controls to the same collection and you want the current item in one control to change the current item in the other bound controls. You typically define a CollectionViewSource as a XAML resource and bind to it using the [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension). You can then set its [Source](collectionviewsource_source.md) property in code-behind to a supported collection type.

Any controls that you bind to the same CollectionViewSource will always have the same current item. You can access the current item programmatically through the [ICollectionView.CurrentItem](icollectionview_currentitem.md) property of the [CollectionViewSource.View](collectionviewsource_view.md) property value.

If the items in the collection are collections themselves, or are objects that contain collections, you can display the collections as groups within the larger collection. To do this, set the [IsSourceGrouped](collectionviewsource_issourcegrouped.md) property to **true**. If the items contain collections but are not collections themselves, you must also set the [ItemsPath](collectionviewsource_itemspath.md) property to the name of the collection property.

> [!NOTE]
> Setting the [Source](collectionviewsource_source.md) property to another CollectionViewSource instance is not supported.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see an example of grouping with SemanticZoom in action](winui2gallery:/item/semanticzoom).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

The following code example demonstrates how to bind a [ListBox](../windows.ui.xaml.controls/listbox.md) control to the results of a grouping LINQ query (a collection of teams is grouped by city and displayed with the city name as the group headers). For the complete code listing, see the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind).

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

For a more detailed example, see the [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind).

## -see-also

[Binding](binding.md)
