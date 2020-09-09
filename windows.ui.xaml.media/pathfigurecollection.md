---
-api-id: T:Windows.UI.Xaml.Media.PathFigureCollection
-api-type: winrt class
---

<!-- Class syntax.
public class PathFigureCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.PathFigure>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.PathFigure>
-->

# Windows.UI.Xaml.Media.PathFigureCollection

## -description
Represents a collection of [PathFigure](pathfigure.md) objects that collectively make up the geometry of a [PathGeometry](pathgeometry.md).

## -xaml-syntax
```xaml
<object>
  <object.property>
    oneOrMorePathFigures
  </object.property>
</object>
- or -
<object property="drawingCommands" ...>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A PathFigureCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<PathFigure>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1) with a [PathFigure](pathfigure.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList<T>](/dotnet/api/system.collections.generic.ilist-1)
