---
-api-id: T:Windows.UI.Xaml.Controls.ItemCollection
-api-type: winrt class
---

<!-- Class syntax.
public class ItemCollection : Windows.Foundation.Collections.IIterable<System.Object>, Windows.Foundation.Collections.IObservableVector<System.Object>, Windows.Foundation.Collections.IVector<System.Object>
-->

# Windows.UI.Xaml.Controls.ItemCollection

## -description
Holds the list of items that represent the content of an [ItemsControl](itemscontrol.md).



## -xaml-syntax
```xaml
<ItemsControl>
  oneOrMoreFrameworkElements
</ItemsControl>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

An ItemCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true)with an [Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true) or [FrameworkElement](../windows.ui.xaml/frameworkelement.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[ItemsControl](itemscontrol.md), [IObservableVector&lt;T&gt;](../windows.foundation.collections/iobservablevector_1.md), [IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable_t_), [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)
