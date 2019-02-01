---
-api-id: T:Windows.UI.Xaml.PropertyPath
-api-type: winrt class
---

<!-- Class syntax.
public class PropertyPath : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.IPropertyPath
-->

# Windows.UI.Xaml.PropertyPath

## -description
Implements a data structure for describing a property as a path below another property, or below an owning type. Property paths are used in data binding to objects.

## -remarks
The main reason you might work with a [PropertyPath](propertypath.md) object is to clone existing binding properties and use them somewhere else:
+ Get the [Path](propertypath_path_1221375020.md) from an existing binding ([Binding.Path](../windows.ui.xaml.data/binding_path.md)).
+ Use that string value to construct a new [PropertyPath](propertypath.md).
+ Create a new [Binding](../windows.ui.xaml.data/binding.md). Use the new [PropertyPath](propertypath.md) for its [Binding.Path](../windows.ui.xaml.data/binding_path.md) (and probably adjust some other properties too).
+ Apply the new [Binding](../windows.ui.xaml.data/binding.md) to a different object-property combination, using [SetBinding](frameworkelement_setbinding_28713777.md).


Animation targeting also uses a property path concept, as documented in the [Property-path syntax](https://msdn.microsoft.com/library/ff3ecf47-d81f-46e3-be01-c839e0398025) topic. However, animation targeting doesn't use [PropertyPath](propertypath.md) as the underlying type, it expresses the paths as strings and uses strings for all related API calls.

## -examples

## -see-also
[DependencyObject](dependencyobject.md), [Property-path syntax](https://msdn.microsoft.com/library/ff3ecf47-d81f-46e3-be01-c839e0398025), [{Binding} markup extension](https://msdn.microsoft.com/library/3bafe7b5-af33-487f-9ad5-beafd65d04c3)
