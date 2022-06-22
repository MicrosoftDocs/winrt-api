---
-api-id: T:Windows.UI.Xaml.IElementFactory
-api-type: winrt interface
ms.custom: RS5
---

<!-- Interface syntax.
public interface IElementFactory 
-->

# Windows.UI.Xaml.IElementFactory

## -description

Supports the creation and recycling of [UIElement](uielement.md) objects.



## -remarks

Two concrete implementations of this interface are:

1. [DataTemplate](datatemplate.md), and
1. [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector.md)

The [GetElement](ielementfactory_getelement_92222689.md) method is used to retrieve a valid instance of a [UIElement](uielement.md). The [RecycleElement](ielementfactory_recycleelement_1023702976.md) method is used to recycle elements.

## -see-also

[DataTemplate](datatemplate.md), [DataTemplateSelector](../windows.ui.xaml.controls/datatemplateselector.md)

## -examples

