---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter.SelectedBorderThickness
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness SelectedBorderThickness { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter.SelectedBorderThickness

## -description
Gets or sets the thickness of the border around an item that's selected.



## -xaml-syntax
```xaml
<gridViewItemPresenter SelectedBorderThickness="uniform"/>
- or -
<gridViewItemPresenter SelectedBorderThickness="left&right,top&bottom"/>
- or -
<gridViewItemPresenter SelectedBorderThickness="left,top,right,bottom"/>
```


## -xaml-values
<dl><dt>uniform</dt><dd>uniformA numeric value that specifies a uniform Thickness. The uniform value is applied to all four Thickness values (Left, Top, Right, Bottom).</dd>
<dt>left&amp;right</dt><dd>left&amp;rightA numeric value that specifies the Left and Right values of a symmetrical Thickness.</dd>
<dt>top&amp;bottom</dt><dd>top&amp;bottomA numeric value that specifies the Top and Bottom values of a symmetrical Thickness.</dd>
<dt>left,top,right,bottom</dt><dd>left,top,right,bottomFloating-point values that specify the four possible dimension values of a Thickness structure (Left, Top, Right, Bottom).</dd>
</dl>
## -property-value
The thickness of the border around an item that's selected, as a [Thickness](../windows.ui.xaml/thickness.md) value.

## -remarks

## -examples

## -see-also
