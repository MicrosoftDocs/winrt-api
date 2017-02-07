---
-api-id: T:Windows.Foundation.Collections.IVectorView`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IVectorView<T> : Windows.Foundation.Collections.IIterable<T>
-->

# Windows.Foundation.Collections.IVectorView<T>

## -description
Represents an immutable view into a vector.



> **.NET**
> This interface appears to .NET code as [System.Collections.Generic.IReadOnlyList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IReadOnlyList`1) due to .NET language projection. In any case where a Windows Runtime type has implemented [IVectorView&lt;T&gt;](ivectorview_1.md), .NET code can use the APIs of [IReadOnlyList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IReadOnlyList`1) instead.

## -remarks
For read-write collections, the [IVectorView&lt;T&gt;](ivectorview_1.md) interface is still relevant, because the [IVector.GetView](ivector_1_getview.md) method returns an [IVectorView&lt;T&gt;](ivectorview_1.md) instance.

When programming with .NET, this interface is hidden and developers should use the  interface if they want to implement a read-only vector/list type. In any case where a Windows Runtime type has implemented [IVectorView&lt;T&gt;](ivectorview_1.md), .NET code can use the APIs of  instead. This includes all the existing Windows Runtime API and also scenarios such as using the APIs of Windows Runtime components originally implemented in Visual C++ component extensions (C++/CX) from a C# or Visual Basic app.

### Interface inheritance

[IVectorView](ivectorview_1.md) inherits [IIterable](iiterable_1.md). Types that implement [IVectorView](ivectorview_1.md) also implement the interface members of [IIterable](iiterable_1.md). Similarly, if you're using .NET, there is support for [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1).

## -examples

## -see-also
[IIterable&lt;T&gt;](iiterable_1.md), [IVector.GetView](ivector_1_getview.md), , [Collections ()](XREF:TODO:914da30b-aac5-4cd7-9da3-a5ac08cdd72c)