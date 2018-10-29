---
-api-id: T:Windows.Foundation.Point
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Point 
-->

# Point

## -description
Represents x- and y-coordinate values that define a point in a two-dimensional plane.
## -xaml-syntax
```xaml
<object property="X,Y"/>
-or
<object property="X Y"/>
```


## -xaml-values
<dl><dt>X</dt><dd>XThe x-coordinate component of the Point value.</dd>
<dt>Y</dt><dd>YThe y-coordinate component of the Point value.</dd>
</dl>

## -struct-fields

### -field X
The horizontal position of the point.
    

### -field Y
The vertical position of the point.
    

## -remarks
A [Point](point.md) value sometimes represents a coordinate space in the plane of the main window of an app, but there are other possible interpretations of [Point](point.md) values that can vary, depending on the property that uses the [Point](point.md) value.

> **JavaScript**
> In JavaScript, a [Point](point.md) is an object with two data properties: **x** and **y**. Other than **x** and **y**, the remaining API listed here in the [Point](point.md) members lists (or shown in the table of contents) don't apply to JavaScript programming.

### Notes on XAML syntax

[Point](point.md) values are used extensively for graphics properties and similar UI-related properties throughout the XAML vocabulary for Windows Runtime app.

Either a space or a comma can be used as the delimiter between *X* and *Y* values. The common convention for coordinate points is to use a comma delimiter.

[Point](point.md) structures cannot be declared as resources in a [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md). A potential workaround is to use an [x:String](http://msdn.microsoft.com/library/e3cbfa3d-6af5-44e1-b9f9-c3d3ea8a25ce) resource and then inject it into a string that's parsed with [XamlReader.Load](../windows.ui.xaml.markup/xamlreader_load_1077941801.md).

Some XAML usages use the [Point](point.md) type to represent a *logical point*. See "Logical Points" in Remarks.

### Projection and members of **Point**

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or Visual C++ component extensions (C++/CX), then [Point](point.md) has non-data members available, and its data members are exposed as read-write properties, not fields. Microsoft .NET supports this functionality through the System.Runtime.WindowsRuntime.dll interop assembly that's shipped as part of .NET for Windows Runtime app. Visual C++ component extensions (C++/CX) supports it through the language-specific platform.winmd metadata and the runtime behavior it represents.

If you are programming with C++ using the Windows Template Runtime Library (WRL), then only the data member fields exist as members of [Point](point.md), and you cannot use the utility methods or properties listed in the members table. WRL code can access similar utility methods that are available from the [PointHelper](../windows.ui.xaml/pointhelper.md) static class. For more info on WRL, see [Windows Runtime C++ Template Library (WRL)](https://msdn.microsoft.com/library/hh438466.aspx).

### **Point** values and how they are interpreted by properties

Some (but not all) usages of the [Point](point.md) type specify location in a coordinate space. Depending on the context, the location might be in a content area's frame of reference, or might be within the frame of reference for a specific layout element.

**X** and **Y** for a [Point](point.md) can be non-integer values. However, this can introduce the possibility of sub-pixel rendering, which can change colors and anti-alias any straight line along the sub-pixel edge. That's how the XAML rendering engine treats sub-pixel boundaries. So for best results, use integer values when declaring coordinates and shapes that are used for UI positioning and rendering.

**X** and **Y** for a [Point](point.md) can be negative in some cases. Typically, this results in a [Point](point.md) that specifies a coordinate that is deliberately outside the frame of reference, unless there is additional translation. However, some XAML properties reject a [Point](point.md) with negative **X** or **Y** as an invalid value. Value constraints are typically noted in the reference pages for properties.

### Logical points

Some usages of the [Point](point.md) type in Windows Runtime app do not relate to coordinate frames of reference directly. Instead, these are logical points, where the value of **X** and **Y** are each expected to be between 0 and 1 inclusive. This is one reason why the **X** and **Y** values support floating-point values rather than being constrained to integer values. Logical point values are interpreted by a context: the ultimate presentation or behavior might be specified or modified by a different property or setting. Sometimes the points express information that doesn't relate to coordinate space at all. Examples of the logical point concept in application are the values of [Animation.KeySpline](../windows.ui.xaml.media.animation/keyspline.md) (paces an animation), the [RenderTransformOrigin](../windows.ui.xaml/uielement_rendertransformorigin.md) of a [UIElement](../windows.ui.xaml/uielement.md), and the [GradientStop.Offset](../windows.ui.xaml.media/gradientstop_offset.md) values for a [LinearGradientBrush](../windows.ui.xaml.media/lineargradientbrush.md).

A [Point](point.md)-value property that is a logical point usage may invalidate values less than 0, or greater than 1, but the specifics vary by property. Value constraints are typically noted in the reference pages for individual properties, rather than here in the [Point](point.md) reference.

### **Point** values and XAML graphics API

The graphics elements used for defining a XAML UI often use [Point](point.md)-value properties to declare their characteristics. For example, an [EllipseGeometry](../windows.ui.xaml.media/ellipsegeometry.md) uses a [Point](point.md) value to set its [Center](../windows.ui.xaml.media/ellipsegeometry_center.md) property.

The graphics elements use one of two models. Some of the graphics elements are derived from [FrameworkElement](../windows.ui.xaml/frameworkelement.md). These elements have a defined rendering behavior when placed in a UI and when element properties are assigned. Examples of this type of element are [Rectangle](../windows.ui.xaml.shapes/rectangle.md) and all the other types in the [Windows.UI.Xaml.Shapes](../windows.ui.xaml.shapes/windows_ui_xaml_shapes.md) namespace. Other graphics elements don't derive from [FrameworkElement](../windows.ui.xaml/frameworkelement.md), and don't have a rendering behavior of their own. Instead, these elements are composed to provide the value of a property on some other element that does have a rendering behavior. In other words they're data for a more comprehensive graphics model. For example, the graphics elements you use to compose [Path.Data](../windows.ui.xaml.shapes/path_data.md), such as [LineSegment](../windows.ui.xaml.media/linesegment.md), often have a [Point](point.md)-value property.

Some graphics elements use multiple [Point](point.md) values represented in a single property. These properties use the [PointCollection](../windows.ui.xaml.media/pointcollection.md) type. Any Windows Runtime property that takes a [PointCollection](../windows.ui.xaml.media/pointcollection.md) supports a XAML syntax that parses the attribute string to get [X](point_x.md) and [Y](point_y.md) values for multiple points. An example of a graphics property that uses [PointCollection](../windows.ui.xaml.media/pointcollection.md) is [Polygon.Points](../windows.ui.xaml.shapes/polygon.md).

### **Point** values from XAML input events, and hit testing

A [Point](point.md) value is returned by the event data for certain input events. For example, [GetCurrentPoint](../windows.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_1761708789.md) provides a coordinate value of where a [Pointer](../windows.ui.xaml.input/pointer.md) event occurred in app UI. Generally speaking, these [Point](point.md) values refer to a certain frame of coordinate reference and it is important to know what that frame of reference represents. For input events, the frame of reference by default is the main app window, not the overall screen/display. This enables a consistent frame of reference in case the window is moved or resized. Some API such as [GetCurrentPoint](../windows.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_1761708789.md) and [GetPosition](../windows.ui.xaml.input/tappedroutedeventargs_getposition_1813281865.md) also provide a way to translate to an element-specific frame of reference, which is useful when working with input events that are handled by an individual control. For more info, see [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82).

XAML UI development also has a concept known as *hit testing*, where you can use utility methods to test how input events would report info if the user were to perform a pointer action in a particular coordinate location of the UI. To support the hit testing concept, 2 signatures of [FindElementsInHostCoordinates](../windows.ui.xaml.media/visualtreehelper_findelementsinhostcoordinates_1478853318.md) use a [Point](point.md) input parameter, as does [FindSubElementsForTouchTargeting](../windows.ui.xaml/uielement_findsubelementsfortouchtargeting_2073429826.md). For more info, see [Mouse interactions](http://msdn.microsoft.com/library/c8a158ef-70a9-4ba2-a270-7d08125700ac).

### Animating **Point** values

The Windows Runtime provides a means to animate the values of any property that uses a [Point](point.md) as a value, so long as that property is implemented as a dependency property. [Point](point.md) has its own animation support type because it's not possible to individually animate the *x* and *y* values of a [Point](point.md). Structures can't support dependency properties. Use the [PointAnimation](../windows.ui.xaml.media.animation/pointanimation.md) type for **from-to** animations, or use [PointAnimationUsingKeyFrames](../windows.ui.xaml.media.animation/pointanimationusingkeyframes.md) derived types for key-frame animation behavior. For more info on how to animate a [Point](point.md) value and how animations work in XAML UI, see [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).

## -examples

## -see-also
[PointAnimation](../windows.ui.xaml.media.animation/pointanimation.md), [PointCollection](../windows.ui.xaml.media/pointcollection.md), [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82), [Draw shapes](http://msdn.microsoft.com/library/54cc0bd4-1961-44d7-ab40-6e8b58e42d65)