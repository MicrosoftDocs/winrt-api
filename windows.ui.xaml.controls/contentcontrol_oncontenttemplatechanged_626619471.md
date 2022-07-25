---
-api-id: M:Windows.UI.Xaml.Controls.ContentControl.OnContentTemplateChanged(Windows.UI.Xaml.DataTemplate,Windows.UI.Xaml.DataTemplate)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnContentTemplateChanged(Windows.UI.Xaml.DataTemplate oldContentTemplate, Windows.UI.Xaml.DataTemplate newContentTemplate)
-->

# Windows.UI.Xaml.Controls.ContentControl.OnContentTemplateChanged

## -description
Invoked when the value of the [ContentTemplate](contentcontrol_contenttemplate.md) property changes.



## -parameters
### -param oldContentTemplate
The old value of the [ContentTemplate](contentcontrol_contenttemplate.md) property.

### -param newContentTemplate
The new value of the [ContentTemplate](contentcontrol_contenttemplate.md) property.

## -remarks
Classes that derive from [ContentControl](contentcontrol.md) can override this method in order to perform any custom logic that should apply, in cases where the [DataTemplate](../windows.ui.xaml/datatemplate.md) that presents the content changes.
<!-- TODO: does this fire when the selector does it? Would guess yes. Find an implementation.-->

## -examples

## -see-also
