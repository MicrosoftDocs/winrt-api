---
-api-id: T:Windows.UI.Xaml.Controls.VariableSizedWrapGrid
-api-type: winrt class
---

<!-- Class syntax.
public class VariableSizedWrapGrid : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IVariableSizedWrapGrid
-->

# Windows.UI.Xaml.Controls.VariableSizedWrapGrid

## -description
Provides a grid-style layout panel where each tile/cell can be variable size based on content.


## -xaml-syntax
```xaml
<VariableSizedWrapGrid ...>
  oneOrMoreUIElements
</VariableSizedWrapGrid>
-or-
<VariableSizedWrapGrid .../>
```


## -remarks

VariableSizedWrapGrid is layout panel that supports arranging child elements in rows and columns. Each child element can span multiple rows and columns.

<img alt="Variable sized wrap grid layout panel" src="images/controls/VariableSizedWrapGrid.png" />

In a VariableSizedWrapGrid, elements are arranged in rows or columns that automatically wrap to a new row or column when the [MaximumRowsOrColumns](variablesizedwrapgrid_maximumrowsorcolumns.md) value is reached. The [Orientation](wrapgrid_orientation.md) property specifies whether the grid adds its items in rows or columns before wrapping.

When the value is **Vertical**, the grid adds items in columns from top to bottom, then wraps from left to right, like this:<table>
   <tr><td>Item 1</td><td>Item 4</td><td>Item 7</td></tr>
   <tr><td>Item 2</td><td>Item 5</td><td>Item 8</td></tr>
   <tr><td>Item 3</td><td>Item 6</td><td>Item 9</td></tr>
</table>

When the value is **Horizontal**, the grid adds items in rows from left to right, then wraps from top to bottom, like this:<table>
   <tr><td>Item 1</td><td>Item 2</td><td>Item 3</td></tr>
   <tr><td>Item 4</td><td>Item 5</td><td>Item 6</td></tr>
   <tr><td>Item 7</td><td>Item 8</td><td>Item 9</td></tr>
</table>

You can make items different sizes in the grid by making them span multiple rows and columns using the VariableSizedWrapGrid.RowSpan and VariableSizedWrapGrid.ColumnSpan attached properties.

### RowSpan and ColumnSpan

You can set either or both of the RowSpan and ColumnSpan attached properties on any child elements in the VariableSizedWrapGrid in order to have particular child elements use a spanning logic for layout. This is useful if an element has a notably larger size than other elements. For example, if one child element has a desired size that is about twice as large in both dimensions, and you don't want this large element to produce a lot of white space in the nearby cells of peer elements, then you might use markup like this:

```xaml
<VariableSizedWrapGrid>
  <Image Name="MyBigImage"
    VariableSizedWrapGrid.ColumnSpan="2"
    VariableSizedWrapGrid.RowSpan="2"
    ...
  />
  ...
</VariableSizedWrapGrid>
```

### XAML attached properties

VariableSizedWrapGrid is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview). These attached properties enable child elements to report how they should be positioned in their grid parent.

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [ColumnSpan](variablesizedwrapgrid_columnspan.md) | Gets or sets a value that indicates the total number of columns that the element content spans within a parent VariableSizedWrapGrid. |
| [RowSpan](variablesizedwrapgrid_rowspan.md) | Gets or sets a value that indicates the total number of rows that the element content spans within a parent VariableSizedWrapGrid. |

> [!NOTE]
> VariableSizedWrapGrid is not supported for use as the [ItemsPanel](itemscontrol_itemspanel.md) of a [ListView](listview.md) control. You can use it as the [ItemsPanel](itemscontrol_itemspanel.md) in a [GridView](gridview.md) or [ItemsControl](itemscontrol.md), but the content of a VariableSizedWrapGrid is not virtualized. This can reduce performance when you work with large data sets. For more info about virtualization, see [Optimize ListView and GridView](/windows/uwp/debug-test-perf/optimize-gridview-and-listview).

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#variablesizedwrapgrid).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the VariableSizedWrapGrid in action](winui2gallery:/item/VariableSizedWrapGrid).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

## -see-also
[Panel](panel.md), [Define layouts](/windows/uwp/layout/layouts-with-xaml), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview), [Canvas](canvas.md), [Grid](grid.md), [ItemsWrapGrid](itemswrapgrid.md), [StackPanel](stackpanel.md), [WrapGrid](wrapgrid.md), [Controls list](/windows/uwp/design/controls-and-patterns/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
