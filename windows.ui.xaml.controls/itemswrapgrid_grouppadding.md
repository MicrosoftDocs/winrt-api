---
-api-id: P:Windows.UI.Xaml.Controls.ItemsWrapGrid.GroupPadding
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness GroupPadding { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsWrapGrid.GroupPadding

## -description
Gets or sets the amount of space around a group.



## -xaml-syntax
```xaml
<ItemsWrapGrid GroupPadding="uniform"/>
- or -
<ItemsWrapGrid GroupPadding="left&right,top&bottom"/>
- or -
<ItemsWrapGrid GroupPadding="left,top,right,bottom"/>

```


## -xaml-values
<dl><dt>uniform</dt><dd>uniformA value measured by pixels that specifies a uniform Thickness. The uniform value is applied to all four Thickness values (Left, Top, Right, Bottom).</dd>
<dt>left&amp;right</dt><dd>left&amp;rightA value measured by pixels that specifies the Left and Right values of a symmetrical Thickness.</dd>
<dt>top&amp;bottom</dt><dd>top&amp;bottomA value measured by pixels that specifies the Top and Bottom values of a symmetrical Thickness.</dd>
<dt>left,top,right,bottom</dt><dd>left,top,right,bottomValues measured by pixels that specify the four possible dimension values of a Thickness structure (Left, Top, Right, Bottom). In the XAML syntaxes shown, you can use a space rather than a comma as the delimiter between values.</dd>
</dl>
## -property-value
The amount of space around a group as a [Thickness](../windows.ui.xaml/thickness.md) value. [Thickness](../windows.ui.xaml/thickness.md) is a structure that stores dimension values using pixel measures. The default is a uniform [Thickness](../windows.ui.xaml/thickness.md) of 0.

## -remarks

## -examples

## -see-also
