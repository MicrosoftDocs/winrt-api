---
-api-id: P:Windows.UI.Xaml.Controls.GroupStyle.HeaderTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate HeaderTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.GroupStyle.HeaderTemplate

## -description
Gets or sets the template that is used to display the group header.



## -xaml-syntax
```xaml
<GroupStyle HeaderTemplate="dataTemplateReference" />
- or -
<GroupStyle>
  <GroupStyle.HeaderTemplate>
    <DataTemplate>
      dataTemplateDefinition
    </DataTemplate>
  </GroupStyle.HeaderTemplate>
</GroupStyle>
```


## -xaml-values
<dl><dt>dataTemplateReference</dt><dd>dataTemplateReferenceA reference to an existing DataTemplate. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
<dt>dataTemplateDefinition</dt><dd>dataTemplateDefinitionDefinition for the DataTemplate, including its root element container and parts within that present the view's header items.</dd>
</dl>
## -property-value
A [DataTemplate](../windows.ui.xaml/datatemplate.md) object that is used to display the group header. The default is **null**.

## -remarks

## -examples

## -see-also
