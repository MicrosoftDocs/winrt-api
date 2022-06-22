---
-api-id: T:Windows.UI.Xaml.GridUnitType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.GridUnitType : int
-->

# GridUnitType

## -description
Describes the kind of value that a [GridLength](gridlength.md) object is holding.



## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field Auto:0
The size is determined by the size properties of the content object.

### -field Pixel:1
The value is expressed in pixels.

### -field Star:2
The value is expressed as a weighted proportion of available space.


## -remarks

## -examples
This example shows how to position some [TextBlock](../windows.ui.xaml.controls/textblock.md) objects and a [Rectangle](../windows.ui.xaml.shapes/rectangle.md) inside a [Grid](../windows.ui.xaml.controls/grid.md).



[!code-xaml[LayoutOvwGrid](../windows.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwGrid)]

<!--<p xml:space="preserve"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">The preceding example produces output that is similar to This illustration. Note that the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.grid_showgridlines">ShowGridLines</xref> property of the <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.grid">Grid</xref> is set to <mark type="keyword">true</mark> so that you can see the lines of the <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.grid">Grid</xref>. <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.grid_showgridlines">ShowGridLines</xref> is useful for visualizing where the <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.grid">Grid</xref> cells are, but because grid lines cannot be styled or customized, they are typically removed when the layout design is finished.</p>-->

## -see-also
[Grid](../windows.ui.xaml.controls/grid.md)
