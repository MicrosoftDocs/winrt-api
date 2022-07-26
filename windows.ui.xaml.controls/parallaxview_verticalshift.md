---
-api-id: P:Windows.UI.Xaml.Controls.ParallaxView.VerticalShift
-api-type: winrt property
---

<!-- Property syntax.
public double VerticalShift { get;  set; }
-->

# Windows.UI.Xaml.Controls.ParallaxView.VerticalShift

## -description

Represents the vertical range of motion of the child element.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ParallaxView.VerticalShift](/windows/winui/api/microsoft.ui.xaml.controls.parallaxview.verticalshift) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<ParallaxView VerticalShift="double" .../>
```

## -property-value

The vertical range of motion. The default is 0.

## -remarks

The default value of 0 means there is no vertical parallax motion. A value of 100 means the Child element is sized to 100px taller than the ParallaxView, so the range of the parallax motion is 100px.

## -see-also

## -examples

