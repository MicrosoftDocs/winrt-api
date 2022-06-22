---
-api-id: T:Windows.UI.Xaml.SetterBaseCollection
-api-type: winrt class
---

<!-- Class syntax.
public class SetterBaseCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.SetterBase>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.SetterBase>, Windows.UI.Xaml.ISetterBaseCollection
-->

# Windows.UI.Xaml.SetterBaseCollection

## -description
Represents a collection of objects that inherit from [SetterBase](setterbase.md).



## -xaml-syntax
```xaml
<Style ...>
  oneOrMoreSetters
</Style>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A SetterBaseCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<SetterBase>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [SetterBase](setterbase.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)
