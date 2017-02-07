---
-api-id: T:Windows.UI.Xaml.Media.DoubleCollection
-api-type: winrt class
---

<!-- Class syntax.
public class DoubleCollection : Windows.Foundation.Collections.IIterable<System.Double>, Windows.Foundation.Collections.IVector<System.Double>
-->

# Windows.UI.Xaml.Media.DoubleCollection

## -description
Represents an ordered collection of [Double](https://msdn.microsoft.com/library/system.double.aspx) values.

## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A [DoubleCollection](doublecollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<Double>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](XREF:TODO:M:System.Collections.Generic.IEnumerable`1.GetEnumerator), cast to [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) with a [Double](https://msdn.microsoft.com/library/system.double.aspx) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IList`1)