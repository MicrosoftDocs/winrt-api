---
-api-id: P:Windows.UI.Xaml.Controls.StackPanel.Padding
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness Padding { get;  set; }
-->

# Windows.UI.Xaml.Controls.StackPanel.Padding

## -description
Gets or sets the distance between the border and its child object.



## -xaml-syntax
```xaml
<StackPanel Padding="uniform"/>
- or -
<StackPanel Padding="left&right,top&bottom"/>
- or -
<StackPanel Padding="left,top,right,bottom"/>

```


## -xaml-values
<dl><dt>uniform</dt><dd>uniformA value measured by pixels that specifies a uniform Thickness. The uniform value is applied to all four Thickness values (Left, Top, Right, Bottom).</dd>
<dt>left&amp;right</dt><dd>left&amp;rightA value measured by pixels that specifies the Left and Right values of a symmetrical Thickness.</dd>
<dt>top&amp;bottom</dt><dd>top&amp;bottomA value measured by pixels that specifies the Top and Bottom values of a symmetrical Thickness.</dd>
<dt>left,top,right,bottom</dt><dd>left,top,right,bottomValues measured by pixels that specify the four possible dimension values of a Thickness structure (Left, Top, Right, Bottom). In the XAML syntaxes shown, you can use a space rather than a comma as the delimiter between values.</dd>
</dl>
## -property-value
The dimensions of the space between the border and its child as a [Thickness](../windows.ui.xaml/thickness.md) value. [Thickness](../windows.ui.xaml/thickness.md) is a structure that stores dimension values using pixel measures.

## -remarks
A related property is [Margin](../windows.ui.xaml/frameworkelement_margin.md) (a property of [FrameworkElement](../windows.ui.xaml/frameworkelement.md)). For more info about the relationship between margin and padding, see [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding) or [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml).

## -examples

## -see-also
