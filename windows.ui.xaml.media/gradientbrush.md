---
-api-id: T:Windows.UI.Xaml.Media.GradientBrush
-api-type: winrt class
---

<!-- Class syntax.
public class GradientBrush : Windows.UI.Xaml.Media.Brush, Windows.UI.Xaml.Media.IGradientBrush
-->

# Windows.UI.Xaml.Media.GradientBrush

## -description
An abstract class that describes a gradient, composed of gradient stops. Parent class for [LinearGradientBrush](lineargradientbrush.md).

## -remarks
You describe the color composition of a [LinearGradientBrush](lineargradientbrush.md) using the [GradientStops](gradientbrush_gradientstops.md) property. Each [GradientStop](gradientstop.md) therein expresses a [Color](gradientstop_color.md) and an [Offset](gradientstop_offset.md). [Offset](gradientstop_offset.md) values should be between 0 and 1. [Color](gradientstop_color.md) values can be any value expressed as a named color or one of the conversion syntaxes; see notes in [GradientStop.Color](gradientstop_color.md), particularly the XAML syntax.

### **GradientBrush** derived classes

GradientBrush is the parent class for [LinearGradientBrush](lineargradientbrush.md). The Windows Runtime XAML vocabulary doesn't support **RadialGradientBrush**.

## -examples

## -see-also
[Brush](brush.md), [LinearGradientBrush](lineargradientbrush.md), [GradientStop](gradientstop.md), [Use brushes](https://docs.microsoft.com/windows/uwp/graphics/using-brushes)
