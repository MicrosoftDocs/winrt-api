---
-api-id: T:Windows.UI.Xaml.Media.Animation.TimelineCollection
-api-type: winrt class
---

<!-- Class syntax.
public class TimelineCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.Animation.Timeline>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.Animation.Timeline>
-->

# Windows.UI.Xaml.Media.Animation.TimelineCollection

## -description
Represents a collection of [Timeline](timeline.md) objects (specific type animations). A TimelineCollection is the value of the [Storyboard.Children](storyboard_children.md) property.



## -xaml-syntax
```xaml
<Storyboard ...>
  oneOrMoreChildTimelines
</Storyboard>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A TimelineCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<Timeline>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [Timeline](timeline.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true), [Storyboard](storyboard.md), [Storyboard.Children](storyboard_children.md), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations)
