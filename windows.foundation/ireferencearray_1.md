---
-api-id: T:Windows.Foundation.IReferenceArray`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IReferenceArray<T> : Windows.Foundation.IPropertyValue
-->

# Windows.Foundation.IReferenceArray<T>

## -description
Enables arbitrary enumerations, structures, and delegate types to be used as an array of property values. You can't implement this interface, see Remarks.

## -remarks
You can't implement the IReferenceArray interface or include it in a signature. IReferenceArray is mainly an internal implementation detail of how the Windows Runtime implements boxing and nullable values.

(C++/CX only) In C++/CX, this interface is exposed as [Platform::IBoxArray&lt;T&gt;](/cpp/cppcx/platform-iboxarray-interface). In scenarios such as XAML data-binding in which a collection of either reference types or value types is passed as type Platform::Object^, you can use safe_cast to convert the object to IBoxArray, and then use the [IBoxArray::Value](/cpp/cppcx/platform-array-class#value) property to access the strongly typed Platform::Array object that contains the elements of the collection.

### Interface inheritance

IReferenceArray inherits [IPropertyValue](ipropertyvalue.md). Types that implement IReferenceArray also implement the interface members of [IPropertyValue](ipropertyvalue.md).

## -examples

## -see-also
[IPropertyValue](ipropertyvalue.md), [Nullable&lt;T&gt;](/dotnet/api/system.nullable-1?view=dotnet-uwp-10.0&preserve-view=true)
