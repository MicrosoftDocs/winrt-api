---
-api-id: T:Windows.UI.Xaml.Media.PathSegmentCollection
-api-type: winrt class
---

<!-- Class syntax.
public class PathSegmentCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.PathSegment>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.PathSegment>
-->

# Windows.UI.Xaml.Media.PathSegmentCollection

## -description
Represents a collection of [PathSegment](pathsegment.md) objects that can be individually accessed by index.



## -xaml-syntax
```xaml
<object>
  <object.property>
    oneOrMorePathSegments
  </object.property>
</object>
```


## -remarks
This class is relevant for setting the vector data for either a [Path](../windows.ui.xaml.shapes/path.md) or a [PathIcon](../windows.ui.xaml.controls/pathicon.md).

Rather than creating an instance or an object element, you can also define different types of segments as part of a vector within the string for a [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax).


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A PathSegmentCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<PathSegment>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [PathSegment](pathsegment.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax)
