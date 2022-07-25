---
-api-id: M:Windows.UI.Xaml.Controls.ContentPresenter.OnContentTemplateSelectorChanged(Windows.UI.Xaml.Controls.DataTemplateSelector,Windows.UI.Xaml.Controls.DataTemplateSelector)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnContentTemplateSelectorChanged(Windows.UI.Xaml.Controls.DataTemplateSelector oldContentTemplateSelector, Windows.UI.Xaml.Controls.DataTemplateSelector newContentTemplateSelector)
-->

# Windows.UI.Xaml.Controls.ContentPresenter.OnContentTemplateSelectorChanged

## -description
Invoked when the value of the [ContentTemplateSelector](contentpresenter_contenttemplateselector.md) property changes.



## -parameters
### -param oldContentTemplateSelector
The old value of the [ContentTemplateSelector](contentpresenter_contenttemplateselector.md) property.

### -param newContentTemplateSelector
The new value of the [ContentTemplateSelector](contentpresenter_contenttemplateselector.md) property.

## -remarks
Classes that derive from [ContentPresenter](contentpresenter.md) can override this method in order to perform any custom logic that should apply, in cases where the selector logic that automatically chooses the [DataTemplate](../windows.ui.xaml/datatemplate.md) based on context changes.

## -examples

## -see-also
