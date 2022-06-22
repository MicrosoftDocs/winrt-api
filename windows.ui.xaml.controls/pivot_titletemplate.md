---
-api-id: P:Windows.UI.Xaml.Controls.Pivot.TitleTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate TitleTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.Pivot.TitleTemplate

## -description
Gets or sets the title template used for displaying the title above the headers area.



## -xaml-syntax
```xaml
<Pivot TitleTemplate="resourceReferenceToDataTemplate"/>
- or -
<Pivot>
  <Pivot.TitleTemplate>
     <DataTemplate>
      dataTemplateDefinition
    </DataTemplate>
  </Pivot.TitleTemplate>
</Pivot>
```


## -xaml-values
<dl><dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
<dt>dataTemplateDefinition</dt><dd>dataTemplateDefinitionDefinition for the DataTemplate, including its root element container and parts within that present the data-based content.</dd>
</dl>
## -property-value
The template that specifies the visualization of the title object.

## -remarks

## -examples

## -see-also
[DataTemplate](../windows.ui.xaml/datatemplate.md)
