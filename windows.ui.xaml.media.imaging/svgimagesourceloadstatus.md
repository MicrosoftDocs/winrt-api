---
-api-id: T:Windows.UI.Xaml.Media.Imaging.SvgImageSourceLoadStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum SvgImageSourceLoadStatus : int {
	Success = 0
	NetworkError = 1
	InvalidFormat = 2
	Other = 3
}
-->

# Windows.UI.Xaml.Media.Imaging.SvgImageSourceLoadStatus

## -description
Defines constants that specify the result of loading an [SvgImageSource](svgimagesource.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.Imaging.SvgImageSourceLoadStatus](/windows/winui/api/microsoft.ui.xaml.media.imaging.svgimagesourceloadstatus) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields
### -field Success:0
The SVG loaded.

### -field NetworkError:1
The SVG did not load due to a network error.

### -field InvalidFormat:2
The SVG did not load because the SVG format is invalid.

### -field Other:3
The SVG did not load for some other reason.

## -remarks

## -see-also
[SvgImageSource.SetSourceAsync](svgimagesource_setsourceasync_1118221574.md), [SvgImageSource.OpenFailed](svgimagesource_openfailed.md)

## -examples

