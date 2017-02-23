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
When applied to properties that represent UI information, the width and height values of a [Size](size.md) value represent device-independent pixels.

> **JavaScript**
> In JavaScript, a [Size](size.md) is an object with 2 data properties: **width** and **height**. The API listed in the [Size](size.md) member lists don't apply to JavaScript programming.

### Notes on XAML syntax

The only Windows Runtime property that uses a [Size](size.md) as a value for XAML is [ArcSegment.Size](../windows.ui.xaml.media/arcsegment_size.md). [Rect](rect.md) is more common.

Object attribute usage is technically permitted by the Windows Runtime XAML parsing rules. However, that usage isn't shown in syntax because it's not common. A [Size](size.md) can't be used as a XAML resource (for more info see [ResourceDictionary and XAML resource references](http://msdn.microsoft.com/library/e3cbfa3d-6af5-44e1-b9f9-c3d3ea8a25ce)).

You can use a space rather than a comma as the delimiter between values.

### Projection and members of **Size**

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or Visual C++ component extensions (C++/CX), then [Size](size.md) has non-data members available, and its data members are exposed as read-write properties, not fields. Microsoft .NET supports this functionality through the System.Runtime.WindowsRuntime.dll interop assembly that's shipped as part of .NET for Windows Runtime app. Visual C++ component extensions (C++/CX) supports it through the language-specific platform.winmd metadata and the runtime behavior it represents.

If you are programming with C++ using the Windows Runtime Template Library (WRL), then only the data member fields exist as members of [Size](size.md), and you cannot use the utility methods or properties listed in the members table. WRL code can access similar utility methods that are available from the [SizeHelper](../windows.ui.xaml/sizehelper.md) static class. For more info on WRL, see [WRL Integration](http://msdn.microsoft.com/library/3ad43894-c574-477c-ad3e-240301f381d4).

## -examples

## -see-also
[Rect](rect.md), [SizeHelper](../windows.ui.xaml/sizehelper.md)
