---
-api-id: P:Windows.UI.Xaml.Controls.Control.BorderThickness
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness BorderThickness { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.BorderThickness

## -description
Gets or sets the border thickness of a control.



## -xaml-syntax
```xaml
<control BorderThickness="uniform"/>
- or -
<control BorderThickness="left&right,top&bottom"/>
- or -
<control BorderThickness="left,top,right,bottom"/>
```


## -xaml-values
<dl><dt>uniform</dt><dd>uniformA numeric value that specifies a uniform Thickness. The uniform value is applied to all four Thickness values (Left, Top, Right, Bottom).</dd>
<dt>left&amp;right</dt><dd>left&amp;rightA numeric value that specifies the Left and Right values of a symmetrical Thickness.</dd>
<dt>top&amp;bottom</dt><dd>top&amp;bottomA numeric value that specifies the Top and Bottom values of a symmetrical Thickness.</dd>
<dt>left,top,right,bottom</dt><dd>left,top,right,bottomFloating-point values that specify the four possible dimension values of a Thickness structure (Left, Top, Right, Bottom).</dd>
</dl>
## -property-value
The border thickness of a control, as a [Thickness](../windows.ui.xaml/thickness.md) value.

## -remarks
Each control might apply this property differently based on its visual template. This property only affects a control whose template uses the BorderThickness property as a parameter. On other controls, this property has no effect. For more info about visual templates, see the [Template](control_template.md) property.

## -examples

## -see-also
[Thickness](../windows.ui.xaml/thickness.md)
