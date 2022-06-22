---
-api-id: T:Windows.UI.Xaml.Media.GradientBrush
-api-type: winrt class
---

<!-- Class syntax.
public class GradientBrush : Windows.UI.Xaml.Media.Brush, Windows.UI.Xaml.Media.IGradientBrush
-->

# Windows.UI.Xaml.Media.GradientBrush

## -description

An abstract class that describes a gradient, composed of gradient stops.



## -remarks

Use the [GradientStops](gradientbrush_gradientstops.md) property to describe the color composition of a [LinearGradientBrush](lineargradientbrush.md) where each [GradientStop](gradientstop.md) specifies a [Color](gradientstop_color.md) and an [Offset](gradientstop_offset.md). Each [Offset](gradientstop_offset.md) value should be between 0 and 1.

[Color](gradientstop_color.md) values can be any value expressed as a named color or one of the conversion syntaxes.

### **GradientBrush** derived classes

GradientBrush is the parent class for [LinearGradientBrush](lineargradientbrush.md).

## -examples

## -see-also

[Brush](brush.md), [LinearGradientBrush](lineargradientbrush.md), [RadialGradientBrush](/uwp/api/microsoft.ui.xaml.media.radialgradientbrush), [GradientStop](gradientstop.md), [Use brushes](/windows/uwp/graphics/using-brushes)
