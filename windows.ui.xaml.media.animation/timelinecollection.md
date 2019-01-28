---
-api-id: T:Windows.UI.Xaml.Media.Animation.TimelineCollection
-api-type: winrt class
---

<!-- Class syntax.
public class TimelineCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.Animation.Timeline>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.Animation.Timeline>
-->

# Windows.UI.Xaml.Media.Animation.TimelineCollection

## -description
Represents a collection of [Timeline](timeline.md) objects (specific type animations). A [TimelineCollection](timelinecollection.md) is the value of the [Storyboard.Children](storyboard_children.md) property.

## -xaml-syntax
```xaml
<Storyboard ...>
  oneOrMoreChildTimelines
</Storyboard>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A [TimelineCollection](timelinecollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<Timeline>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) with a [Timeline](timeline.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1), [Storyboard](storyboard.md), [Storyboard.Children](storyboard_children.md), [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a)