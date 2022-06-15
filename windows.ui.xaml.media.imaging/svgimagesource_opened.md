---
-api-id: E:Windows.UI.Xaml.Media.Imaging.SvgImageSource.Opened
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler Opened<SvgImageSource, SvgImageSourceOpenedEventArgs>
-->

# Windows.UI.Xaml.Media.Imaging.SvgImageSource.Opened

## -description
Occurs when the SVG source is downloaded and decoded with no failure.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.Imaging.SvgImageSource.Opened](/windows/winui/api/microsoft.ui.xaml.media.imaging.svgimagesource.opened) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<SvgImageSource Opened="eventhandler"/>
```

## -remarks
When the Opened event occurs, it serves as the notification that any asynchronous operations have completed and all the properties of an [SvgImageSource](svgimagesource.md) are ready for use.


