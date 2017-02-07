---
-api-id: T:Windows.Foundation.IPropertyValue
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IPropertyValue : 
-->

# Windows.Foundation.IPropertyValue

## -description
Represents a value in a property store. You can't implement this interface, see Remarks.

## -remarks
The [IPropertyValue](ipropertyvalue.md) interface is a store for values whose type is not known until runtime.

To obtain the value stored in an [IPropertyValue](ipropertyvalue.md) object, when the type of the stored property is not known ahead of time, you should first determine the stored type from the [Type](ipropertyvalue_type.md) property and then call the appropriate [IPropertyValue](ipropertyvalue.md) method for the type.

If the type is known ahead of time, you can the type access method of [IPropertyValue](ipropertyvalue.md) interface directory and check for the return value to verify type returned was what is expected. If the type returned does not match the value of the [Type](ipropertyvalue_type.md) property then the method fails with the **TYPE_E_TYPEMISMATCH** error.

You can't implement the [IPropertyValue](ipropertyvalue.md) interface or include it in a signature. [IPropertyValue](ipropertyvalue.md) is mainly an internal implementation detail of how the Windows Runtime implements boxing and nullable values.

## -examples

## -see-also