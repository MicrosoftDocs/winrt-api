---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.HeaderTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate HeaderTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.HeaderTemplate

## -description
Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display the content of the control's header.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.RichEditBox.HeaderTemplate](/windows/winui/api/microsoft.ui.xaml.controls.richeditbox.headertemplate) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<RichEditBox>
  <RichEditBox.HeaderTemplate>
    singleDataTemplate
  </RichEditBox.HeaderTemplate>
</RichEditBox>
- or -
<RichEditBox HeaderTemplate="resourceReferenceToDataTemplate"/>
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
[Header](richeditbox_header.md)
