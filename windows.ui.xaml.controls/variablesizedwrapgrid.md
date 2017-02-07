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
[VariableSizedWrapGrid](variablesizedwrapgrid.md) is layout panel that supports arranging child elements in rows and columns. Each child element can span multiple rows and columns.

<img alt="Variable sized wrap grid layout panel" src="images/controls/VariableSizedWrapGrid.png" />

In a [VariableSizedWrapGrid](variablesizedwrapgrid.md), elements are arranged in rows or columns that automatically wrap to a new row or column when the [MaximumRowsOrColumns](variablesizedwrapgrid_maximumrowsorcolumns.md) value is reached. The [Orientation](wrapgrid_orientation.md) property specifies whether the grid adds its items in rows or columns before wrapping.

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

You can make items different sizes in the grid by making them span multiple rows and columns using the [VariableSizedWrapGrid.RowSpan](variablesizedwrapgrid_rowspan.md) and [VariableSizedWrapGrid.ColumnSpan](grid_columnspan.md) attached properties.

### VariableSizedWrapGrid XAML attached properties

[VariableSizedWrapGrid](variablesizedwrapgrid.md) is the host service class for several XAML attached properties. The purpose of these attached properties is to enable child elements to specify how they should be positioned within the [VariableSizedWrapGrid](variablesizedwrapgrid.md).

[VariableSizedWrapGrid](variablesizedwrapgrid.md) provides the following attached properties for XAML usage: 
+ [VariableSizedWrapGrid.ColumnSpan](variablesizedwrapgrid_columnspan.md)
+ [VariableSizedWrapGrid.RowSpan](variablesizedwrapgrid_rowspan.md)


You can set either or both of these attached properties on any child elements in the [VariableSizedWrapGrid](variablesizedwrapgrid.md) in order to have particular child elements use a spanning logic for layout. This is useful if an element has a notably larger size than other elements. For example, if one child element has a desired size that is about twice as large in both dimensions, and you don't want this large element to produce a lot of white space in the nearby cells of peer elements, then you might use markup like this:

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

In order to support XAML processor access to the attached properties, and also to expose equivalent get and set operations to code, each XAML attached property has a pair of **Get** and **Set** accessor methods. For example, the [GetRowSpan](variablesizedwrapgrid_getrowspan.md) and [SetRowSpan](variablesizedwrapgrid_setrowspan.md) methods support and provide the equivalent code-only support for `VariableSizedWrapGrid.RowSpan`. Alternatively, you can use the dependency property system to get or set the value of the attached property. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

> [!NOTE]
> [VariableSizedWrapGrid](variablesizedwrapgrid.md) is not supported for use as the [ItemsPanel](itemscontrol_itemspanel.md) of a [ListView](listview.md) control. You can use it as the [ItemsPanel](itemscontrol_itemspanel.md) in a [GridView](gridview.md) or [ItemsControl](itemscontrol.md), but the content of a [VariableSizedWrapGrid](variablesizedwrapgrid.md) is not virtualized. This can reduce performance when you work with large data sets. For more info about virtualization, see [Optimize ListView and GridView](http://msdn.microsoft.com/library/26df15e8-2c05-4174-a714-7df2e8273d32).

## -examples

## -see-also
[Panel](panel.md), [Define layouts](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079), [Alignment, margin, and padding](http://msdn.microsoft.com/library/9412abd4-3674-4865-b07d-64c7c26e4842), [Attached properties overview](http://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2), [Canvas](canvas.md), [Grid](grid.md), [ItemsWrapGrid](itemswrapgrid.md), [StackPanel](stackpanel.md), [WrapGrid](wrapgrid.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)