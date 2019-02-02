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
When applied to properties that represent UI information, the width and height values of a [Rect](rect.md) value represent device-independent pixels. The *x* and *y* values have an indeterminate frame of reference (it depends on how this value is applied) but they often represent a point in the coordinate space of the main app window.

> **JavaScript**
> In JavaScript, a [Rect](rect.md) is an object with four data members: **x**, **y**, **width**, **height**. Other than the data members (fields), the API listed in the [Rect](rect.md) members lists don't apply to JavaScript programming.

### Notes on XAML syntax

Object attribute usage is technically permitted by the Windows Runtime XAML parsing rules. However, that usage isn't shown because it's not commonly used.

You can use a space rather than a comma as the delimiter between values. Mixed delimiter usages are also permitted.

You must specify all four values. "0,0" is not an implicit default for "x,y", and no other conventions exist that can parse less than 4 components in the string.

A [Rect](rect.md) element cannot be declared as a resource in a XAML [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md) because [Rect](rect.md) is not a shareable type (for more info see [ResourceDictionary and XAML resource references](https://msdn.microsoft.com/library/e3cbfa3d-6af5-44e1-b9f9-c3d3ea8a25ce)).

### Language projection and members of **Rect**

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic) or Visual C++ component extensions (C++/CX), then [Rect](rect.md) has non-data members available, and its data members are exposed as read-write properties, not fields. Microsoft .NET supports this functionality through the System.Runtime.WindowsRuntime.dll interop assembly that's shipped as part of .NET for Windows Runtime app. Visual C++ component extensions (C++/CX) supports it through the language-specific platform.winmd metadata and the runtime behavior it represents.

If you are programming with C++ using the Windows Template Runtime Library (WRL), then only the data member fields exist as members of [Rect](rect.md), and you cannot use the utility methods or properties listed in the members table. WRL code can access similar utility methods that are available from the [RectHelper](../windows.ui.xaml/recthelper.md) static class. For more info on WRL, see [WRL Integration](https://msdn.microsoft.com/library/3ad43894-c574-477c-ad3e-240301f381d4).

### Rect values and how they are interpreted by properties

[Size](size.md) is a similar structure that uses the same metaphor of height and width. However, a [Rect](rect.md) specifies an origin point, whereas a [Size](size.md) does not. Typically [Rect](rect.md) is used for graphics library API, and [Size](size.md) is used for presentation and layout in app UI, particularly for adaptive layout (where the positioning is often automatic).

The typical behavior of a [Rect](rect.md) value when applied to properties follows these principles:
+ **Width** and **Height** cannot be negative.
+ **X** and **Y** can be negative, with the result that the [Rect](rect.md) definition is outside the coordinate frame of reference unless there is additional translation.
+ **X** and **Y** can be 0. A value of 0 is also valid for **Width** or **Height**. (However, if a [Rect](rect.md) with a value of 0 for either **Width** or **Height** is applied to a [RectangleGeometry](../windows.ui.xaml.media/rectanglegeometry.md), the resulting [RectangleGeometry](../windows.ui.xaml.media/rectanglegeometry.md) does not render.)
+ **X**, **Y**, **Width** and **Height** can be non-integer values in terms of permitted values. However, you typically use integer values. XAML UI behaves best when the point locations and unit measures don't use sub-pixel values.


## -examples

## -see-also
[Size](size.md), [RectHelper](../windows.ui.xaml/recthelper.md)
