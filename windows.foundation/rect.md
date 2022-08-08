---
-api-id: T:Windows.Foundation.Rect
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Rect
-->

# Rect

## -description

Contains number values that represent the location and size of a rectangle.

## -xaml-syntax

```xaml
<object property="x,y,width,height"/>
-or-
<object property="x y width height"/>

```

## -xaml-values

<dl><dt>x</dt><dd>xThe x-coordinate location of the left side of the rectangle.</dd>
<dt>y</dt><dd>yThe y-coordinate location of the top side of the rectangle.</dd>
<dt>width</dt><dd>widthA value that represents the Width of the rectangle.</dd>
<dt>height</dt><dd>heightA value that represents the Height of the rectangle.</dd>
</dl>

## -struct-fields

### -field X

The x-coordinate of the upper-left corner of the rectangle.

### -field Y

The y-coordinate of the upper-left corner of the rectangle.

### -field Width

The width of the rectangle, in pixels.

### -field Height

The height of the rectangle, in pixels.

## -remarks

When applied to properties that represent UI information, the width and height values of a Rect value represent device-independent pixels. The *x* and *y* values have an indeterminate frame of reference (it depends on how this value is applied) but they often represent a point in the coordinate space of the main app window.

> **JavaScript:**
> In JavaScript, a Rect is an object with four data members: **x**, **y**, **width**, **height**. Other than the data members (fields), the API listed in the Rect members lists don't apply to JavaScript programming.

### Notes on XAML syntax

Object attribute usage is technically permitted by the Windows Runtime XAML parsing rules. However, that usage isn't shown because it's not commonly used.

You can use a space rather than a comma as the delimiter between values. Mixed delimiter usages are also permitted.

You must specify all four values. "0,0" is not an implicit default for "x,y", and no other conventions exist that can parse less than 4 components in the string.

A Rect element cannot be declared as a resource in a XAML [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md) because Rect is not a shareable type (for more info see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)).

### Rect values and how they are interpreted by properties

[Size](size.md) is a similar structure that uses the same metaphor of height and width. However, a Rect specifies an origin point, whereas a [Size](size.md) does not. Typically Rect is used for graphics library API, and [Size](size.md) is used for presentation and layout in app UI, particularly for adaptive layout (where the positioning is often automatic).

The typical behavior of a Rect value when applied to properties follows these principles:

+ **Width** and **Height** cannot be negative.
+ **X** and **Y** can be negative, with the result that the Rect definition is outside the coordinate frame of reference unless there is additional translation.
+ **X** and **Y** can be 0. A value of 0 is also valid for **Width** or **Height**. (However, if a Rect with a value of 0 for either **Width** or **Height** is applied to a [RectangleGeometry](../windows.ui.xaml.media/rectanglegeometry.md), the resulting [RectangleGeometry](../windows.ui.xaml.media/rectanglegeometry.md) does not render.)
+ **X**, **Y**, **Width** and **Height** can be non-integer values in terms of permitted values. However, you typically use integer values. XAML UI behaves best when the point locations and unit measures don't use sub-pixel values.

### Language projection and members of Rect

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic) or Visual C++ component extensions (C++/CX), then Rect has non-data members available, and its data members are exposed as read-write properties, not fields. See [Rect](/dotnet/api/windows.foundation.rect?view=dotnet-uwp-10.0&preserve-view=true) in the .NET API Browser.

If you are programming with [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) or the [Windows Runtime C++ Template Library (WRL)](/cpp/windows/windows-runtime-cpp-template-library-wrl), then only the data member fields exist as members of Rect, and you cannot use the utility methods or properties of the .NET projection. C++ code can access similar utility methods that are available from the [RectHelper](../windows.ui.xaml/recthelper.md) static class.

This table shows the equivalent methods available in .NET and C++.

| .NET ([Rect](/dotnet/api/windows.foundation.rect?view=dotnet-uwp-10.0&preserve-view=true)) | C++ ([RectHelper](../windows.ui.xaml/recthelper.md)) |
| ---- | --- |
| [Rect(Point, Point)](/dotnet/api/windows.foundation.rect.-ctor?view=dotnet-uwp-10.0&preserve-view=true#Windows_Foundation_Rect__ctor_Windows_Foundation_Point_Windows_Foundation_Point_) | [FromPoints(Point, Point)](/uwp/api/windows.ui.xaml.recthelper.frompoints) |
| [Rect(Point, Size)](/dotnet/api/windows.foundation.rect.-ctor?view=dotnet-uwp-10.0&preserve-view=true#Windows_Foundation_Rect__ctor_Windows_Foundation_Point_Windows_Foundation_Size_) | [FromLocationAndSize(Point, Size)](../windows.ui.xaml/recthelper_fromlocationandsize_1049054702.md) |
| [Rect(Double, Double, Double, Double)](/dotnet/api/windows.foundation.rect.-ctor?view=dotnet-uwp-10.0&preserve-view=true#Windows_Foundation_Rect__ctor_System_Double_System_Double_System_Double_System_Double_) | [FromCoordinatesAndDimensions(Single, Single, Single, Single)](../windows.ui.xaml/recthelper_fromcoordinatesanddimensions_1633521356.md) |
| [Bottom](/dotnet/api/windows.foundation.rect.bottom?view=dotnet-uwp-10.0&preserve-view=true) | [GetBottom(Rect)](../windows.ui.xaml/recthelper_getbottom_1066401735.md) |
| [Empty](/dotnet/api/windows.foundation.rect.empty?view=dotnet-uwp-10.0&preserve-view=true) | [Empty](../windows.ui.xaml/recthelper_empty.md) |
| [IsEmpty](/dotnet/api/windows.foundation.rect.isempty?view=dotnet-uwp-10.0&preserve-view=true) | [GetIsEmpty(Rect)](../windows.ui.xaml/recthelper_getisempty_1110221055.md) |
| [Left](/dotnet/api/windows.foundation.rect.left?view=dotnet-uwp-10.0&preserve-view=true) | [GetLeft(Rect)](../windows.ui.xaml/recthelper_getleft_1023490401.md) |
| [Right](/dotnet/api/windows.foundation.rect.right?view=dotnet-uwp-10.0&preserve-view=true) | [GetRight(Rect)](../windows.ui.xaml/recthelper_getright_1384154527.md) |
| [Top](/dotnet/api/windows.foundation.rect.top?view=dotnet-uwp-10.0&preserve-view=true) | [GetTop(Rect)](../windows.ui.xaml/recthelper_gettop_1602274045.md) |
| [Contains(Point)](/dotnet/api/windows.foundation.rect.contains?view=dotnet-uwp-10.0&preserve-view=true) | [Contains(Rect, Point)](../windows.ui.xaml/recthelper_contains_1524279399.md) |
| [Equals](/dotnet/api/windows.foundation.rect.equals?view=dotnet-uwp-10.0&preserve-view=true) | [Equals(Rect, Rect)](../windows.ui.xaml/recthelper_equals_522276799.md) |
| [Intersect(Rect)](/dotnet/api/windows.foundation.rect.intersect?view=dotnet-uwp-10.0&preserve-view=true) | [Intersect(Rect, Rect)](../windows.ui.xaml/recthelper_intersect_1833302820.md) |
| [Union(Point)](/dotnet/api/windows.foundation.rect.union?view=dotnet-uwp-10.0&preserve-view=true#Windows_Foundation_Rect_Union_Windows_Foundation_Point_) | [Union(Rect, Point)](../windows.ui.xaml/recthelper_union_305961467.md) |
| [Union(Rect)](/dotnet/api/windows.foundation.rect.union?view=dotnet-uwp-10.0&preserve-view=true#Windows_Foundation_Rect_Union_Windows_Foundation_Rect_) | [Union(Rect, Rect)](../windows.ui.xaml/recthelper_union_1095011459.md) |

## -examples

## -see-also

[Size](size.md), [RectHelper](../windows.ui.xaml/recthelper.md)
