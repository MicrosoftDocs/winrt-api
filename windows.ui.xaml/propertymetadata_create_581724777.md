---
-api-id: M:Windows.UI.Xaml.PropertyMetadata.Create(Windows.UI.Xaml.CreateDefaultValueCallback)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.PropertyMetadata Create(Windows.UI.Xaml.CreateDefaultValueCallback createDefaultValueCallback)
-->

# Windows.UI.Xaml.PropertyMetadata.Create

## -description
Creates a [PropertyMetadata](propertymetadata.md) value, specifying a callback that establishes a default value for a dependency property.

## -parameters
### -param createDefaultValueCallback
A reference to the callback method that provides a default property value.

## -returns
The newly created dependency property metadata.

## -remarks
Use a [CreateDefaultValueCallback](createdefaultvaluecallback.md) instead of a fixed constant default value in any case where the default value of a dependency property might be thread-bound. The [CreateDefaultValueCallback](createdefaultvaluecallback.md) becomes a factory for default values whenever there is a need to get default values of properties on threads other than the main UI thread.

In order to establish a [CreateDefaultValueCallback](createdefaultvaluecallback.md) pattern for a dependency property, use one of the static [Create](propertymetadata_create_1554665429.md) methods instead of using the [PropertyMetadata](propertymetadata_propertymetadata_1183178341.md) constructor when you define the metadata for the property. That metadata is submitted to the [Register](dependencyproperty_register_1826645607.md) call. For more info, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties). As with a property-changed callback, the [CreateDefaultValueCallback](createdefaultvaluecallback.md) method should be a static method of the type that registers the dependency property. The method does not have to be public.

## -examples
This example shows pseudocode for using [CreateDefaultValueCallback](propertymetadata_createdefaultvaluecallback.md) in a custom dependency property scenario. Specifically, this creates [PropertyMetadata](propertymetadata.md) to be used in a [DependencyProperty.Register](dependencyproperty_register_1826645607.md) call (not shown).

```csharp
PropertyMetadata metadata = PropertyMetadata.Create(
    new CreateDefaultValueCallback(() =>
    {
        return new CustomClass() //a DependencyObject
        {
            CustomProperty1 = "default", //DependencyProperty of type String 
            CustomProperty2 = -1; //DependencyProperty of type Int32
        }
    })

```



## -see-also
[Create(Object)](propertymetadata_create_1554665429.md), [Create(Object, PropertyChangedCallback)](propertymetadata_create_266737649.md), [Create(CreateDefaultValueCallback, PropertyChangedCallback)](propertymetadata_create_1910518349.md), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
