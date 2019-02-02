---
-api-id: T:Windows.UI.Xaml.Media.ArcSegment
-api-type: winrt class
---

<!-- Class syntax.
public class ArcSegment : Windows.UI.Xaml.Media.PathSegment, Windows.UI.Xaml.Media.IArcSegment
-->

# Windows.UI.Xaml.Media.ArcSegment

## -description
Represents an elliptical arc between two points.

## -xaml-syntax
```xaml
<ArcSegment .../>
```


## -remarks
At a minimum each [ArcSegment](arcsegment.md) should have its [RotationAngle](arcsegment_rotationangle.md) and [Size](arcsegment_size.md) properties set, because these don't have useful defaults.

This class is relevant for setting the vector data for either a [Path](../windows.ui.xaml.shapes/path.md) or a [PathIcon](../windows.ui.xaml.controls/pathicon.md).

Rather than creating an instance or an object element, you can also define an [ArcSegment](arcsegment.md) as part of a vector within the string for a [Move and draw commands syntax](https://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9).

## -examples

## -see-also
[PathSegment](pathsegment.md), [Path](../windows.ui.xaml.shapes/path.md), [PathGeometry](pathgeometry.md), [XAML vector-based drawing sample](https://go.microsoft.com/fwlink/p/?linkid=226866), [Draw shapes](https://msdn.microsoft.com/library/54cc0bd4-1961-44d7-ab40-6e8b58e42d65), [Move and draw commands syntax](https://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9)
