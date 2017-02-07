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

An [ItemCollection](itemcollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](XREF:TODO:M:System.Collections.Generic.IEnumerable`1.GetEnumerator), cast to [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) with an [Object](https://msdn.microsoft.com/library/system.object.aspx) or [FrameworkElement](../windows.ui.xaml/frameworkelement.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[ItemsControl](itemscontrol.md), [IObservableVector&lt;T&gt;](../windows.foundation.collections/iobservablevector_1.md), [IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IList`1)