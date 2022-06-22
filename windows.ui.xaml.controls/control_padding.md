---
-api-id: P:Windows.UI.Xaml.Controls.Control.Padding
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness Padding { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.Padding

## -description
Gets or sets the padding inside a control.



## -xaml-syntax
```xaml
<control Padding="uniform"/>
- or -
<control Padding="left&right,top&bottom"/>
- or -
<control Padding="left,top,right,bottom"/>
```


## -xaml-values
<dl><dt>uniform</dt><dd>uniformA numeric value that specifies a uniform Thickness. The uniform value is applied to all four Thickness values (Left, Top, Right, Bottom).</dd>
<dt>left&amp;right</dt><dd>left&amp;rightA numeric value that specifies the Left and Right values of a symmetrical Thickness.</dd>
<dt>top&amp;bottom</dt><dd>top&amp;bottomA numeric value that specifies the Top and Bottom values of a symmetrical Thickness.</dd>
<dt>left,right,top,bottom</dt><dd>left,right,top,bottomNumeric values that specify the four possible dimension values of a Thickness structure (Left, Top, Right, Bottom).</dd>
</dl>
## -property-value
The amount of space between the content of a [Control](control.md) and its [Margin](../windows.ui.xaml/frameworkelement_margin.md) or [Border](border.md). The default is a [Thickness](../windows.ui.xaml/thickness.md) with values of 0 on all four sides.

## -remarks
Each control might apply this property differently based on its visual template. This property only affects a control whose template uses the Padding property as a parameter. On other controls, this property has no effect. For more info about control templates, see the [Template](control_template.md) property.

A related property is [Margin](../windows.ui.xaml/frameworkelement_margin.md) (a property of [FrameworkElement](../windows.ui.xaml/frameworkelement.md)). For many controls, margin and padding would typically blend together with the division between them not being apparent in the rendering. For such controls it's typical to specify a [Margin](../windows.ui.xaml/frameworkelement_margin.md) or a [Padding](itemspresenter_padding.md), but not both. For more info about the relationship between margin and padding, see [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding) or [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml).

## -examples

## -see-also
[Thickness](../windows.ui.xaml/thickness.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding)
