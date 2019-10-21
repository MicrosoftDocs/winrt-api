---
-api-id: T:Windows.UI.Xaml.TriggerCollection
-api-type: winrt class
---

<!-- Class syntax.
public class TriggerCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.TriggerBase>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.TriggerBase>
-->

# Windows.UI.Xaml.TriggerCollection

## -description
Represents a collection of [EventTrigger](eventtrigger.md) objects.

## -xaml-syntax
```xaml
<object>
  <object.Triggers>
    oneOrMoreEventTriggers
  </object.Triggers>
</object>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A TriggerCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<EventTrigger>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) with an [EventTrigger](eventtrigger.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1)
