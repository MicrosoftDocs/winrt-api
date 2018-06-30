---
-api-id: P:Windows.UI.Xaml.ElementFactoryRecycleArgs.Parent
-api-type: winrt property
---

<!-- Property syntax.
public UIElement Parent { get;  set; }
-->

# Windows.UI.Xaml.ElementFactoryRecycleArgs.Parent

## -description
Gets or sets a reference to the current parent [UIElement](uielement) of the element being recycled.

## -property-value
The parent [UIElement](uielement) object or **null**.  By default, it is **null**.

## -remarks
This value is optional.  When provided it can enable a performance optimization for implementations of [GetElement](ielementfactory_getelement_92222689) that return recycled elements.  For more info, see the remarks for the [DataTemplate.RecycleElement](datatemplate_recycleelement_1023702976) method.

## -see-also
* [IElementFactory](ielementfactory)
* DataTemplate
  * [GetElement](datatemplate_getelement_92222689)
  * [RecycleElement](datatemplate_recycleelement_1023702976)
* DataTemplateSelector
  * [GetElement](../windows.ui.xaml.controls/datatemplateselector_getelement_92222689)
  * [RecycleElement](../windows.ui.xaml.controls/datatemplateselector_recycleelement_1023702976)
* [ElementFactoryGetArgs](elementfactorygetargs)
* [ElementFactoryRecycleArgs](elementfactoryrecycleargs)


## -examples

