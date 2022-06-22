---
-api-id: P:Windows.UI.Xaml.Controls.Pivot.RightHeaderTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate RightHeaderTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.Pivot.RightHeaderTemplate

## -description
Gets or sets the template for the header on the control's right side.



## -xaml-syntax
```xaml
<Pivot RightHeaderTemplate="resourceReferenceToDataTemplate"/>
- or -
<Pivot>
  <Pivot.RightHeaderTemplate>
     <DataTemplate>
      dataTemplateDefinition
    </DataTemplate>
  </Pivot.RightHeaderTemplate>
</Pivot>
```


## -xaml-values
<dl><dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
<dt>dataTemplateDefinition</dt><dd>dataTemplateDefinitionDefinition for the DataTemplate, including its root element container and parts within that present the data-based content.</dd>
</dl>
## -property-value
The template for the header on the control's right side.

## -remarks

## -examples

## -see-also
