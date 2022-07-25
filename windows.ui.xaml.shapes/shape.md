---
-api-id: T:Windows.UI.Xaml.Shapes.Shape
-api-type: winrt class
---

<!-- Class syntax.
public class Shape : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Shapes.IShape, Windows.UI.Xaml.Shapes.IShape2
-->

# Windows.UI.Xaml.Shapes.Shape

## -description
Provides a base class for shape elements, such as [Ellipse](ellipse.md), [Polygon](polygon.md), and [Rectangle](rectangle.md).



## -remarks
Shape defines several properties that are shared by all the Shape derived classes. The most commonly used properties are [Fill](shape_fill.md), [Stroke](shape_stroke.md), and [StrokeThickness](shape_strokethickness.md). [Stroke](shape_stroke.md) uses a [Brush](../windows.ui.xaml.media/brush.md) to draw the outline of the shape, and [Fill](shape_fill.md) uses a [Brush](../windows.ui.xaml.media/brush.md) to draw the interior. For more info on how to use the Shape derived classes in XAML UI, see [Draw shapes](/windows/uwp/graphics/drawing-shapes).

Shape also derives from [FrameworkElement](../windows.ui.xaml/frameworkelement.md) and inherits various properties from that class. Those properties include [Height](../windows.ui.xaml/frameworkelement_height.md) and [Width](../windows.ui.xaml/frameworkelement_width.md). For most other [FrameworkElement](../windows.ui.xaml/frameworkelement.md) derived types, setting [Height](../windows.ui.xaml/frameworkelement_height.md) and [Width](../windows.ui.xaml/frameworkelement_width.md) is the primary way to specify that element's dimensions in UI (although you often would leave them as "Auto" to take advantage of adaptive layout). But not all of the Shape classes use [Height](../windows.ui.xaml/frameworkelement_height.md) or [Width](../windows.ui.xaml/frameworkelement_width.md) to specify their dimensions, and instead use specific properties that might define a set of points. In this case a [Height](../windows.ui.xaml/frameworkelement_height.md) or [Width](../windows.ui.xaml/frameworkelement_width.md) is calculated for layout, but you shouldn't attempt to set the [Height](../windows.ui.xaml/frameworkelement_height.md) or [Width](../windows.ui.xaml/frameworkelement_width.md). See the remarks or descriptions in specific Shape derived classes for more info.

Because the Shape derived classes are UI elements they can be used as content for containers such as controls and panels. They have practical presence in the UI; for example they are hit-testable with input events, they report desired size for layout, and so on. There are other graphics definition classes for XAML that aren't UI elements. These mostly exist in the [Windows.UI.Xaml.Media](../windows.ui.xaml.media/windows_ui_xaml_media.md) namespace. Examples of such graphics classes are the [Geometry](../windows.ui.xaml.media/geometry.md) types, [PathFigure](../windows.ui.xaml.media/pathfigure.md) types and [PathSegment](../windows.ui.xaml.media/pathsegment.md) types.

### **Shape** derived classes

Shape is the parent class for several immediately derived classes that define primitive shapes for use as UI elements:

+ [Ellipse](ellipse.md)
+ [Line](line.md)
+ [Path](path.md)
+ [Polygon](polygon.md)
+ [Polyline](polyline.md)
+ [Rectangle](rectangle.md)
Of these, [Rectangle](rectangle.md), [Path](path.md) and [Ellipse](ellipse.md) are probably the most commonly used. [Rectangle](rectangle.md) is often used as part of control composition for drawing a focus rectangle. [Path](path.md) is used for control glyphs, and also for [PathIcon](../windows.ui.xaml.controls/pathicon.md) content. [Ellipse](ellipse.md) is used for control compositions that include a circle, particularly in progress controls.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetAlphaMask |

## -examples
For example code of how to use Shape derived classes such as [Rectangle](rectangle.md) and [Path](path.md), see [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample).

## -see-also
[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
