---
-api-id: M:Windows.UI.ColorHelper.FromArgb(System.Byte,System.Byte,System.Byte,System.Byte)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Color FromArgb(System.Byte a, System.Byte r, System.Byte g, System.Byte b)
-->

# Windows.UI.ColorHelper.FromArgb

## -description
Generates a [Color](color.md) structure, based on discrete **Byte** values for **ARGB** components. C# and Microsoft Visual Basic code should use **Color.FromArgb** instead.

## -parameters
### -param a
The **A** (transparency) component of the desired color. Range is 0-255.

### -param r
The **R** component of the desired color. Range is 0-255.

### -param g
The **G** component of the desired color. Range is 0-255.

### -param b
The **B** component of the desired color. Range is 0-255.

## -returns
The generated [Color](color.md) value.

## -remarks
> **C#/Visual Basic**
> The [ColorHelper](colorhelper.md) class is available for use from C# and Visual Basic code but it's not commonly used. The **FromArgb** method that's available as a static method of the [Color](color.md) structure has exactly the same functionality, and you also have other API there that's more convenient to use from [Color](color.md) itself rather than using the [ColorHelper](colorhelper.md) class. [ColorHelper](colorhelper.md) is mainly intended for C++ code, which doesn't have access to the nondata API of the [Color](color.md) structure.

The most common reason for creating a [Color](color.md) value is to use it as an argument for the [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush_solidcolorbrush_2106742027.md) constructor, then assign that brush to a XAML UI property.

## -examples

This example shows how to create a Color.

```cppwinrt
Windows::UI::Color orangeColor{ Windows::UI::ColorHelper::FromArgb(255, 255, 128, 0) };
```

```cppcx
auto orangeColor = Windows::UI::ColorHelper::FromArgb(255, 255, 128, 0);
```

This example shows how to create a SolidColorBrush with the specified Color.

```cppwinrt
Windows::UI::Xaml::Media::SolidColorBrush greenBrush{
    Windows::UI::ColorHelper::FromArgb(255, 90, 200, 90) };
```

```cppcx
auto greenBrush = ref new SolidColorBrush(Windows::UI::ColorHelper::FromArgb(255, 90, 200, 90));
```

## -see-also
[SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md)
