---
-api-id: P:Windows.UI.Xaml.Controls.ItemsPresenter.Padding
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness Padding { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsPresenter.Padding

## -description
Gets or sets the distance between the [ItemsPresenter](itemspresenter.md) and its child objects.



## -xaml-syntax
```xaml
<ItemsPresenter Padding="uniform"/>
- or -
<ItemsPresenter Padding="left&right,top&bottom"/>
- or -
<ItemsPresenter Padding="left,top,right,bottom"/>

```


## -xaml-values
<dl><dt>uniform</dt><dd>uniformA value measured by pixels that specifies a uniform Thickness. The uniform value is applied to all four Thickness values (Left, Top, Right, Bottom).</dd>
<dt>left&amp;right</dt><dd>left&amp;rightA value measured by pixels that specifies the Left and Right values of a symmetrical Thickness.</dd>
<dt>top&amp;bottom</dt><dd>top&amp;bottomA value measured by pixels that specifies the Top and Bottom values of a symmetrical Thickness.</dd>
<dt>left,top,right,bottom</dt><dd>left,top,right,bottomValues measured by pixels that specify the four possible dimension values of a Thickness structure (Left, Top, Right, Bottom). In the XAML syntaxes shown, you can use a space rather than a comma as the delimiter between values.</dd>
</dl>
## -property-value
The dimensions of the space between the presenter and its children as a [Thickness](../windows.ui.xaml/thickness.md) value. [Thickness](../windows.ui.xaml/thickness.md) is a structure that stores dimension values using pixel measures.

## -remarks
A Padding value applies to presentation rendering of each presented item and also to the header (if one is specified).

A related property is [Margin](../windows.ui.xaml/frameworkelement_margin.md) (a property of [FrameworkElement](../windows.ui.xaml/frameworkelement.md)). For [ItemsPresenter](itemspresenter.md) , margin and padding would typically blend together with the division between them not being apparent in the rendering. So it's typical to specify a [Margin](../windows.ui.xaml/frameworkelement_margin.md) or a Padding, but not both. For more info about the relationship between margin and padding, see [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding) or [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml).

## -examples

## -see-also
[Thickness](../windows.ui.xaml/thickness.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Adding ListView and GridView controls](/previous-versions/windows/apps/hh780618(v=win.10))
