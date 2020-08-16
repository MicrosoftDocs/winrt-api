---
-api-id: P:Windows.UI.Xaml.Media.AcrylicBrush.TintLuminosityOpacity
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public IReference<double> TintLuminosityOpacity { get;  set; }
-->

# Windows.UI.Xaml.Media.AcrylicBrush.TintLuminosityOpacity

## -description
Gets or sets the brightness amount between the TintColor and the underlying pixels behind the Acrylic surface.

## -property-value

The amount of luminosity that is visible through the surface where Acrylic is applied.

## -remarks

The TintLuminosityOpacity determines how much brightness, from the underlying pixels behind the Acrylic, to let through the blurred surface. A lower value means more brightness from the underlying pixels will be allowed through and a higher value means more brightness from the [TintColor](https://docs.microsoft.com/uwp/api/microsoft.ui.xaml.media.acrylicbrush.tintcolor?view=winui-2.2) property will be applied across the Acrylic surface.

TintLuminosityOpacity also helps balance any blacks or whites behind the Acrylic.

## -see-also

## -examples

