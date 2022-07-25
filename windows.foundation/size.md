---
-api-id: T:Windows.Foundation.Size
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Size
-->

# Size

## -description
Represents number values that specify a height and width.
## -xaml-syntax
```xaml
<object property="width,height"/>
-or-
<object property="width height"/>
```


## -xaml-values
<dl><dt>width</dt><dd>widthA numeric value greater than or equal to 0 that specifies the Width component of the Size structure.</dd>
<dt>height</dt><dd>heightA numeric value greater than or equal to 0 that specifies the Height of the Size structure.</dd>
</dl>

## -struct-fields

### -field Width
The width.


### -field Height
The height.


## -remarks
When applied to properties that represent UI information, the width and height values of a Size value represent device-independent pixels.

> **JavaScript**
> In JavaScript, a Size is an object with 2 data properties: **width** and **height**. The API listed in the Size member lists don't apply to JavaScript programming.

### Notes on XAML syntax

The only Windows Runtime property that uses a Size as a value for XAML is [ArcSegment.Size](../windows.ui.xaml.media/arcsegment_size.md). [Rect](rect.md) is more common.

Object attribute usage is technically permitted by the Windows Runtime XAML parsing rules. However, that usage isn't shown in syntax because it's not common. A Size can't be used as a XAML resource (for more info see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)).

You can use a space rather than a comma as the delimiter between values.

### Projection and members of **Size**

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or Visual C++ component extensions (C++/CX), then Size has non-data members available, and its data members are exposed as read-write properties, not fields. See [Size](/dotnet/api/windows.foundation.size?view=dotnet-uwp-10.0&preserve-view=true) in the .NET API Browser.

If you are programming with [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) or the [Windows Runtime C++ Template Library (WRL)](/cpp/windows/windows-runtime-cpp-template-library-wrl), then only the data member fields exist as members of Size, and you cannot use the utility methods or properties of the .NET projection. C++ code can access similar utility methods that are available from the [SizeHelper](../windows.ui.xaml/sizehelper.md) static class.

This table shows the equivalent methods available in .NET and C++.

| .NET ([Size](/dotnet/api/windows.foundation.size?view=dotnet-uwp-10.0&preserve-view=true)) | C++ ([SizeHelper](../windows.ui.xaml/sizehelper.md)) |
| ---- | --- |
| [Size(Double, Double)](/dotnet/api/windows.foundation.size.-ctor?view=dotnet-uwp-10.0&preserve-view=true) | [FromDimensions(Single, Single)](../windows.ui.xaml/sizehelper_fromdimensions_84932572.md) |
| [Empty](/dotnet/api/windows.foundation.size.empty?view=dotnet-uwp-10.0&preserve-view=true) | [Empty](../windows.ui.xaml/sizehelper_equals_1638522698.md) |
| [IsEmpty](/dotnet/api/windows.foundation.size.isempty?view=dotnet-uwp-10.0&preserve-view=true) | [GetIsEmpty(Size)](../windows.ui.xaml/sizehelper_getisempty_1023510010.md) |
| [Equals](/dotnet/api/windows.foundation.size.equals?view=dotnet-uwp-10.0&preserve-view=true) | [Equals(Size, Size)](../windows.ui.xaml/sizehelper_equals_1638522698.md) |

## -examples

## -see-also
[Rect](rect.md), [SizeHelper](../windows.ui.xaml/sizehelper.md)
