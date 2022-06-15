---
-api-id: P:Windows.UI.Xaml.ElementFactoryGetArgs.Data
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public object Data { get;  set; }
-->

# Windows.UI.Xaml.ElementFactoryGetArgs.Data

## -description

Gets or sets the data item for which an appropriate element tree should be realized when calling [GetElement](ielementfactory_getelement_92222689.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.ElementFactoryGetArgs.Data](/windows/winui/api/microsoft.ui.xaml.elementfactorygetargs.data) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

A reference to the data item for which a [UIElement](uielement.md) should be realized.

## -remarks

The implementation on [DataTemplate](datatemplate.md) for [GetElement](ielementfactory_getelement_92222689.md) does not use the Data value.

However, [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector.md)'s implementation does use the Data value as the *item* argument when it invokes the [SelectTemplate](../windows.ui.xaml.controls/datatemplateselector_selecttemplate_737484049.md) method.

## -see-also

[IElementFactory](ielementfactory.md), [DataTemplate.GetElement](/uwp/api/windows.ui.xaml.datatemplate.getelement), [DataTemplate.RecycleElement](/uwp/api/windows.ui.xaml.datatemplate.recycleelement), [DataTemplateSelector.GetElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.getelement), [DataTemplateSelector.RecycleElement](/uwp/api/windows.ui.xaml.controls.datatemplateselector.recycleelement), [ElementFactoryGetArgs](elementfactorygetargs.md), [ElementFactoryRecycleArgs](elementfactoryrecycleargs.md)

## -examples
