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
The purpose of the DependencyObjectCollection class is mainly to support the tooling and portability of behaviors. Behaviors are a technique for defining certain basic interactions of a UI element entirely in XAML, without requiring an event handler and code-behind.

If you're interested in implementing a business object class that supports collection-changed notifications you should use **ObservableCollection** or one of the interface patterns that supports changed events. For more info see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A DependencyObjectCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<DependencyObject>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [DependencyObject](dependencyobject.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[DependencyObject](dependencyobject.md), [IObservableVector(DependencyObject)](../windows.foundation.collections/iobservablevector_1.md), [IVector(DependencyObject)](../windows.foundation.collections/ivector_1.md), [IIterable(DependencyObject)](../windows.foundation.collections/iiterable_1.md), [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)
