---
-api-id: T:Windows.UI.ColorHelper
-api-type: winrt class
---

<!-- Class syntax.
public class ColorHelper : Windows.UI.IColorHelper
-->

# Windows.UI.ColorHelper

## -description
Provides static helper methods for processing [Color](color.md) values. C# and Microsoft Visual Basic code should use methods of [Color](color.md) instead.

## -remarks
[Color](color.md) is a Windows Runtime structure that represents a color that has four channels: **A** (alpha), **R** (red), **G** (green), **B** (blue). Each of the values is stored as a **Byte** type with value 0-255. The most frequent application of [Color](color.md) is to define color-related properties in a UI element as part of a Windows Store app using C++, C#, or Visual Basic and its XAML UI definition.

[ColorHelper](colorhelper.md) is one of several **Helper** classes that are intended to provide utility methods for Windows Runtime structure values. C# and Microsoft Visual Basic code can use methods of [Color](color.md) instead, because utility methods are available directly on the structure due to .NET Framework runtime support. C++ code including Visual C++ component extensions (C++/CX) can only access the data values on [Color](color.md), for example the **A** field value. For C++ developers, some of the utility features that C# and Microsoft Visual Basic can use directly on [Color](color.md) as nondata members are available from the [ColorHelper](colorhelper.md) class.

## -examples

## -see-also
[Color](color.md), [Color.FromArgb](color_fromargb.md), [Colors](colors.md), [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md)