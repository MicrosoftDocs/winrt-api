---
-api-id: P:Windows.UI.Xaml.Controls.ItemsPresenter.HeaderTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate HeaderTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsPresenter.HeaderTemplate

## -description
Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display the content of the items header.



## -xaml-syntax
```xaml
<ItemsPresenter>
  <ItemsPresenter.HeaderTemplate>
    singleDataTemplate
  </ItemsPresenter.HeaderTemplate>
</ItemsPresenter>
- or -
<ItemsPresenter HeaderTemplate="resourceReferenceToDataTemplate"/>
```


## -xaml-values
<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
</dl>
## -property-value
The template that specifies the visualization of the header object. The default is **null**.

## -remarks

### Notes for previous versions

> **Windows 8.x**
> Header alignment is handled differently in apps compiled for Windows 8 than in apps compiled for Windows 8.1.

+ In an app compiled for Windows 8, the header is always left-aligned when the orientation of the items is **Horizontal**, or top-aligned when the orientation is **Vertical**. [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) and [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) values that you set are ignored.
+ In an app compiled for Windows 8.1, you can specify the header alignment. [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) and [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) values that you set are not ignored.


## -examples

## -see-also
