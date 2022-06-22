---
-api-id: P:Windows.UI.Xaml.Controls.ItemsPresenter.FooterTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate FooterTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsPresenter.FooterTemplate

## -description
Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display the content of the items header.



## -xaml-syntax
```xaml
<ItemsPresenter>
  <ItemsPresenter.FooterTemplate>
    singleDataTemplate
  </ItemsPresenter.FooterTemplate>
</ItemsPresenter>
- or -
<ItemsPresenter FooterTemplate="resourceReferenceToDataTemplate"/>
```


## -xaml-values
<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
</dl>
## -property-value
The template that specifies the visualization of the header object. The default is **null**.

## -remarks

## -examples

## -see-also
