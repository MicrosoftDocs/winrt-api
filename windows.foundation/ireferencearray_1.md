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
You can't implement the [IReferenceArray](ireferencearray_1.md) interface or include it in a signature. [IReferenceArray](ireferencearray_1.md) is mainly an internal implementation detail of how the Windows Runtime implements boxing and nullable values.

(C++ only) In C++, this interface is exposed as [Platform::IBoxArray&lt;T&gt;](http://msdn.microsoft.com/library/6cd82c9e-4230-4147-9edb-7a652875dbf1). In scenarios such as XAML data-binding in which a collection of either reference types or value types is passed as type Platform::Object^, you can use safe_cast to convert the object to IBoxArray, and then use the [IBoxArray::Value](http://msdn.microsoft.com/library/96f33f35-5e3f-459c-b35e-c7d53d315fc7) property to access the strongly typed Platform::Array object that contains the elements of the collection.

### Interface inheritance

[IReferenceArray](ireferencearray_1.md) inherits [IPropertyValue](ipropertyvalue.md). Types that implement [IReferenceArray](ireferencearray_1.md) also implement the interface members of [IPropertyValue](ipropertyvalue.md).

## -examples

## -see-also
[IPropertyValue](ipropertyvalue.md), [Nullable&lt;T&gt;](https://msdn.microsoft.com/library/windows/apps/b3h38hb0)