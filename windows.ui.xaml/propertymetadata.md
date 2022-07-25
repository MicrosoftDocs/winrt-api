---
-api-id: T:Windows.UI.Xaml.PropertyMetadata
-api-type: winrt class
---

<!-- Class syntax.
public class PropertyMetadata : Windows.UI.Xaml.IPropertyMetadata
-->

# Windows.UI.Xaml.PropertyMetadata

## -description
Defines behavior aspects of a dependency property, including conditions it was registered with. For more info on how PropertyMetadata is used for dependency properties, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).

## -remarks
Defining a PropertyMetadata instance is part of the scenario for defining a custom dependency property. For info and examples, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).

A PropertyMetadata value represents two aspects of dependency property behavior:
+ Provides a default value, which is used as the value of the property unless the owner type specifically initializes the value, or the value is set by user code or other mechanisms.
+ References a callback that is invoked if the dependency property system detects that the dependency property has changed.
 Typically, a dependency property only needs a PropertyMetadata value if one or both of these behaviors is desired. Otherwise, a value of **null** can be passed for the *propertyMetadata* parameter when a dependency property is registered with the dependency property system. For more info, see [DependencyProperty.Register](dependencyproperty_register_1826645607.md).

If your PropertyMetadata includes a property-changed callback reference, that method must be a static method of the class that exposes the [DependencyProperty](dependencyproperty.md) identifier where that PropertyMetadata is applied. How to write this method is described in [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties) and also the reference topic for the [PropertyChangedCallback](propertychangedcallback.md) delegate. 

> [!NOTE]
> Once created, a PropertyMetadata instance doesn't have a property that can be used to find the callback or even to determine the callback's method name. That information is considered an implementation detail of a dependency property and only the dependency property system itself needs to be able to invoke that method.

### Instantiating a PropertyMetadata value

There are two methods that can instantiate a PropertyMetadata instance: a constructor, and a static [PropertyMetadata.Create](propertymetadata_create_1554665429.md) method. Each of these methods has multiple signatures. It's more common to use the constructors. However, you must use [PropertyMetadata.Create](propertymetadata_create_1554665429.md) if you want the default value mechanism for your dependency property to be thread-safe. For more info, see the "Property metadata for a custom dependency property" section of the [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties) topic.

## -examples
This example calls the [PropertyMetadata(Object)](propertymetadata_propertymetadata_365528641.md) constructor, which creates a PropertyMetadata that reports a default value for a [DependencyProperty](dependencyproperty.md). The PropertyMetadata is then used for an attached property registration when [RegisterAttached](dependencyproperty_registerattached_1163670284.md) is called.



[!code-csharp[DOMain](../windows.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDOMain)]

[!code-vb[DOMain](../windows.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDOMain)]

## -see-also
[DependencyProperty.Register](dependencyproperty_register_1826645607.md), [PropertyChangedCallback](propertychangedcallback.md), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties)
7935-f2cf-4bb6-b1a5-f535c2ed8ef8)
