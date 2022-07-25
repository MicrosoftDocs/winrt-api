---
-api-id: P:Windows.UI.Xaml.Controls.TimePicker.HeaderTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate HeaderTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.TimePicker.HeaderTemplate

## -description
Gets or sets the [DataTemplate](../windows.ui.xaml/datatemplate.md) used to display the content of the control's header.



## -xaml-syntax
```xaml
<TimePicker HeaderTemplate="resourceReferenceToDataTemplate"/>
- or -
<TimePicker>
  <TimePicker.HeaderTemplate>
    singleDataTemplate
  </TimePicker.HeaderTemplate>
</TimePicker>
```


## -xaml-values
<dl><dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
<dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation. This inline-template syntax is less common.</dd>
</dl>
## -property-value
The template that specifies the visualization of the header object. The default is **null**.

## -remarks

## -examples

## -see-also
[Header](timepicker_header.md)
