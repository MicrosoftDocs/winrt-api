---
-api-id: T:Windows.UI.Xaml.CreateDefaultValueCallback
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate object CreateDefaultValueCallback()
-->
# Windows.UI.Xaml.CreateDefaultValueCallback

## -description
Represents the method that can be invoked as part of a [PropertyMetadata](propertymetadata.md) constructor to defer definition of a dependency property default value.



## -returns
The desired default value.

## -remarks
When you register a custom dependency property, you can supply metadata (a [PropertyMetadata](propertymetadata.md) value) that provides a default value for all uses of the dependency property. Many times it's adequate to provide that value directly in metadata as an immediate value. This will always work for any value-type value, for example specifying a default value of -1 for an **int** value property. However, if you want to report a default value for a property that's a reference property, such as a [DependencyObject](dependencyobject.md) value, you can encounter a threading problem that's related to how dependency properties work. All [DependencyObject](dependencyobject.md) objects are always created on a UI thread. But it's possible that the thread that registers the property and the thread that eventually uses an instance of the object and tries to access the default aren't the same UI thread. If you provide a [CreateDefaultValueCallback](propertymetadata_createdefaultvaluecallback.md) in your [PropertyMetadata](propertymetadata.md) rather than a fixed instance, the default value of the property is created just-in-time and is guaranteed to be acccessible by the thread that's actually using the property. In other words the property as registers deferred what the default value is, but the property as used can now provide a thread-safe default value.

A typical [CreateDefaultValueCallback](propertymetadata_createdefaultvaluecallback.md) should do nothing more than call a constructor for the reference type that's used as a value, and set properties of that reference type, then return it.

To specify a [CreateDefaultValueCallback](propertymetadata_createdefaultvaluecallback.md) within a [PropertyMetadata](propertymetadata.md) instance, you must use [PropertyMetadata.Create](propertymetadata_create_1554665429.md) to create the instance, not a [PropertyMetadata](propertymetadata.md) constructor.

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
[Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [DependencyProperty.Register](dependencyproperty_register_1826645607.md), [PropertyMetadata](propertymetadata.md)
