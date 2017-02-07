---
-api-id: T:Windows.UI.Xaml.Thickness
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Thickness 
-->

# Thickness

## -description
Describes the thickness of a frame around a rectangle. Four [Double](https://msdn.microsoft.com/library/system.double.aspx) values describe the **Left**, **Top**, **Right**, and **Bottom** sides of the rectangle, respectively.
## -xaml-syntax
```xaml
<Thickness ...>uniform</Thickness>
- or -
<Thickness ...>left&right,top&bottom</Thickness>
- or -
<Thickness ...>left,top,right,bottom</Thickness>
```

```xaml
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
The left side measure of the [Thickness](thickness.md).
    

### -field Top
The top edge measure of the [Thickness](thickness.md).
    

### -field Right
The right side measure of the [Thickness](thickness.md).
    

### -field Bottom
The bottom edge measure of the [Thickness](thickness.md).
    

## -remarks
[Thickness](thickness.md) values are generally used to set properties that affect the layout of the object where the property is set. Properties that use a [Thickness](thickness.md) value include:
+ [FrameworkElement.Margin](frameworkelement_margin.md)
+ [Control.Padding](../windows.ui.xaml.controls/control_padding.md)
+ [Border.BorderThickness](../windows.ui.xaml.controls/border_borderthickness.md) and [Control.BorderThickness](../windows.ui.xaml.controls/control_borderthickness.md)
+ Other **Margin** and **Padding** properties on classes that are not a [Control](../windows.ui.xaml.controls/control.md), for example [RichTextBlock.Padding](../windows.ui.xaml.controls/richtextblock_padding.md)
+ [Image.NineGrid](../windows.ui.xaml.controls/image_ninegrid.md)
+ [Shape.StrokeThickness](../windows.ui.xaml.shapes/shape_strokethickness.md)
+ [ProgressBarTemplateSettings.EllipseOffset](../windows.ui.xaml.controls.primitives/progressbartemplatesettings_ellipseoffset.md)


In XAML, you can specify [Thickness](thickness.md) values in several ways. If you specify four **Double** values, these represent the [Left](thickness_left.md), [Top](thickness_top.md), [Right](thickness_right.md), and [Bottom](thickness_bottom.md) sides, respectively, of the bounding rectangle. if you specify two values, these represent the **Left**, **Top** values, and also applies the same values to **Right** and **Bottom** such that the resulting [Thickness](thickness.md) is isometric horizontally and isometric vertically. You can also supply a single value, which applies a uniform value to all four sides of the bounding rectangle.

Values assigned from code do not have any behavior that can extrapolate values. If you set the value for a **Left** property or field, you do not automatically establish the same value for **Right**. All [Thickness](thickness.md) properties must be set discretely in code. You can use the [Thickness(Double)](thickness_thickness_1.md) or [Thickness(Double,Double,Double,Double)](thickness_thickness_2.md) constructors rather than assigning values to properties.

Although the type of the data values of a [Thickness](thickness.md) is **Double**, you typically specify integer values.

### Notes on XAML syntax

A string that specifies three values does not cause a parser error, but only the first two values are interpreted, and any third value is ignored.

Although you can specify a [Thickness](thickness.md) as an object element, you cannot specify the individual values such as **Top** as attributes of that object element. The XAML parser does not support setting XAML attribute values for this structure. Instead, you must specify the values as initialization text within the [Thickness](thickness.md). Using the object element syntax for a [Thickness](thickness.md) is useful if you want to declare a keyed resource that can be used by multiple [Control](../windows.ui.xaml.controls/control.md) instances for their [Padding](../windows.ui.xaml.controls/control_padding.md). For more info on XAML initialization text, see [XAML syntax guide](http://msdn.microsoft.com/library/a57fe7b4-9947-4aa0-bc99-5fe4686b611d).

You can use a space rather than a comma as the delimiter between values.

### Projection and members of Thickness

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or in Visual C++ component extensions (C++/CX), then [Thickness](thickness.md) has non-data members available, and its data members are exposed as read-write properties, not fields.

If you are programming with C++ using the Windows Runtime Template Library (WRL), then only the data member fields exist as members of [Thickness](thickness.md), and you cannot use the utility methods or properties listed in the members table. WRL code can access similar utility methods that exist on the [ThicknessHelper](thicknesshelper.md) class.

## -examples

## -see-also
[Border](../windows.ui.xaml.controls/border.md), [Control](../windows.ui.xaml.controls/control.md), [Define layouts with XAML](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079)