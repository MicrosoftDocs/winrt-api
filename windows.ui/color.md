---
-api-id: T:Windows.UI.Color
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Color 
-->

# Color

## -description
Describes a color in terms of alpha, red, green, and blue channels.
## -xaml-syntax
```xaml
<Color ...>predefinedColor</Color>
- or -
<Color ...>#rgb</Color>
- or -
<Color ...>#argb</Color>
- or -
<Color ...>#rrggbb</Color>
- or -
<Color ...>#aarrggbb</Color>
- or -
<Color ...>sc#scR,scG,scB</Color>
- or -
<Color ...>sc#scA,scR,scG,scB</Color>
- or -
<object property="predefinedColor"/>
- or -
<object property="#rgb"/>
- or -
<object property="#argb"/>
- or -
<object property="#rrggbb"/>
- or -
<object property="#aarrggbb"/>
- or -
<object property="sc#scR,scG,scB"/>
- or -
<object property="sc#scA,scR,scG,scB"/>
```

## -xaml-values
<dl><dt>predefinedColor</dt><dd>One of the colors predefined by the Colors class. See members of Colors for a list. These are static properties. Specify just the color name, for example Transparent. Do not include the static class qualifier in the string: for example Colors.Transparent does not parse in XAML.</dd>
<dt>rgb</dt><dd>A three-character hexadecimal value. The first character specifies the color's R value, the second character specifies the G value, and the third character specifies the B value. For example, 00F.</dd>
<dt>argb</dt><dd>A four-character hexadecimal value. The first character specifies the color's A value, the second character specifies its R value, the third character specifies the G value, and the fourth character specifies its B value. For example, F00F.</dd>
<dt>rrggbb</dt><dd>A six-character hexadecimal value. The first two characters specify the color's R value, the next two specify its G value, and the final two specify its B value. For example, 0000FF.</dd>
<dt>aarrggbb</dt><dd>An eight-character hexadecimal value. The first two characters specify the color's A value, the next two specify its R value, the next two specify its G value, and the final two specify its B value. For example, FF0000FF.</dd>
<dt>scA</dt><dd>The color's ScA value as a value between 0 and 1.</dd>
<dt>scR</dt><dd>The color's ScR value as a value between 0 and 1.</dd>
<dt>scG</dt><dd>The color's ScG value as a value between 0 and 1.</dd>
<dt>scB</dt><dd>The color's ScB value as a value between 0 and 1.</dd>
</dl>

## -struct-fields

### -field A
Gets or sets the **sRGB** alpha channel value of the color.
    

### -field R
Gets or sets the **sRGB** red channel value of the color.
    

### -field G
Gets or sets the **sRGB** green channel value of the color.
    

### -field B
Gets or sets the **sRGB** blue channel value of the color.
    

## -remarks
Color is a Windows Runtime structure that represents a color that has four channels: **A** (alpha), **R** (red), **G** (green), **B** (blue). Each of the values is stored as a **Byte** type with value 0-255.

Color values are used in these features and scenarios:
+ Colors for start screens and general UI (for example [SecondaryTile.BackgroundColor](../windows.ui.startscreen/secondarytile_backgroundcolor.md) and [UISettings.UIElementColor](../windows.ui.viewmanagement/uisettings_uielementcolor_197668507.md)). These can be used in JavaScript.
+ Color values for the Windows 8 ink system. Specifically, [InkDrawingAttributes.Color](../windows.ui.input.inking/inkdrawingattributes_color.md). This can be used in JavaScript.
+ Color values for XAML UI and UWP app using C++, C#, or Visual Basic, particularly for brushes. These API can't be used in JavaScript.
+ Defining color values that are used for interfaces representing text, in the [Windows.UI.Text](../windows.ui.text/windows_ui_text.md) namespace. These API can't be used in JavaScript.


### Color values and XAML definitions

The most frequent application of Color is to define color-related properties in a UI element as part of a UWP app using C++, C#, or Visual Basic and its XAML UI definition.

Various predefined Color values are available as static properties on the [Colors](colors.md) class. These properties are useful for setting Color values in code that match the attribute string form used in XAML to set a named Color. For example, the [Colors.AliceBlue](colors_aliceblue.md) property returns a Color that is equal to Color from the XAML usage `<SolidColorBrush Color="AliceBlue" />`. You can also use the [Colors](colors.md) values for equality comparisons against a Color.

In most XAML UI scenarios, a Color isn't used directly as a property value of a [UIElement](../windows.ui.xaml/uielement.md). Instead, a Color is used as a component value of a [Brush](../windows.ui.xaml.media/brush.md) (either [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) or [LinearGradientBrush](../windows.ui.xaml.media/lineargradientbrush.md)). However, the [Brush](../windows.ui.xaml.media/brush.md) type enables a XAML shorthand that lets you set an attribute value of type [Brush](../windows.ui.xaml.media/brush.md) using a named color string, or a format string that can be parsed into an **ARGB** form. For example, you can set the [Brush](../windows.ui.xaml.media/brush.md)-type value [TextBlock.Foreground](../windows.ui.xaml.controls/textblock_foreground.md) using a syntax such as `<TextBlock Foreground="Cyan" />`. This syntax implicitly creates a new [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) with a Color value equal to [Cyan](colors_cyan.md) that fills the [Brush](../windows.ui.xaml.media/brush.md)-type value of [TextBlock.Foreground](../windows.ui.xaml.controls/textblock_foreground.md) for that element. For more info on using brushes and colors in XAML, see [Use brushes](/windows/uwp/graphics/using-brushes).

If you use the same color brush often in your XAML, you should define a [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) as a resource rather than using the inline implicit creation of new values, because that's more efficient. For more info, see [Optimize your XAML markup](/windows/uwp/debug-test-perf/optimize-xaml-loading) or [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary). You might also want to use system colors, which can be accessed as merged-in resources for themes that the system defines. See [XAML theme resources](/windows/apps/design/style/xaml-theme-resources).

There are also some XAML properties that take a direct Color value. These mostly support animating a Color value that exists on a [Brush](../windows.ui.xaml.media/brush.md). The Windows Runtime supports an interpolation logic so that you can animate from one Color to another in a **From**/**To** animation and the animation will use interpolated Color values as the animation runs. For more info, see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations).

### Notes on XAML syntax

If you use the "#" token to specify color values in hex form, the hex values are stored in the structure as values between 0 and 255, not as the original hex strings. If you use the "sc#" token, the values are also stored as values between 0 and 255, not the original value of 0 to 1.

Strings for named colors are interpreted based on the associated [Colors](colors.md) constants, and the values for **A**, **R**, **G** and **B** are set in the structure as values between 0 and 255 that are representative of that color.

The XAML object element usage (with initialization text) is useful for declaring a Color as a resource in a XAML [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md). For more info, see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

This table explains the color value placeholders shown in the XAML Syntax section.

| Value | Notes |
| - | - |
| _predefinedColor_ | One of the colors predefined by the [Colors](colors.md) class. See members of `Colors` for a list. These are static properties. Specify just the color name, for example `Transparent`. Do not include the static class qualifier in the string: for example, "Colors.Transparent" does not parse in XAML.<br/>`<Grid Background="Blue"/>`, `<Color>Blue</Color>` |
| _rgb_ | A three-character hexadecimal value. The first character specifies the color's R value, the second character specifies the G value, and the third character specifies the B value. For example, 00F.<br/>`<Grid Background="#00F"/>`, `<Color>#00F</Color>` |
| _argb_ | A four-character hexadecimal value. The first character specifies the color's A value, the second character specifies its R value, the third character specifies the G value, and the fourth character specifies its B value. For example, F00F.<br/>`<Grid Background="#F00F"/>`, `<Color>#F00F</Color>` |
| _rrggbb_ | A six-character hexadecimal value. The first two characters specify the color's R value, the next two specify its G value, and the final two specify its B value. For example, 0000FF.<br/>`<Grid Background="#0000FF"/>`, `<Color>#0000FF</Color>` |
| _aarrggbb_ | An eight-character hexadecimal value. The first two characters specify the color's A value, the next two specify its R value, the next two specify its G value, and the final two specify its B value. For example, FF0000FF.<br/>`<Grid Background="#FF0000FF"/>`, `<Color>#FF0000FF</Color>` |
| _scA_ | The color's ScA (alpha) value as a value between 0 and 1.<br/>`<Grid Background="sc#1,0,0,1"/>`, `<Color>sc#1,0,0,1</Color>` |
| _scR_ | The color's ScR (red) value as a value between 0 and 1. |
| _scG_ | The color's ScG (green) value as a value between 0 and 1. |
| _scB_ | The color's ScB (blue) value as a value between 0 and 1. |

### Projection and members of Color

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic) then Color has a static method **FromArgb** that acts as a Color value generator. Also, the data members of Color are exposed as read-write properties.

If you are programming with C++, either Visual C++ component extensions (C++/CX) or WRL, then only the data member fields exist as members of Color, and you cannot use the utility methods or properties listed in the members table. C++ code can use an equivalent [FromArgb](colorhelper_fromargb_1449236110.md) method on the [ColorHelper](colorhelper.md) class, and the [Platform::Object](/cpp/cppcx/platform-object-class) methods.

### ToString behavior for Color

For C# and Microsoft Visual Basic, the language support for the Color structure provides a behavior for `ToString` that serializes the values of the **ARGB** data properties into a single string. The string representations of Color values are similar to XAML attribute string syntax for specifying Color values in markup. It is the syntax that is most commonly used by designer tools to specify a (non-named) Color. The string is in the form `#AARRGGBB`, where each letter pair represents one of the color channels as a value between `00` and `FF`. Each letter pair is interpreted as if it were a hex value and thus represents a value between 0 and 255. The string always starts with a hash (**#**). For example, the string form of the color where `A=255, R=0, G=128, B=255` is "#FF0080FF". For named colors you get the serialized string and not the constant name; for example calling `ToString` on [Colors.Blue](colors_blue.md) gives "#FF0000FF".

> [!NOTE]
> Visual C++ component extensions (C++/CX) doesn't use nondata members of Color, and doesn't enable this form of string returned from `ToString()`. The `ToString()` value returned from Visual C++ component extensions (C++/CX) for a Color is the unmodified [Platform::Object::ToString](/cpp/cppcx/platform-object-class#tostring) behavior, which gives a representation of the type (boxed by [IReference](../windows.foundation/ireference_1.md)) and does not indicate the value.

## -examples
Here's the syntax for defining a Color value as a resource in a XAML [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md). You'd typically only need this if you are defining a color that is not already one of the 250+ colors provided as the values in the [Colors](colors.md) class, and you want to use the XAML resource system as enforcement that you're using the same color in multiple areas of your app UI. Note the [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute), required when you define a XAML resource.

```xaml
  <Application.Resources>
    ...
    <Color x:Key="SlightlyOffBlue">#FF0000E8</Color>
  </Application.Resources>
```

```xaml
<!-- example reference to the resource, make sure is a property that is really Color not Brush-->
      <ColorAnimation Storyboard.TargetName="mySolidColorBrush"
        Storyboard.TargetProperty="Color" To="{StaticResource SlightlyOffBlue}" Duration="0:0:4"/>

```

This code shows a two-way converter for [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) and Color values. This can be useful for databinding scenarios, because it implements the [IValueConverter](../windows.ui.xaml.data/ivalueconverter.md) pattern that the [Converter](../windows.ui.xaml.data/binding_converter.md) property of a data binding can use, and you can then bind a [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) source to a Color target and vice versa. To see this code in context, see the source for the [SwapChainPanel sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20SwapChainPanel%20DirectX%20interop%20sample).

```csharp
    class BrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return new SolidColorBrush((value is Color) ? (Color)value : Colors.Black);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return (value is SolidColorBrush) ? (value as SolidColorBrush).Color : Colors.Black;
        }
    }
```



## -see-also
[Use brushes](/windows/uwp/graphics/using-brushes), [Colors](colors.md), [ColorHelper](colorhelper.md), [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md), [LinearGradientBrush](../windows.ui.xaml.media/lineargradientbrush.md), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)
