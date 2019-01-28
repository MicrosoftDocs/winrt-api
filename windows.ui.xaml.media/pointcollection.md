---
-api-id: T:Windows.UI.Xaml.Media.PointCollection
-api-type: winrt class
---

<!-- Class syntax.
public class PointCollection : Windows.Foundation.Collections.IIterable<Windows.Foundation.Point>, Windows.Foundation.Collections.IVector<Windows.Foundation.Point>
-->

# Windows.UI.Xaml.Media.PointCollection

## -description
Represents a collection of [Point](../windows.foundation/point.md) values that can be individually accessed by index.

## -xaml-syntax
```xaml
<object property="oneOrMorePoints"/>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A [PointCollection](pointcollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<Point>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) with a [Point](../windows.foundation/point.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable<T>](https://docs.microsoft.com/uwp/api/windows.foundation.collections.iiterable_t_), [IList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IList`1)