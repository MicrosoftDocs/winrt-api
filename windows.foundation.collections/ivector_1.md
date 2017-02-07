---
-api-id: T:Windows.Foundation.Collections.IVector`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IVector<T> : Windows.Foundation.Collections.IIterable<T>
-->

# Windows.Foundation.Collections.IVector<T>

## -description
Represents a random-access collection of elements.



> **.NET**
> This interface appears to .NET code as [System.Collections.Generic.IList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.List`1) due to .NET language projection. In any case where a Windows Runtime type has implemented [IVector&lt;T&gt;](ivector_1.md), .NET code can use the APIs of [IList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.List`1) instead.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.List`1) interface if they want to implement a vector/list type. In any case where a Windows Runtime type has implemented [IVector&lt;T&gt;](ivector_1.md), .NET code can use the APIs of [IList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.List`1) instead. This includes all the existing Windows Runtime API and also scenarios such as using the APIs of Windows Runtime components originally implemented in Visual C++ component extensions (C++/CX) from a C# or Visual Basic app.

The [IVector&lt;T&gt;](ivector_1.md) interface represents a collection of objects of a specified type that can be individually accessed by index. Properties and methods of [IVector&lt;T&gt;](ivector_1.md) support list-type functionality, such as getting the size of the collection, and adding and removing items at specified locations in the collection. Additionally, the [GetView](ivector_1_getview.md) method provides a snapshot of the vector whose observable state does not change. The snapshot is useful when you need a view of the collection to refer to in subsequent operations that involve [IVector&lt;T&gt;](ivector_1.md).

### Interface inheritance

[IVector](ivector_1.md) inherits [IIterable](iiterable_1.md). Types that implement [IVector](ivector_1.md) also implement the interface members of [IIterable](iiterable_1.md). Similarly, if you're using .NET, there is support for [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1).

## -examples

## -see-also
[Collections ()](XREF:TODO:914da30b-aac5-4cd7-9da3-a5ac08cdd72c), [System.Collections.Generic.IList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.List`1)