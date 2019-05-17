---
-api-id: M:Windows.UI.Xaml.IElementFactory.GetElement(Windows.UI.Xaml.ElementFactoryGetArgs)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public UIElement IElementFactory.GetElement(ElementFactoryGetArgs args)
-->

# Windows.UI.Xaml.IElementFactory.GetElement

## -description

Gets an [UIElement](uielement.md) object.

## -parameters

### -param args

An instance of [ElementFactoryGetArgs](elementfactorygetargs.md).

## -returns

A [UIElement](uielement.md) object.

## -remarks

When you call GetElement, the [UIElement](uielement.md) object that is returned can be added to the visual tree of another [UIElement](uielement.md). GetElement is not required to create a new instance each time it is invoked. The [UIElement](uielement.md) being returned may be an existing instance that has been prepared for re-use.  

For more info, see the remarks for the [DataTemplate.GetElement](datatemplate_getelement_92222689.md) method.

## -see-also

* DataTemplate
  * [GetElement](datatemplate_getelement_92222689.md)
  * [RecycleElement](datatemplate_recycleelement_1023702976.md)
* DataTemplateSelector
  * [GetElement](../windows.ui.xaml.controls/datatemplateselector_getelement_92222689.md)
  * [RecycleElement](../windows.ui.xaml.controls/datatemplateselector_recycleelement_1023702976.md)

## -examples
