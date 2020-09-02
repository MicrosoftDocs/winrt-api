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
> This interface appears to .NET code as [System.Collections.Generic.IList<T>](/dotnet/api/system.collections.generic.ilist-1) due to .NET language projection. In any case where a Windows Runtime type has implemented IVector&lt;T&gt;, .NET code can use the APIs of [IList<T>](/dotnet/api/system.collections.generic.ilist-1) instead.

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IList<T>](/dotnet/api/system.collections.generic.ilist-1) interface if they want to implement a vector/list type. In any case where a Windows Runtime type has implemented IVector&lt;T&gt;, .NET code can use the APIs of [IList<T>](/dotnet/api/system.collections.generic.ilist-1) instead. This includes all the existing Windows Runtime API and also scenarios such as using the APIs of Windows Runtime components originally implemented in Visual C++ component extensions (C++/CX) from a C# or Visual Basic app.

The IVector&lt;T&gt; interface represents a collection of objects of a specified type that can be individually accessed by index. Properties and methods of IVector&lt;T&gt; support list-type functionality, such as getting the size of the collection, and adding and removing items at specified locations in the collection. Additionally, the [GetView](ivector_1_getview_37498667.md) method provides a snapshot of the vector whose observable state does not change. The snapshot is useful when you need a view of the collection to refer to in subsequent operations that involve IVector&lt;T&gt;.

### Interface inheritance

IVector inherits [IIterable](iiterable_1.md). Types that implement IVector also implement the interface members of [IIterable](iiterable_1.md). Similarly, if you're using .NET, there is support for [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1).

## -examples

## -see-also
[Collections (C++/CX)](/cpp/cppcx/collections-c-cx), [System.Collections.Generic.IList<T>](/dotnet/api/system.collections.generic.ilist-1)
