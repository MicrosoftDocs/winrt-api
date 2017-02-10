---
-api-id: T:Windows.UI.Xaml.Media.BrushCollection
-api-type: winrt class
---

<!-- Class syntax.
public class BrushCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.Brush>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.Brush>
-->

# Windows.UI.Xaml.Media.BrushCollection

## -description
Represents an ordered collection of [Brush](brush.md) values.

## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A [BrushCollection](brushcollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<Brush>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](XREF:TODO:M:System.Collections.Generic.IEnumerable`1.GetEnumerator), cast to [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) with a [Brush](brush.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector(Brush)](../windows.foundation.collections/ivector_1.md), [IIterable(Brush)](../windows.foundation.collections/iiterable_1.md)