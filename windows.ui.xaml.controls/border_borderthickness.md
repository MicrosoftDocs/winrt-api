---
-api-id: P:Windows.UI.Xaml.Controls.Border.BorderThickness
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness BorderThickness { get;  set; }
-->

# Windows.UI.Xaml.Controls.Border.BorderThickness

## -description
Gets or sets the thickness of the border.



## -xaml-syntax
```xaml
<Border BorderThickness="uniform"/>
- or -
<Border BorderThickness="left&right,top&bottom"/>
- or -
<Border BorderThickness="left,top,right,bottom"/>

```


## -xaml-values
<dl><dt>uniform</dt><dd>uniformA value measured by pixels that specifies a uniform Thickness. The uniform value is applied to all four Thickness properties (Left, Top, Right, Bottom).</dd>
<dt>left&amp;right</dt><dd>left&amp;rightA value measured by pixels that specifies the Left and Right properties of a symmetrical Thickness.</dd>
<dt>top&amp;bottom </dt><dd>top&amp;bottom A value measured by pixels that specifies the Top and Bottom properties of a symmetrical Thickness.</dd>
<dt>left,top,right,bottom </dt><dd>left,top,right,bottom Values measured by pixels that specify the four possible dimension properties of a Thickness structure (Left, Top, Right, Bottom). In the XAML syntaxes shown, you can use a space rather than a comma as the delimiter between values.</dd>
</dl>
## -property-value
The thickness of the border, in pixels. The default is 0 on all four sides.

## -remarks

## -examples

## -see-also
[Thickness](../windows.ui.xaml/thickness.md)
