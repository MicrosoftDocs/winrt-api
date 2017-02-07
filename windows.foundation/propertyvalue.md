---
-api-id: T:Windows.Foundation.PropertyValue
-api-type: winrt class
---

<!-- Class syntax.
public class PropertyValue 
-->

# Windows.Foundation.PropertyValue

## -description
Represents a value in a property store (such as a [PropertySet](../windows.foundation.collections/propertyset.md) instance).

## -remarks
[PropertyValue](propertyvalue.md) represents the value portion of a property that typically has a string name, and some value. There are multiple properties in a property set, and each property potentially has a different value type, so from a collection standpoint the collection is mixed, not strongly typed. The [PropertySet](../windows.foundation.collections/propertyset.md) class and the [IPropertySet](../windows.foundation.collections/ipropertyset.md) interface are existing interfaces or implementations that use this model and use a [PropertyValue](propertyvalue.md) as the value part of a key-value pair. [IPropertySet](../windows.foundation.collections/ipropertyset.md) is the type of various Windows Runtime properties where the goal is to provide your app with a *property bag* of properties that are conceptually related in their origin, but each property might (and often does) use a different value type.

When used by other Windows Runtime APIs and their signatures, values are often passed as the [IPropertyValue](ipropertyvalue.md) interface rather than as the [PropertyValue](propertyvalue.md) type.

In addition to representing the value itself, [PropertyValue](propertyvalue.md) defines utility methods that populate a [PropertyValue](propertyvalue.md) instance. Calling these utility methods from app code is uncommon. The methods create a boxed value, and in this aspect a [PropertyValue](propertyvalue.md) instance functions similarly to the **VARIANT** concept from Component Object Model (COM). Each method has a matched method that creates an array of values as opposed to a single value.

## -examples

## -see-also
[PropertyType](propertytype.md), [IPropertyValue](ipropertyvalue.md), [Windows.Foundation.Collections.PropertySet](../windows.foundation.collections/propertyset.md)