---
-api-id: P:Windows.UI.Xaml.ElementFactoryGetArgs.Data
-api-type: winrt property
---

<!-- Property syntax.
public object Data { get;  set; }
-->

# Windows.UI.Xaml.ElementFactoryGetArgs.Data

## -description
Gets or sets the data item for which an appropriate element tree should be realized when calling [GetElement](ielementfactory_getelement_92222689).

## -property-value
A reference to the data item for which a [UIElement](uielement) should be realized.

## -remarks
The implementation on [DataTemplate](datatemplate) for [GetElement](ielementfactory_getelement_92222689) does not use the [Data](elementfactorygetargs_data) value.

However, [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector)'s implementation does use the [Data](elementfactorygetargs_data) value as the *item* argument when it invokes the [SelectTemplate](../windows.ui.xaml.controls/datatemplateselector_selecttemplate_737484049) method.

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

