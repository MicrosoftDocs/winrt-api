---
-api-id: P:Windows.UI.Xaml.Controls.GroupStyle.HeaderTemplateSelector
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.DataTemplateSelector HeaderTemplateSelector { get;  set; }
-->

# Windows.UI.Xaml.Controls.GroupStyle.HeaderTemplateSelector

## -description
Gets or sets a reference to a custom [DataTemplateSelector](datatemplateselector.md) logic class. The [DataTemplateSelector](datatemplateselector.md) returns different [DataTemplate](../windows.ui.xaml/datatemplate.md) values to use for the header area of group item content.



## -xaml-syntax
```xaml
<GroupStyle HeaderTemplateSelector="dataTemplateSelectorReference" />
```


## -xaml-values
<dl><dt>dataTemplateSelectorReference</dt><dd>dataTemplateSelectorReferenceA reference to an existing DataTemplateSelector. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
</dl>
## -property-value
An object that derives from [DataTemplateSelector](datatemplateselector.md). The default is **null**.

## -remarks

## -examples

## -see-also
