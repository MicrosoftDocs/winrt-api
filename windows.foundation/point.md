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

A Point value sometimes represents a coordinate space in the plane of the main window of an app, but there are other possible interpretations of Point values that can vary, depending on the property that uses the Point value.

> **JavaScript:**
> In JavaScript, a Point is an object with two data properties: **x** and **y**. Other than **x** and **y**, the remaining API listed here in the Point members lists (or shown in the table of contents) don't apply to JavaScript programming.

### Notes on XAML syntax

Point values are used extensively for graphics properties and similar UI-related properties throughout the XAML vocabulary for Windows Runtime apps.

Either a space or a comma can be used as the delimiter between *X* and *Y* values. The common convention for coordinate points is to use a comma delimiter.

Point structures cannot be declared as resources in a [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md). A potential workaround is to [use an x:String resource](/windows/apps/design/style/xaml-resource-dictionary) and then inject it into a string that's parsed with [XamlReader.Load](../windows.ui.xaml.markup/xamlreader_load_1077941801.md).

Some XAML usages use the Point type to represent a *logical point*. See "Logical Points" in Remarks.

### Point values and how they are interpreted by properties

Some (but not all) usages of the Point type specify location in a coordinate space. Depending on the context, the location might be in a content area's frame of reference, or might be within the frame of reference for a specific layout element.

**X** and **Y** for a Point can be non-integer values. However, this can introduce the possibility of sub-pixel rendering, which can change colors and anti-alias any straight line along the sub-pixel edge. That's how the XAML rendering engine treats sub-pixel boundaries. So for best results, use integer values when declaring coordinates and shapes that are used for UI positioning and rendering.

**X** and **Y** for a Point can be negative in some cases. Typically, this results in a Point that specifies a coordinate that is deliberately outside the frame of reference, unless there is additional translation. However, some XAML properties reject a Point with negative **X** or **Y** as an invalid value. Value constraints are typically noted in the reference pages for properties.

### Logical points

Some usages of the Point type in Windows Runtime apps do not relate to coordinate frames of reference directly. Instead, these are logical points, where the value of **X** and **Y** are each expected to be between 0 and 1 inclusive. This is one reason why the **X** and **Y** values support floating-point values rather than being constrained to integer values. Logical point values are interpreted by a context: the ultimate presentation or behavior might be specified or modified by a different property or setting. Sometimes the points express information that doesn't relate to coordinate space at all. Examples of the logical point concept in application are the values of [Animation.KeySpline](../windows.ui.xaml.media.animation/keyspline.md) (paces an animation), the [RenderTransformOrigin](../windows.ui.xaml/uielement_rendertransformorigin.md) of a [UIElement](../windows.ui.xaml/uielement.md), and the [GradientStop.Offset](../windows.ui.xaml.media/gradientstop_offset.md) values for a [LinearGradientBrush](../windows.ui.xaml.media/lineargradientbrush.md).

A Point-value property that is a logical point usage may invalidate values less than 0, or greater than 1, but the specifics vary by property. Value constraints are typically noted in the reference pages for individual properties, rather than here in the Point reference.

### Point values and XAML graphics API

The graphics elements used for defining a XAML UI often use Point-value properties to declare their characteristics. For example, an [EllipseGeometry](../windows.ui.xaml.media/ellipsegeometry.md) uses a Point value to set its [Center](../windows.ui.xaml.media/ellipsegeometry_center.md) property.

The graphics elements use one of two models. Some of the graphics elements are derived from [FrameworkElement](../windows.ui.xaml/frameworkelement.md). These elements have a defined rendering behavior when placed in a UI and when element properties are assigned. Examples of this type of element are [Rectangle](../windows.ui.xaml.shapes/rectangle.md) and all the other types in the [Windows.UI.Xaml.Shapes](../windows.ui.xaml.shapes/windows_ui_xaml_shapes.md) namespace. Other graphics elements don't derive from [FrameworkElement](../windows.ui.xaml/frameworkelement.md), and don't have a rendering behavior of their own. Instead, these elements are composed to provide the value of a property on some other element that does have a rendering behavior. In other words, they're data for a more comprehensive graphics model. For example, the graphics elements you use to compose [Path.Data](../windows.ui.xaml.shapes/path_data.md), such as [LineSegment](../windows.ui.xaml.media/linesegment.md), often have a Point-value property.

Some graphics elements use multiple Point values represented in a single property. These properties use the [PointCollection](../windows.ui.xaml.media/pointcollection.md) type. Any Windows Runtime property that takes a [PointCollection](../windows.ui.xaml.media/pointcollection.md) supports a XAML syntax that parses the attribute string to get [X](/uwp/api/windows.foundation.point.x) and [Y](/uwp/api/windows.foundation.point.y) values for multiple points. An example of a graphics property that uses [PointCollection](../windows.ui.xaml.media/pointcollection.md) is [Polygon.Points](../windows.ui.xaml.shapes/polygon.md).

### Point values from XAML input events, and hit testing

A Point value is returned by the event data for certain input events. For example, [GetCurrentPoint](../windows.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_1761708789.md) provides a coordinate value of where a [Pointer](../windows.ui.xaml.input/pointer.md) event occurred in app UI. Generally speaking, these Point values refer to a certain frame of coordinate reference and it is important to know what that frame of reference represents. For input events, the frame of reference by default is the main app window, not the overall screen/display. This enables a consistent frame of reference in case the window is moved or resized. Some API such as [GetCurrentPoint](../windows.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_1761708789.md) and [GetPosition](../windows.ui.xaml.input/tappedroutedeventargs_getposition_1813281865.md) also provide a way to translate to an element-specific frame of reference, which is useful when working with input events that are handled by an individual control. For more info, see [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input).

XAML UI development also has a concept known as *hit testing*, where you can use utility methods to test how input events would report info if the user were to perform a pointer action in a particular coordinate location of the UI. To support the hit testing concept, 2 signatures of [FindElementsInHostCoordinates](../windows.ui.xaml.media/visualtreehelper_findelementsinhostcoordinates_1478853318.md) use a Point input parameter, as does [FindSubElementsForTouchTargeting](../windows.ui.xaml/uielement_findsubelementsfortouchtargeting_2073429826.md). For more info, see [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions).

### Animating Point values

The Windows Runtime provides a means to animate the values of any property that uses a Point as a value, so long as that property is implemented as a dependency property. Point has its own animation support type because it's not possible to individually animate the *x* and *y* values of a Point. Structures can't support dependency properties. Use the [PointAnimation](../windows.ui.xaml.media.animation/pointanimation.md) type for **from-to** animations, or use [PointAnimationUsingKeyFrames](../windows.ui.xaml.media.animation/pointanimationusingkeyframes.md) derived types for key-frame animation behavior. For more info on how to animate a Point value and how animations work in XAML UI, see [Storyboarded animations](/windows/uwp/design/motion/storyboarded-animations).

### Projection and members of Point

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or Visual C++ component extensions (C++/CX), then Point has non-data members available, and its data members are exposed as read-write properties, not fields. See [Point](/dotnet/api/windows.foundation.point?view=dotnet-uwp-10.0&preserve-view=true) in the .NET API Browser.

If you are programming with [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) or the [Windows Runtime C++ Template Library (WRL)](/cpp/windows/windows-runtime-cpp-template-library-wrl), then only the data member fields exist as members of Point, and you cannot use the utility methods or properties of the .NET projection. C++ code can access similar utility methods that are available from the [PointHelper](../windows.ui.xaml/pointhelper.md) static class.

This table shows the equivalent methods available in .NET and C++.

| .NET ([Point](/dotnet/api/windows.foundation.point?view=dotnet-uwp-10.0&preserve-view=true)) | C++ ([PointHelper](../windows.ui.xaml/pointhelper.md)) |
| ---- | --- |
| [Point(Double, Double)](/dotnet/api/windows.foundation.point.-ctor?view=dotnet-uwp-10.0&preserve-view=true) | [FromCoordinates(Single, Single)](../windows.ui.xaml/pointhelper_fromcoordinates_673163148.md) |

## -examples

## -see-also

[PointAnimation](../windows.ui.xaml.media.animation/pointanimation.md), [PointCollection](../windows.ui.xaml.media/pointcollection.md), [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
