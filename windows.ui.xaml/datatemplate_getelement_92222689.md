---
-api-id: M:Windows.UI.Xaml.DataTemplate.GetElement(Windows.UI.Xaml.ElementFactoryGetArgs)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public UIElement DataTemplate.GetElement(ElementFactoryGetArgs args)
-->

# Windows.UI.Xaml.DataTemplate.GetElement

## -description

Creates or retrieves an existing instance of the [UIElement](uielement.md) object declared in the [DataTemplate](datatemplate.md).



## -parameters

### -param args

An instance of [ElementFactoryGetArgs](elementfactorygetargs.md).

## -returns

An instance of the root [UIElement](uielement.md) declared in the [DataTemplate](datatemplate.md) or **null** if the root of the DataTemplate is not a UIElement.

## -remarks

The [DataTemplate](datatemplate.md) acts as a factory that generates the element object declared in its template. Unlike the [LoadContent](datatemplate_loadcontent_471913183.md) method that creates a new instance every time it is invoked, the GetElement method may either create a new instance or return an existing instance that was recycled via [RecycleElement](datatemplate_recycleelement_1023702976.md).

The **DataTemplate**'s implementation of GetElement does not use the [Data](elementfactorygetargs_data.md) value from the [ElementFactoryGetArgs](elementfactorygetargs.md). The [Data](elementfactorygetargs_data.md) property exists for implementations such as [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector.md) where it is used to decide from which [DataTemplate](datatemplate.md) to load content.  

## -see-also

[IElementFactory](ielementfactory.md), [DataTemplate.RecycleElement](/uwp/api/windows.ui.xaml.datatemplate.recycleelement), [DataTemplateSelector.GetElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.getelement), [DataTemplateSelector.RecycleElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.recycleelement)

## -examples

