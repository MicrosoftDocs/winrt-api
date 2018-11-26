---
-api-id: T:Windows.UI.Xaml.Controls.Grid
-api-type: winrt class
---

<!-- Class syntax.
public class Grid : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IGrid, Windows.UI.Xaml.Controls.IGrid2
-->

# Windows.UI.Xaml.Controls.Grid

## -description
Defines a flexible grid area that consists of columns and rows. Child elements of the [Grid](grid.md) are measured and arranged according to their row/column assignments (set by using [Grid.Row](grid_row.md) and [Grid.Column](grid_column.md) attached properties) and other logic.

## -xaml-syntax
```xaml
<Grid ...>
  oneOrMoreUIElements
</Grid>
-or-
<Grid .../>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#grid).

[Grid](grid.md) is a layout panel that supports arranging child elements in rows and columns.

<img alt="Grid layout panel" src="images/controls/Grid.png" />

> [!TIP]
> Starting in Windows 10, [Grid](grid.md) defines new border properties that let you draw a border around the [Grid](grid.md) without using an additional [Border](border.md) element. The new properties are [Grid.BorderBrush](grid_borderbrush.md), [Grid.BorderThickness](grid_borderthickness.md), [Grid.CornerRadius](grid_cornerradius.md), and [Grid.Padding](grid_padding.md).



```xaml
<Grid BorderBrush="Red" BorderThickness="2" CornerRadius="10" Padding="12">
    <TextBlock Text="Hello World!"/>
</Grid>
```



You typically define layout behavior for a [Grid](grid.md) in XAML by providing one or more [RowDefinition](rowdefinition.md) elements as the value of [Grid.RowDefinitions](grid_rowdefinitions.md), and one or more [ColumnDefinition](columndefinition.md) elements as the value of [Grid.ColumnDefinitions](grid_columndefinitions.md). Then, you apply the [Grid.Row](grid_row.md) and [Grid.Column](grid_column.md) attached properties to each of the element children of the [Grid](grid.md), to indicate which row/column combination is used to position that element within the parent [Grid](grid.md).

To set the height of rows and the width of columns, you set [RowDefinition.Height](rowdefinition_height.md) for each [RowDefinition](rowdefinition.md) and [ColumnDefinition.Width](columndefinition_width.md) for each [ColumnDefinition](columndefinition.md). By default, each row or column divides layout space equally. You can change this behavior either by providing absolute pixel values, or a **Star** sizing that divides available space using a weighted factor. For more info on how to use **Star** sizing in a [Grid](grid.md), see [Define layouts with XAML](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079) or [GridLength](../windows.ui.xaml/gridlength.md). You also can use an **Auto** sizing that sizes to content.

To indicate that an element child should span multiple rows or multiple columns in the [Grid](grid.md), you can apply the [Grid.RowSpan](grid_rowspan.md) or [Grid.ColumnSpan](grid_columnspan.md) attached properties to child elements of a [Grid](grid.md).

By default, a [Grid](grid.md) contains one row and one column.

Setting the [Margin](../windows.ui.xaml/frameworkelement_margin.md) property on the child elements in a [Grid](grid.md) sets the distance between the element and its grid cell boundaries. The [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) and [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) properties describe how the child element should be positioned within the grid cell. You can precisely position child elements of a [Grid](grid.md) by using a combination of the [Margin](../windows.ui.xaml/frameworkelement_margin.md) property and alignment properties. If you need even more control over the layout of individual child elements, consider using [VariableSizedWrapGrid](variablesizedwrapgrid.md).

[WrapGrid](wrapgrid.md) is another similar layout panel that has the benefit of better handling for content that's too wide, which might be clipped by a regular [Grid](grid.md) depending on values of other layout properties.

### Grid XAML attached properties

[Grid](grid.md) is the host service class for several XAML attached properties. These attached properties enable child elements to report how they should be positioned in their [Grid](grid.md) parent.

[Grid](grid.md) provides these attached properties for XAML usage: 
+ [Grid.Column](grid_column.md)
+ [Grid.ColumnSpan](grid_columnspan.md)
+ [Grid.Row](grid_row.md)
+ [Grid.RowSpan](grid_rowspan.md)


In order to support XAML processor access to the attached properties, and also to expose equivalent get and set operations to code, each XAML attached property has a pair of **Get** and **Set** accessor methods. For example, the [GetColumnSpan](grid_getcolumnspan_1507379653.md) and [SetColumnSpan](grid_setcolumnspan_1865339609.md) methods support and provide the equivalent code-only support for [Grid.ColumnSpan](grid_columnspan.md). Alternatively, you can use the dependency property system to get or set the value of the attached property. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

An element in the first column that spans multiple rows can affect the height of each spanned row even if the first row has enough height to accommodate the element, and subsequent spanned rows would otherwise have a height of 0. For example, the second row in this Grid has its height set to 0, so the blue rectangle would not typically be visible. In this case, you might expect that the red ellipse would not affect the second row because the first row is tall enough to contain the ellipse. However, the Grid calculates the MinHeight of each row to be enough to accommodate the red ellipse, and then spans the element across the rows. As a result, the second row is given a MinHeight of 50, the red ellipse is centered in the 150px span, and half of the blue rectangle is visible in the second row.

> [!NOTE]
> (This example uses an element that spans columns, but also applies to an element in the first column that spans multiple rows.)

```xaml
<Grid Background="Yellow" Width="300">
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="50"/>
        <ColumnDefinition Width="*"/>
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="0"/>
    </Grid.RowDefinitions>
    <Ellipse   Grid.Row="0" Grid.Column="0"  Height="50" Fill="Red" Grid.RowSpan="2"/>
    <Rectangle Grid.Row="0" Grid.Column="1" Fill="Green" Height="100"/>
    <Rectangle Grid.Row="1" Grid.Column="1" Fill="Blue" Height="100"/>
</Grid>
```

### **Grid** derived classes

[Grid](grid.md) is the parent class for [SwapChainPanel](swapchainpanel.md) and [SwapChainBackgroundPanel](swapchainbackgroundpanel.md).

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#grid).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the Grid in action](xamlcontrolsgallery:/item/Grid).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics)


This XAML example shows how to design a layout by using a [Grid](grid.md).

[!code-xml[GridClassXAML](../windows.ui.xaml/code/GridReferenceSample/csharp/Page.xaml#SnippetGridClassXAML)]

[!code-csharp[GridClassCode](../windows.ui.xaml/code/GridReferenceSample/csharp/Page.xaml.cs#SnippetGridClassCode)]

[!code-vb[GridClassCode](../windows.ui.xaml/code/GridReferenceSample/vbnet/Page.xaml.vb#SnippetGridClassCode)]

## -see-also
[Panel](panel.md), [Grid.Row](grid_row.md), [Grid.Column](grid_column.md), [Define layouts](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079), [Alignment, margin, and padding](http://msdn.microsoft.com/library/9412abd4-3674-4865-b07d-64c7c26e4842), [Attached properties overview](http://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2), [Canvas](canvas.md), [StackPanel](stackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [WrapGrid](wrapgrid.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)
yout_txt.controls_by_function)
)
yout_txt.controls_by_function)