---
-api-id: P:Windows.UI.Xaml.Controls.Hub.HeaderTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate HeaderTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.Hub.HeaderTemplate

## -description
Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display the content of the hub header.



## -xaml-syntax
```xaml
<Hub HeaderTemplate="resourceReferenceToDataTemplate"/>
- or -
<Hub>
  <Hub.HeaderTemplate>
     <DataTemplate>
      dataTemplateDefinition
    </DataTemplate>
  </Hub.HeaderTemplate>
</Hub>
```


## -xaml-values
<dl><dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
<dt>dataTemplateDefinition</dt><dd>dataTemplateDefinitionDefinition for the DataTemplate, including its root element container and parts within that present the data-based content.</dd>
</dl>
## -property-value
The template that specifies the visualization of the header object. The default is **null**.

## -remarks

## -examples

## -see-also
[Header](hub_header.md)
