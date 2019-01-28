---
-api-id: P:Windows.UI.Xaml.ElementFactoryRecycleArgs.Parent
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public UIElement Parent { get;  set; }
-->

# Windows.UI.Xaml.ElementFactoryRecycleArgs.Parent

## -description

Gets or sets a reference to the current parent [UIElement](uielement.md) of the element being recycled.

## -property-value

The parent [UIElement](uielement.md) object or **null**.  By default, it is **null**.

## -remarks

This value is optional. When provided it can enable a performance optimization for implementations of [GetElement](ielementfactory_getelement_92222689.md) that return recycled elements.  For more info, see the remarks for the [DataTemplate.RecycleElement](datatemplate_recycleelement_1023702976.md) method.

## -see-also

* [IElementFactory](ielementfactory.md)
* DataTemplate
  * [GetElement](datatemplate_getelement_92222689.md)
  * [RecycleElement](datatemplate_recycleelement_1023702976.md)
* DataTemplateSelector
  * [GetElement](../windows.ui.xaml.controls/datatemplateselector_getelement_92222689.md)
  * [RecycleElement](../windows.ui.xaml.controls/datatemplateselector_recycleelement_1023702976.md)
* [ElementFactoryGetArgs](elementfactorygetargs.md)
* [ElementFactoryRecycleArgs](elementfactoryrecycleargs.md)

## -examples
