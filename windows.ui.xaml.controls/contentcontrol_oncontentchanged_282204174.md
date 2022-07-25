---
-api-id: M:Windows.UI.Xaml.Controls.ContentControl.OnContentChanged(System.Object,System.Object)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnContentChanged(System.Object oldContent, System.Object newContent)
-->

# Windows.UI.Xaml.Controls.ContentControl.OnContentChanged

## -description
Invoked when the value of the [Content](contentcontrol_content.md) property changes.



## -parameters
### -param oldContent
The old value of the [Content](contentcontrol_content.md) property.

### -param newContent
The new value of the [Content](contentcontrol_content.md) property.

## -remarks
If a value for [ContentTemplateSelector](contentcontrol_contenttemplateselector.md) exists, then the default implementation calls [SelectTemplate](datatemplateselector_selecttemplate_375443783.md) on the implemented [DataTemplateSelector](datatemplateselector.md), passing the *newContent* value as *item*, and the calling [ContentControl](contentcontrol.md) as *container*. The return value then sets [ContentTemplate](contentcontrol_contenttemplate.md) automatically on the caller.

## -examples

## -see-also
