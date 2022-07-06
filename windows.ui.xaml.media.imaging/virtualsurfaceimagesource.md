---
-api-id: T:Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource
-api-type: winrt class
---

<!-- Class syntax.
public class VirtualSurfaceImageSource : Windows.UI.Xaml.Media.Imaging.SurfaceImageSource, Windows.UI.Xaml.Media.Imaging.IVirtualSurfaceImageSource
-->

# Windows.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource

## -description
Extends [SurfaceImageSource](surfaceimagesource.md) to support scenarios when the content is potentially larger than what can fit on screen and the content must be virtualized to render optimally.



## -remarks
This class has additional API, but those API are for Microsoft DirectX interoperation and are not part of the general app programming model otherwise described in this documentation. For example, from the Microsoft DirectX side, you can call **BeginDraw**. For more info on how to draw to a VirtualSurfaceImageSource, including sample code, see [DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10)).

## -examples

## -see-also
[SurfaceImageSource](surfaceimagesource.md)
