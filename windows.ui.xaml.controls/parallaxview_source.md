---
-api-id: P:Windows.UI.Xaml.Controls.ParallaxView.Source
-api-type: winrt property
---

<!-- Property syntax.
public UIElement Source { get;  set; }
-->

# Windows.UI.Xaml.Controls.ParallaxView.Source

## -description

The element that either is or contains the ScrollViewer that controls the parallax operation.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.ParallaxView.Source](/windows/winui/api/microsoft.ui.xaml.controls.parallaxview.source) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<ParallaxView Source="sourceElement" .../>
```

## -property-value

## -remarks

If the source element is not a ScrollViewer, the XAML tree is walked starting at the source element to find an embedded ScrollViewer.

## -see-also

## -examples

