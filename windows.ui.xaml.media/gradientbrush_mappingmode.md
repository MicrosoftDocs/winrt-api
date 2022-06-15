---
-api-id: P:Windows.UI.Xaml.Media.GradientBrush.MappingMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.BrushMappingMode MappingMode { get;  set; }
-->

# Windows.UI.Xaml.Media.GradientBrush.MappingMode

## -description
Gets or sets a [BrushMappingMode](brushmappingmode.md) enumeration value that specifies whether the positioning coordinates of the gradient brush are absolute or relative to the output area.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.GradientBrush.MappingMode](/windows/winui/api/microsoft.ui.xaml.media.gradientbrush.mappingmode) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<gradientBrush MappingMode="Absolute"/>
-or-
<gradientBrush MappingMode="RelativeToBoundingBox"/>
```


## -property-value
A [BrushMappingMode](brushmappingmode.md) value that specifies how to interpret the gradient brush's positioning coordinates. The default is **RelativeToBoundingBox**.

## -remarks

## -examples

## -see-also
