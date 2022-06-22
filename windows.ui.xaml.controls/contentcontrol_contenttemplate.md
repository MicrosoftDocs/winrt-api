---
-api-id: P:Windows.UI.Xaml.Controls.ContentControl.ContentTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate ContentTemplate { get;  set; }
-->

# Windows.UI.Xaml.Controls.ContentControl.ContentTemplate

## -description
Gets or sets the data template that is used to display the content of the [ContentControl](contentcontrol.md).



## -xaml-syntax
```xaml
<contentControl>
  <contentControl.ContentTemplate>
    dataTemplate
  </contentControl.ContentTemplate>
</contentControl>
- or -
<contentControl ContentTemplate="templateReference"/>
```


## -xaml-values
<dl><dt>dataTemplate</dt><dd>dataTemplateA DataTemplate object element that defines the display for this ContentControl.</dd>
<dt>templateReference</dt><dd>templateReferenceA {StaticResource} markup extension reference to an existing DataTemplate definition.Both attribute and property element syntax for ContentTemplate are shown, because defining the template inline or referencing an existing one as a resource are both equally valid scenarios.</dd>
</dl>
## -property-value
The data template that is used to display the content of the [ContentControl](contentcontrol.md).

## -remarks
Instead of declaring a fixed [DataTemplate](../windows.ui.xaml/datatemplate.md), you can also implement a [DataTemplateSelector](datatemplateselector.md) and use it to set the [ContentTemplateSelector](contentcontrol_contenttemplateselector.md) property. This technique enables custom template switching based on input data, at the application level. For more information, see [DataTemplateSelector](datatemplateselector.md).

## -examples

## -see-also
