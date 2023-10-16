---
-api-id: T:Windows.UI.Xaml.Thickness
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Thickness 
-->

# Thickness

## -description

Describes the thickness of a frame around a rectangle. Four [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true) values describe the **Left**, **Top**, **Right**, and **Bottom** sides of the rectangle, respectively.



## -xaml-syntax

```xaml
<Thickness ...>uniform</Thickness>
- or -
<Thickness ...>left&right,top&bottom</Thickness>
- or -
<Thickness ...>left,top,right,bottom</Thickness>
- or -
<object property="uniform"/>
- or -
<object property="left&right,top&bottom"/>
- or -
<object property="left,top,right,bottom" ... />
```

## -xaml-values

<dl><dt>uniform</dt><dd>uniformA numeric value that specifies a uniform Thickness. The uniform value is applied to all four Thickness values (Left, Top, Right, and Bottom).</dd>
<dt>left&amp;right</dt><dd>left&amp;rightA numeric value that specifies the Left and Right of a symmetrical Thickness.</dd>
<dt>top&amp;bottom</dt><dd>top&amp;bottomA numeric value that specifies the Top and Bottom of a symmetrical Thickness.</dd>
<dt>left,top,right,bottom</dt><dd>left,top,right,bottomNumeric values that specify the four possible dimension values of a Thickness structure (Left, Top, Right, and Bottom).</dd>
</dl>

## -struct-fields

### -field Left

The left side measure of the Thickness.

### -field Top

The top edge measure of the Thickness.

### -field Right

The right side measure of the Thickness.

### -field Bottom

The bottom edge measure of the Thickness.

## -remarks

Thickness values are generally used to set properties that affect the layout of the object where the property is set. Properties that use a Thickness value include:

+ [FrameworkElement.Margin](frameworkelement_margin.md)
+ [Control.Padding](../windows.ui.xaml.controls/control_padding.md)
+ [Border.BorderThickness](../windows.ui.xaml.controls/border_borderthickness.md) and [Control.BorderThickness](../windows.ui.xaml.controls/control_borderthickness.md)
+ Other **Margin** and **Padding** properties on classes that are not a [Control](../windows.ui.xaml.controls/control.md), for example [RichTextBlock.Padding](../windows.ui.xaml.controls/richtextblock_padding.md)
+ [Image.NineGrid](../windows.ui.xaml.controls/image_ninegrid.md)
+ [Shape.StrokeThickness](../windows.ui.xaml.shapes/shape_strokethickness.md)
+ [ProgressBarTemplateSettings.EllipseOffset](../windows.ui.xaml.controls.primitives/progressbartemplatesettings_ellipseoffset.md)

In XAML, you can specify Thickness values in several ways. If you specify four **Double** values, these represent the [Left](/uwp/api/windows.ui.xaml.thickness.left), [Top](/uwp/api/windows.ui.xaml.thickness.top), [Right](/uwp/api/windows.ui.xaml.thickness.right), and [Bottom](/uwp/api/windows.ui.xaml.thickness.bottom) sides, respectively, of the bounding rectangle. If you specify two values, these represent the **Left**, **Top** values, and also applies the same values to **Right** and **Bottom** such that the resulting Thickness is isometric horizontally and isometric vertically. You can also supply a single value, which applies a uniform value to all four sides of the bounding rectangle.

Values assigned from code do not have any behavior that can extrapolate values. If you set the value for a **Left** property or field, you do not automatically establish the same value for **Right**. All Thickness properties must be set discretely in code. You can use the [Thickness(Double)](/dotnet/api/windows.ui.xaml.thickness.-ctor?view=dotnet-uwp-10.0&preserve-view=true#Windows_UI_Xaml_Thickness__ctor_System_Double_) or [Thickness(Double,Double,Double,Double)](/dotnet/api/windows.ui.xaml.thickness.-ctor?view=dotnet-uwp-10.0&preserve-view=true#Windows_UI_Xaml_Thickness__ctor_System_Double_System_Double_System_Double_System_Double_) constructors rather than assigning values to properties.

Although the type of the data values of a Thickness is **Double**, you typically specify integer values.

### Notes on XAML syntax

A string that specifies three values does not cause a parser error, but only the first two values are interpreted, and any third value is ignored.

Although you can specify a Thickness as an object element, you cannot specify the individual values such as **Top** as attributes of that object element. The XAML parser does not support setting XAML attribute values for this structure. Instead, you must specify the values as initialization text within the Thickness. Using the object element syntax for a Thickness is useful if you want to declare a keyed resource that can be used by multiple [Control](../windows.ui.xaml.controls/control.md) instances for their [Padding](../windows.ui.xaml.controls/control_padding.md). For more info on XAML initialization text, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

You can use a space rather than a comma as the delimiter between values.

### Projection and members of Thickness

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or Visual C++ component extensions (C++/CX), then Thickness has non-data members available, and its data members are exposed as read-write properties, not fields. See [Thickness](/dotnet/api/windows.ui.xaml.thickness?view=dotnet-uwp-10.0&preserve-view=true) in the .NET API Browser.

If you are programming with [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) or the [Windows Runtime C++ Template Library (WRL)](/cpp/windows/windows-runtime-cpp-template-library-wrl), then only the data member fields exist as members of Thickness, and you cannot use the utility methods or properties of the .NET projection. C++ code can access similar utility methods that exist on the [ThicknessHelper](thicknesshelper.md) class.

This table shows the equivalent methods available in .NET and C++.

| .NET ([Thickness](/dotnet/api/windows.ui.xaml.thickness?view=dotnet-uwp-10.0&preserve-view=true)) | C++ ([ThicknessHelper](thicknesshelper.md)) |
| ---- | --- |
| [Thickness(Double)](/dotnet/api/windows.ui.xaml.thickness.-ctor?view=dotnet-uwp-10.0&preserve-view=true#windows-ui-xaml-thickness-ctor(system-double)) | [FromUniformLength(Double)](thicknesshelper_fromuniformlength_155036416.md) |
| [Thickness(Double, Double, Double, Double)](/dotnet/api/windows.ui.xaml.thickness.-ctor?view=dotnet-uwp-10.0&preserve-view=true#windows-ui-xaml-thickness-ctor(system-double-system-double-system-double-system-double)) | [FromLengths(Double, Double, Double, Double)](thicknesshelper_fromlengths_582957363.md) |

## -examples

## -see-also

[Border](../windows.ui.xaml.controls/border.md), [Control](../windows.ui.xaml.controls/control.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
