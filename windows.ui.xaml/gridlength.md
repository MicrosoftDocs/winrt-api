---
-api-id: T:Windows.UI.Xaml.GridLength
-api-type: winrt struct
---

<!-- Structure syntax.
public struct GridLength 
-->

# GridLength

## -description
Represents a measurement for control logic that explicitly supports **Star** (`*`) sizing and **Auto** sizing.
## -xaml-syntax
```xaml
<object property="doubleValue"/>
- or -
<object property="starSizing"/>
-or-
<object property="Auto"/>
```


## -xaml-values
<dl><dt>doubleValue</dt><dd>doubleValueThe row's height or column's width, expressed as a floating-point value for a pixel count. Typically this is specified as an integer, although interpolation of noninteger values is supported by grid layout.</dd>
<dt>starSizing</dt><dd>starSizingA string that includes the * character. A star sizing sizes rows or columns to take the remaining available space in a Grid. The * character can be preceded by a numeric factor that distributes available space in relation to any other star sizings, in other peer row or column definitions. For example, if Column A has star sizing of * and Column B has star sizing of 2*, then Column A receives one-third the available space and Column B receives two-thirds.</dd>
<dt>Auto</dt><dd>AutoThe column's width or the row's height, described by the literal string token Auto. Auto sizing distributes space based on the size of the content that is within a column or row.</dd>
</dl>

## -struct-fields

### -field Value
The measure for this [GridLength](gridlength.md), which is not necessarily a pixel measure.
    

### -field GridUnitType
A value of the [GridUnitType](gridunittype.md) enumeration that qualifies how **Value** is interpreted as a measure.
    

## -remarks
Types such as [ColumnDefinition](../windows.ui.xaml.controls/columndefinition.md) and [RowDefinition](../windows.ui.xaml.controls/rowdefinition.md) use [GridLength](gridlength.md) values for some of their properties ([ColumnDefinition.Width](../windows.ui.xaml.controls/columndefinition_width.md) and [RowDefinition.Height](../windows.ui.xaml.controls/rowdefinition_height.md)). These property values are used to support variable distribution of available space in layout containers such as [Grid](../windows.ui.xaml.controls/grid.md) (and also derived types of [Grid](../windows.ui.xaml.controls/grid.md) such as [VariableSizedWrapGrid](../windows.ui.xaml.controls/variablesizedwrapgrid.md)). A [GridLength](gridlength.md) can describe one of three modes for sizing: a fixed width, a weighted distribution (star sizing), or an "Auto" sizing mode.

[GridLength](gridlength.md) values are typically declared in XAML attribute syntax. In XAML, the weighted distribution is declared using a "*" symbol, preceded by a number that declares the weighting factor to use for that [GridLength](gridlength.md). The weighted distribution option is also known as *star sizing*.

The data values held by a [GridLength](gridlength.md) ([Value](gridlength_value.md) and [GridUnitType](gridunittype.md)) are both read-only. If you want to change the value of a property that takes a [GridLength](gridlength.md) at run time, you'll have to create a new value using one of the constructors and replace the previous value.

### Star sizing

Star sizing is a convention whereby a [GridLength](gridlength.md) has a number value that specifies a weighted factor versus other [GridLength](gridlength.md) values. Any [GridLength](gridlength.md) values that use star sizing divide the available space, accounting for the weighting factors, and evaluating after any fixed widths are applied. If none of the star sizings have weighting factors, the height or width is divided equally amongst them. The default weighting factor is 1.

This table provides some examples of star sizing results. For these examples, assume that the parent [Grid](../windows.ui.xaml.controls/grid.md) has a fixed width of 600, and that there are three columns. <table>
   <tr><th>Column 0</th><th>Column 1</th><th>Column 2</th><th>Result</th></tr>
   <tr><td>100</td><td>100</td><td>*</td><td>100,100,400</td></tr>
   <tr><td>100</td><td>*</td><td>*</td><td>100,250,250</td></tr>
   <tr><td>100</td><td>*</td><td>4*</td><td>100,100,400</td></tr>
</table>

In code, a star sizing is equivalent to a [GridLength](gridlength.md) where [IsStar](gridlength_isstar.md) is **true**, [GridUnitType](gridlength_gridunittype.md) is [Star](gridunittype.md), and [Value](gridlength_value.md) is the weighted factor applied.

Noninteger weighting factors are permitted, for example ".5*".

### Auto sizing

Auto sizing distributes space evenly based on the size of the content that is within a column or row. The exact logic for auto sizing is implemented by the control or class using the [GridLength](gridlength.md) values. Typically that class is [Grid](../windows.ui.xaml.controls/grid.md), as it interprets its [RowDefinition](../windows.ui.xaml.controls/rowdefinition.md) and [ColumnDefinition](../windows.ui.xaml.controls/columndefinition.md) components.

### Notes on XAML syntax

Although you can specify a [GridLength](gridlength.md) as an object element, you cannot specify the individual values such as **Value** as attributes of that object element. The XAML parser does not support setting XAML attribute values for this structure. Instead, you must specify the values as initialization text within the [GridLength](gridlength.md). For more info on XAML initialization text, see [XAML syntax guide](http://msdn.microsoft.com/library/a57fe7b4-9947-4aa0-bc99-5fe4686b611d).

### Projection and members of **GridLength**

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or in Visual C++ component extensions (C++/CX), then [GridLength](gridlength.md) has non-data members available, and its data members are exposed as read-only properties, not fields.

If you are programming with C++ using the Windows Runtime Template Library (WRL), then only the data member fields exist as members of [GridLength](gridlength.md), and you cannot use the utility methods or properties listed in the members table. WRL code can access similar utility methods that exist on the [GridLengthHelper](gridlengthhelper.md) class, for example [FromValueAndType](gridlengthhelper_fromvalueandtype.md).

## -examples

## -see-also
[Grid](../windows.ui.xaml.controls/grid.md), [ColumnDefinition](../windows.ui.xaml.controls/columndefinition.md), [RowDefinition](../windows.ui.xaml.controls/rowdefinition.md), [ColumnDefinition.Width](../windows.ui.xaml.controls/columndefinition_width.md), [RowDefinition.Height](../windows.ui.xaml.controls/rowdefinition_height.md), [GridUnitType](gridunittype.md), [Define layouts with XAML](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079)