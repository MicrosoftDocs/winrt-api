---
-api-id: M:Windows.UI.Xaml.Controls.DataTemplateSelector.GetElement(Windows.UI.Xaml.ElementFactoryGetArgs)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public UIElement DataTemplateSelector.GetElement(ElementFactoryGetArgs args)
-->

# Windows.UI.Xaml.Controls.DataTemplateSelector.GetElement

## -description

Creates or retrieves an existing instance of the [UIElement](../windows.ui.xaml/uielement.md) object declared in the [DataTemplate](../windows.ui.xaml/datatemplate.md) returned by [SelectTemplate](datatemplateselector_selecttemplate_737484049.md).



## -parameters

### -param args

An instance of [ElementFactoryGetArgs](../windows.ui.xaml/elementfactorygetargs.md).

## -returns

An instance of the root [UIElement](../windows.ui.xaml/uielement.md) declared in the selected [DataTemplate](../windows.ui.xaml/datatemplate.md) or, **null** if the root of the selected [DataTemplate](../windows.ui.xaml/datatemplate.md) is not a [UIElement](../windows.ui.xaml/uielement.md).

## -remarks

For more info, see the remarks for the [DataTemplate.GetElement](../windows.ui.xaml/datatemplate_getelement_92222689.md) method.

## -see-also

[IElementFactory](../windows.ui.xaml/ielementfactory.md), [DataTemplate.GetElement](/uwp/api/windows.ui.xaml.datatemplate.getelement), [DataTemplate.RecycleElement](/uwp/api/windows.ui.xaml.datatemplate.recycleelement), [DataTemplateSelector.RecycleElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.recycleelement)

## -examples
