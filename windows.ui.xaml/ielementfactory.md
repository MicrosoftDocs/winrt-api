---
-api-id: T:Windows.UI.Xaml.IElementFactory
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IElementFactory 
-->

# Windows.UI.Xaml.IElementFactory

## -description
Supports the creation and recycling of [UIElement](uielement) objects.

## -remarks
Two concrete implementations of this interface are:
1. [DataTemplate](datatemplate), and
2. [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector)

The [GetElement](ielementfactory_getelement_92222689) is used to retrieve a valid instance of a [UIElement](uielement).  The [RecycleElement](ielementfactory_recycleelement_1023702976) method is used to recycle elements.

## -see-also
* [DataTemplate](datatemplate)
* [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector)

## -examples

