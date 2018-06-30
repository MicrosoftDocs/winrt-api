---
-api-id: M:Windows.UI.Xaml.Controls.DataTemplateSelector.GetElement(Windows.UI.Xaml.ElementFactoryGetArgs)
-api-type: winrt method
---

<!-- Method syntax.
public UIElement DataTemplateSelector.GetElement(ElementFactoryGetArgs args)
-->

# Windows.UI.Xaml.Controls.DataTemplateSelector.GetElement

## -description
Creates or retrieves an existing instance of the [UIElement](../windows.ui.xaml/uielement) object declared in the [DataTemplate](../windows.ui.xaml/datatemplate) returned by [SelectTemplate](datatemplateselector_selecttemplate_737484049).

## -parameters
### -param args
An instance of [ElementFactoryGetArgs](../windows.ui.xaml/elementfactorygetargs).

## -returns
An instance of the root [UIElement](../windows.ui.xaml/uielement) declared in the selected [DataTemplate](../windows.ui.xaml/datatemplate) or, NULL if the root of the selected [DataTemplate](../windows.ui.xaml/datatemplate) is not a [UIElement](../windows.ui.xaml/uielement).

## -remarks
For more info, see the remarks for the [DataTemplate.GetElement](../windows.ui.xaml/datatemplate_getelement_92222689) method.

## -see-also
* [IElementFactory](../windows.ui.xaml/ielementfactory)
* DataTemplate
  * [GetElement](../windows.ui.xaml/datatemplate_getelement_92222689)
  * [RecycleElement](../windows.ui.xaml/datatemplate_recycleelement_1023702976)
* DataTemplateSelector
  * [GetElement](../windows.ui.xaml.controls/datatemplateselector_getelement_92222689)
  * [RecycleElement](../windows.ui.xaml.controls/datatemplateselector_recycleelement_1023702976)

## -examples

