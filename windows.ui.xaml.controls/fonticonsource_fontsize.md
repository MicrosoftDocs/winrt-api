---
-api-id: P:Windows.UI.Xaml.Controls.FontIconSource.FontSize
-api-type: winrt property
---

<!-- Property syntax.
public double FontSize { get;  set; }
-->

# Windows.UI.Xaml.Controls.FontIconSource.FontSize

## -description

Gets or sets the size of the icon glyph.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.FontIconSource.FontSize](/windows/winui/api/microsoft.ui.xaml.controls.fonticonsource.fontsize) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<FontIconSource FontSize="double" .../>
```

## -property-value

A non-negative value that specifies the font size, measured in pixels.

## -remarks

The unit measure for [FontSize](control_fontsize.md) is pixels, measuring the line height of the characters in the font. The apparent size of text in the UI can vary based on the current scaling. If you want to use different [FontSize](control_fontsize.md) values for different scalings, you can do this using the resources system.

## -see-also

## -examples

