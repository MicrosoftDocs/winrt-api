---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.FooterTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate FooterTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.FooterTemplate

## -description
Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display the content of the view footer.



## -xaml-syntax
```xaml
<listViewBase FooterTemplate="resourceReferenceToDataTemplate"/>
- or -
<listViewBase>
  <listViewBase.FooterTemplate>
     <DataTemplate>
      dataTemplateDefinition
    </DataTemplate>
  </listViewBase.FooterTemplate>
</listViewBase>
```


## -xaml-values
<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
<dt>dataTemplateDefinition</dt><dd>dataTemplateDefinitionDefinition for the DataTemplate, including its root element container and parts within that present the data-based content.</dd>
</dl>
## -property-value
The template that specifies the visualization of the footer object. The default is **null**.

## -remarks

## -examples

## -see-also
