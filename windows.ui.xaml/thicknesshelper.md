---
-api-id: T:Windows.UI.Xaml.ThicknessHelper
-api-type: winrt class
---

<!-- Class syntax.
public class ThicknessHelper : Windows.UI.Xaml.IThicknessHelper
-->

# Windows.UI.Xaml.ThicknessHelper

## -description
Provides helper methods to evaluate or set [Thickness](thickness.md) values. C# and Microsoft Visual Basic code should use members of [Thickness](thickness.md) instead.

## -remarks
[Thickness](thickness.md) is a Windows Runtime structure that represents a pixel measure applied to the outside (margin) or inside (padding) render dimensions of a rectangular UI element. For example, [Border.BorderThickness](../windows.ui.xaml.controls/border_borderthickness.md) uses a [Thickness](thickness.md) value.

[ThicknessHelper](thicknesshelper.md) is one of several **Helper** classes that are intended to provide utility methods for Windows Runtime structure values. C# and Microsoft Visual Basic code can use members of [Thickness](thickness.md) instead, because utility members are available directly on the structure due to .NET Framework runtime support. C++ code can only access the data values on [Thickness](thickness.md), for example the **Top** field value. For C++ developers, approximately the same utility features that a Microsoft Visual Basic developer could use directly on [Thickness](thickness.md) are available in a static form on the [ThicknessHelper](thicknesshelper.md) class.

## -examples

## -see-also
[Thickness](thickness.md), [Margin](frameworkelement_margin.md), [Padding](../windows.ui.xaml.controls/control_padding.md), [Define layouts with XAML](https://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079)
