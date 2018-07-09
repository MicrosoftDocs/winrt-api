---
-api-id: M:Windows.UI.Xaml.IElementFactory.GetElement(Windows.UI.Xaml.ElementFactoryGetArgs)
-api-type: winrt method
---

<!-- Method syntax.
public UIElement IElementFactory.GetElement(ElementFactoryGetArgs args)
-->

# Windows.UI.Xaml.IElementFactory.GetElement

## -description
Gets an [UIElement](uielement) object.

## -parameters
### -param args
An instance of [ElementFactoryGetArgs](elementfactorygetargs).

## -returns
A [UIElement](uielement) object.

## -remarks
When you call [GetElement](ielementfactory_getelement_92222689), the [UIElement](uielement) object that is returned can be added to the visual tree of another [UIElement](uielement).  [GetElement](ielementfactory_getelement_92222689) is not required to create a new instance each time it is invoked.  The [UIElement](uielement) being returned may be an existing instance that has been prepared for re-use.  

For more info, see the remarks for the [DataTemplate.GetElement](datatemplate_getelement_92222689) method.

## -see-also
* DataTemplate
  * [GetElement](datatemplate_getelement_92222689)
  * [RecycleElement](datatemplate_recycleelement_1023702976)
* DataTemplateSelector
  * [GetElement](../windows.ui.xaml.controls/datatemplateselector_getelement_92222689)
  * [RecycleElement](../windows.ui.xaml.controls/datatemplateselector_recycleelement_1023702976)


## -examples

