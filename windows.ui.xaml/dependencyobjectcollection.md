---
-api-id: T:Windows.UI.Xaml.DependencyObjectCollection
-api-type: winrt class
---

<!-- Class syntax.
public class DependencyObjectCollection : Windows.UI.Xaml.DependencyObject, Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.DependencyObject>, Windows.Foundation.Collections.IObservableVector<Windows.UI.Xaml.DependencyObject>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.DependencyObject>
-->

# Windows.UI.Xaml.DependencyObjectCollection

## -description
Implements a practical collection class that can contain [DependencyObject](dependencyobject.md) items.

## -remarks
The purpose of the [DependencyObjectCollection](dependencyobjectcollection.md) class is mainly to support the tooling and portability of behaviors. Behaviors are a technique for defining certain basic interactions of a UI element entirely in XAML, without requiring an event handler and code-behind.

If you're interested in implementing a business object class that supports collection-changed notifications you should use **ObservableCollection** or one of the interface patterns that supports changed events. For more info see [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011).


<!--TODO link a doc on behaviors; TODO make a further statement about how this type isn't really meant to be a catch-all for binding source, should use ObservableCollection instead.-->

<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A [DependencyObjectCollection](dependencyobjectcollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<DependencyObject>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](XREF:TODO:M:System.Collections.Generic.IEnumerable`1.GetEnumerator), cast to [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) with a [DependencyObject](dependencyobject.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[DependencyObject](dependencyobject.md), [IObservableVector(DependencyObject)](../windows.foundation.collections/iobservablevector_1.md), [IVector(DependencyObject)](../windows.foundation.collections/ivector_1.md), [IIterable(DependencyObject)](../windows.foundation.collections/iiterable_1.md), [IList&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IList`1)