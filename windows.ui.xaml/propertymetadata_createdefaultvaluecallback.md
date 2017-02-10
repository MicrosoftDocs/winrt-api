---
-api-id: P:Windows.UI.Xaml.PropertyMetadata.CreateDefaultValueCallback
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.CreateDefaultValueCallback CreateDefaultValueCallback { get; }
-->

# Windows.UI.Xaml.PropertyMetadata.CreateDefaultValueCallback

## -description
Gets a reference to the callback method that provides a default property value.

## -property-value
A reference to the callback method that provides a default property value.

## -remarks
Use a [CreateDefaultValueCallback](createdefaultvaluecallback.md) instead of a fixed constant default value in any case where the default value of a dependency property might be thread-bound. The [CreateDefaultValueCallback](createdefaultvaluecallback.md) becomes a factory for default values whenever there is a need to get default values of properties on threads other than the main UI thread.

In order to establish a [CreateDefaultValueCallback](createdefaultvaluecallback.md) pattern for a dependency property, use one of the static [Create](propertymetadata_create.md) methods instead of using the [PropertyMetadata](propertymetadata_propertymetadata.md) constructor when you define the metadata for the property. That metadata is submitted to the [Register](dependencyproperty_register.md) call. For more info, see [Custom dependency properties](http://msdn.microsoft.com/library/5adf7935-f2cf-4bb6-b1a5-f535c2ed8ef8). As with a property-changed callback, the [CreateDefaultValueCallback](createdefaultvaluecallback.md) method should be a static method of the type that registers the dependency property. The method does not have to be public.

## -examples

## -see-also
[DependencyProperty.Register](dependencyproperty_register.md), [Custom dependency properties](http://msdn.microsoft.com/library/5adf7935-f2cf-4bb6-b1a5-f535c2ed8ef8)