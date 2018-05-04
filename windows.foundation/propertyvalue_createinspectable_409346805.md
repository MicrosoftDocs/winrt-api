---
-api-id: M:Windows.Foundation.PropertyValue.CreateInspectable(System.Object)
-api-type: winrt method
---

<!-- Method syntax
public object CreateInspectable(System.Object value)
-->

# Windows.Foundation.PropertyValue.CreateInspectable

## -description
Supplies the property value representation of an inspectable object. Since an object is a reference type, it is also a valid property value and does not need to be boxed. Instead, this method returns the object provided without modification. An object can be set as a property value without first calling this method.

## -parameters
### -param value
The object to store in the property value. The value must be non-null.

## -returns
The property value.

## -remarks

## -examples

## -see-also
