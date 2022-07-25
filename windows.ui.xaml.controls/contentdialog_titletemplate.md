---
-api-id: P:Windows.UI.Xaml.Controls.ContentDialog.TitleTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate TitleTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.ContentDialog.TitleTemplate

## -description
Gets or sets the title template.



## -xaml-syntax
```xaml
<ContentDialog>
  <ContentDialog.TitleTemplate>
    singleDataTemplate
  </ContentDialog.TitleTemplate>
</ContentDialog>
- or -
<ContentDialog TitleTemplate="resourceReferenceToDataTemplate"/>
```


## -xaml-values
<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
</dl>
## -property-value
The title template.

## -remarks

## -examples

## -see-also
