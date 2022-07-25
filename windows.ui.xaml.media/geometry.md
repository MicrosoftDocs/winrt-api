---
-api-id: T:Windows.UI.Xaml.Media.Geometry
-api-type: winrt class
---

<!-- Class syntax.
public class Geometry : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.IGeometry
-->

# Windows.UI.Xaml.Media.Geometry

## -description
Provides a base class for objects that define geometric shapes. Geometry objects can be used for clipping regions and as geometry definitions for rendering two-dimensional graphical data as a [Path](../windows.ui.xaml.shapes/path.md).



## -remarks
For properties that take a Geometry, you need to specify a nonabstract derived type of Geometry, as an object element for XAML, or as a defined instance for code. For details, see reference pages for [EllipseGeometry](ellipsegeometry.md), [GeometryGroup](geometrygroup.md), [LineGeometry](linegeometry.md), [PathGeometry](pathgeometry.md), or [RectangleGeometry](rectanglegeometry.md).

Geometries can be conceptualized as being "simple" or "complex". [EllipseGeometry](ellipsegeometry.md), [LineGeometry](linegeometry.md), and [RectangleGeometry](rectanglegeometry.md) are the simple geometries, which specify the geometrical shape as one element with basic coordinate or dimension properties. [GeometryGroup](geometrygroup.md) and [PathGeometry](pathgeometry.md) are the complex geometries. [GeometryGroup](geometrygroup.md) combines other geometries that it holds as child objects. [PathGeometry](pathgeometry.md) uses either a set of nested figure/segment path definition elements, or a compact string syntax that's usually output by designers, to describe a complex path for the geometry.


<!--Port the Path Syntax-->
A Geometry does not entirely define its own rendering, in that it's not a [UIElement](../windows.ui.xaml/uielement.md) itself and needs to be provided as some property value for a [UIElement](../windows.ui.xaml/uielement.md) in order to cause a rendering effect. Typically, a Geometry is provided as data for a [Path](../windows.ui.xaml.shapes/path.md) (which is a kind of [Shape](../windows.ui.xaml.shapes/shape.md)).

The [PathIcon.Data](../windows.ui.xaml.controls/pathicon_data.md) property takes a Geometry. In practice, you'd typically specify a [PathGeometry](pathgeometry.md) for this, with its [Figures](pathgeometry_figures.md) property value expressed in the compact string syntax for a path.

[GeometryCollection](geometrycollection.md) is a strongly typed collection for Geometry items. The [GeometryGroup.Children](geometrygroup_children.md) property uses a [GeometryCollection](geometrycollection.md).

### **Geometry** versus **Shape**

The [Shape](../windows.ui.xaml.shapes/shape.md) class has a [Fill](../windows.ui.xaml.shapes/shape_fill.md), [Stroke](../windows.ui.xaml.shapes/shape_stroke.md), and other rendering properties that Geometry and its derived classes lack. The [Shape](../windows.ui.xaml.shapes/shape.md) class is a [FrameworkElement](../windows.ui.xaml/frameworkelement.md) and therefore participates in the layout system; its derived classes can be used as the content of any element that supports [UIElement](../windows.ui.xaml/uielement.md) children. The Geometry class, on the other hand, simply defines the geometry as a graphics primitive, and cannot render itself. You could conceivably use Geometry as a property type for custom UI element properties where the basic graphics primitive expressions enabled by Geometry are useful as a definition.

### Geometry for UIElement.Clip

To provide a value for the [UIElement.Clip](../windows.ui.xaml/uielement_clip.md) property in the Windows Runtime, you must specifically use a [RectangleGeometry](rectanglegeometry.md), not any Geometry derived type. If you're porting XAML or code from other XAML frameworks, see if you can change your [UIElement.Clip](../windows.ui.xaml/uielement_clip.md) to use [RectangleGeometry](rectanglegeometry.md). Otherwise, you might need to change the Z-order relationship and use techniques such as an overlay of an [ImageBrush](imagebrush.md) with a modified [RenderTargetBitmap](../windows.ui.xaml.media.imaging/rendertargetbitmap.md) source that has alpha transparency for the "clipping" parts.

### **Geometry** derived classes

Geometry is the parent class for several derived classes that define different categories of practical geometries:

+ [EllipseGeometry](ellipsegeometry.md)
+ [GeometryGroup](geometrygroup.md) - can be used to specify multiple geometries as [Children](geometrygroup_children.md)
+ [LineGeometry](linegeometry.md)
+ [PathGeometry](pathgeometry.md) - use this type for any geometry that can't be expressed by the other "simple" geometry types
+ [RectangleGeometry](rectanglegeometry.md)


## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [EllipseGeometry](ellipsegeometry.md), [GeometryGroup](geometrygroup.md), [LineGeometry](linegeometry.md), [PathGeometry](pathgeometry.md), [RectangleGeometry](rectanglegeometry.md), [GeometryCollection](geometrycollection.md), [PathIcon.Data](../windows.ui.xaml.controls/pathicon_data.md), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
