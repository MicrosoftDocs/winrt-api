---
-api-id: P:Windows.UI.Xaml.Controls.Pivot.LeftHeaderTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate LeftHeaderTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.Pivot.LeftHeaderTemplate

## -description
Gets or sets the template for the header on the control's left side.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.Pivot.LeftHeaderTemplate](/windows/winui/api/microsoft.ui.xaml.controls.pivot.leftheadertemplate) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Pivot LeftHeaderTemplate="resourceReferenceToDataTemplate"/>
- or -
<Pivot>
  <Pivot.LeftHeaderTemplate>
     <DataTemplate>
      dataTemplateDefinition
    </DataTemplate>
  </Pivot.LeftHeaderTemplate>
</Pivot>
```


## -xaml-values
<dl><dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
<dt>dataTemplateDefinition</dt><dd>dataTemplateDefinitionDefinition for the DataTemplate, including its root element container and parts within that present the data-based content.</dd>
</dl>
## -property-value
The template for the header on the control's left side.

## -remarks

## -examples

## -see-also
