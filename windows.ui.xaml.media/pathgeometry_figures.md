---
-api-id: P:Windows.UI.Xaml.Media.PathGeometry.Figures
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.PathFigureCollection Figures { get;  set; }
-->

# Windows.UI.Xaml.Media.PathGeometry.Figures

## -description
Gets or sets the collection of [PathFigure](pathfigure.md) objects that describe the contents of a path.



## -xaml-syntax
```xaml
<PathGeometry>
  <PathGeometry.Figures>
    oneOrMoreFigures
  </PathGeometry.Figures>
</PathGeometry>
```


## -xaml-values
<dl>
<dt>oneOrMoreFigures</dt><dd>oneOrMoreFiguresOne or more PathFigure object elements.</dd>
</dl>
## -property-value
A collection of [PathFigure](pathfigure.md) objects that describe the contents of a path. Each individual [PathFigure](pathfigure.md) describes a shape.

## -remarks
The main reason you'd want more than one [PathFigure](pathfigure.md) is if you want to consider the overall [PathGeometry](pathgeometry.md) as one vector drawing that can "restart" the line in a different place, and use [IsClosed](pathfigure_isclosed.md) to close up each figure.

## -examples

## -see-also
[PathFigure](pathfigure.md), [Path](../windows.ui.xaml.shapes/path.md), [IsClosed](pathfigure_isclosed.md)
