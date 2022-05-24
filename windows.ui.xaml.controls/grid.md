---
-api-id: T:Windows.UI.Xaml.Controls.Grid
-api-type: winrt class
---

<!-- Class syntax.
public class Grid : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IGrid, Windows.UI.Xaml.Controls.IGrid2
-->

# Windows.UI.Xaml.Controls.Grid

## -description
Defines a flexible grid area that consists of columns and rows. Child elements of the Grid are measured and arranged according to their row/column assignments (set by using [Grid.Row](/uwp/api/windows.ui.xaml.controls.grid.row) and [Grid.Column](/uwp/api/windows.ui.xaml.controls.grid.column) attached properties) and other logic.


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

Grid is a layout panel that supports arranging child elements in rows and columns.

<img alt="Grid layout panel" src="images/controls/Grid.png" />

You typically define layout behavior for a Grid in XAML by providing one or more [RowDefinition](rowdefinition.md) elements as the value of [Grid.RowDefinitions](grid_rowdefinitions.md), and one or more [ColumnDefinition](columndefinition.md) elements as the value of [Grid.ColumnDefinitions](grid_columndefinitions.md). Then, you apply the [Grid.Row](/uwp/api/windows.ui.xaml.controls.grid.row) and [Grid.Column](/uwp/api/windows.ui.xaml.controls.grid.column) attached properties to each of the element children of the Grid, to indicate which row/column combination is used to position that element within the parent Grid.

To set the height of rows and the width of columns, you set [RowDefinition.Height](rowdefinition_height.md) for each [RowDefinition](rowdefinition.md) and [ColumnDefinition.Width](columndefinition_width.md) for each [ColumnDefinition](columndefinition.md). By default, each row or column divides layout space equally. You can change this behavior either by providing absolute pixel values, or a **Star** sizing that divides available space using a weighted factor. For more info on how to use **Star** sizing in a Grid, see [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml) or [GridLength](../windows.ui.xaml/gridlength.md). You also can use an **Auto** sizing that sizes to content.

To indicate that an element child should span multiple rows or multiple columns in the Grid, you can apply the [Grid.RowSpan](/uwp/api/windows.ui.xaml.controls.grid.rowspan) or [Grid.ColumnSpan](/uwp/api/windows.ui.xaml.controls.grid.columnspan) attached properties to child elements of a Grid.

By default, a Grid contains one row and one column.

Setting the [Margin](../windows.ui.xaml/frameworkelement_margin.md) property on the child elements in a Grid sets the distance between the element and its grid cell boundaries. The [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) and [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) properties describe how the child element should be positioned within the grid cell. You can precisely position child elements of a Grid by using a combination of the [Margin](../windows.ui.xaml/frameworkelement_margin.md) property and alignment properties. If you need even more control over the layout of individual child elements, consider using [VariableSizedWrapGrid](variablesizedwrapgrid.md).

[WrapGrid](wrapgrid.md) is another similar layout panel that has the benefit of better handling for content that's too wide, which might be clipped by a regular Grid depending on values of other layout properties.

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

### Border properties

Grid defines border properties that let you draw a border around the Grid without using an additional [Border](border.md) element. The properties are [Grid.BorderBrush](grid_borderbrush.md), [Grid.BorderThickness](grid_borderthickness.md), [Grid.CornerRadius](grid_cornerradius.md), and [Grid.Padding](grid_padding.md).

```xaml
<Grid BorderBrush="Red" BorderThickness="2" CornerRadius="10" Padding="12">
    <TextBlock Text="Hello World!"/>
</Grid>
```

### XAML attached properties

Grid is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview). These attached properties enable child elements to report how they should be positioned in their Grid parent.

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [Column](grid_column.md) | Gets or sets the column alignment of an element when child layout is processed by a parent Grid layout container. |
| [ColumnSpan](grid_columnspan.md) | Gets or sets a value that indicates the total number of columns that the element content spans within a parent Grid. |
| [Row](grid_row.md) | Gets or sets the row alignment of an element when child layout is processed by a parent Grid layout container. |
| [RowSpan](grid_rowspan.md) | Gets or sets a value that indicates the total number of rows that the element content spans within a parent Grid. |

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | ColumnSpacing |
| 1709 | 16299 | RowSpacing |
| 1809 | 17763 | BackgroundSizing |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#grid).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the Grid in action](winui2gallery:/item/Grid).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)


This XAML example shows how to design a layout by using a Grid.

[!code-xaml[GridClassXAML](../windows.ui.xaml/code/GridReferenceSample/csharp/Page.xaml#SnippetGridClassXAML)]

[!code-csharp[GridClassCode](../windows.ui.xaml/code/GridReferenceSample/csharp/Page.xaml.cs#SnippetGridClassCode)]

[!code-vb[GridClassCode](../windows.ui.xaml/code/GridReferenceSample/vbnet/Page.xaml.vb#SnippetGridClassCode)]

## -see-also

[Panel](panel.md), [Grid.Row](/uwp/api/windows.ui.xaml.controls.grid.row), [Grid.Column](/uwp/api/windows.ui.xaml.controls.grid.column), [Define layouts](/windows/uwp/layout/layouts-with-xaml), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview), [Canvas](canvas.md), [StackPanel](stackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [WrapGrid](wrapgrid.md), [Controls list](/windows/uwp/design/controls-and-patterns/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
