---
-api-id: T:Windows.Foundation.Collections.IIterable`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IIterable<T> : 
-->

# Windows.Foundation.Collections.IIterable<T>

## -description
Exposes an iterator that supports simple iteration over a collection of a specified type.



> **.NET**
> This interface appears as [System.Collections.Generic.IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1). In any case where a Windows Runtime type has implemented IIterable&lt;T&gt;, .NET code can use the APIs of [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) instead. C# code can use **foreach**, Visual Basic code can use **For Each...Next**. All the .NET extension methods that are based on [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) and included in .NET for UWP apps are accessible (including the **System.Linq** extensions, so long as you've included the namespace).

## -remarks
When programming with .NET, this interface is hidden and developers should use the [System.Collections.Generic.IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) interface. Because of how the projections were done, the [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator) method isn't always available as a direct callable method on the types that project [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) as implemented, but enumerating the collection with the standard enumeration syntax (**foreach**) is still supported. The compiler does the type-casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator) from a class, cast to [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1), using a constraint in the cast that matches the item type of the collection.

## -examples

## -see-also
[IIterator&lt;T&gt;](iiterator_1.md)
