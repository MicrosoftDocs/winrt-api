---
-api-id: T:Windows.UI.Xaml.Media.Imaging.SurfaceImageSource
-api-type: winrt class
---

<!-- Class syntax.
public class SurfaceImageSource : Windows.UI.Xaml.Media.ImageSource, Windows.UI.Xaml.Media.Imaging.ISurfaceImageSource
-->

# Windows.UI.Xaml.Media.Imaging.SurfaceImageSource

## -description
Provides Microsoft DirectX shared surfaces to draw into and then composes the bits into app content.



## -remarks
This class is a display area for Microsoft DirectX interoperation whereby Microsoft DirectX content can draw within an otherwise XAML-composed UI. One consideration for a SurfaceImageSource is that while it can incorporate the Microsoft DirectX content, the rendering cycle is still XAML-centric. Too many Microsoft DirectX draws in this render model can result in latency or poor responsiveness. If you anticipate a high number of redraws for your Microsoft DirectX content, and you intend to display that content full-screen without any surrounding XAML UI, you probably should use the [SwapChainBackgroundPanel](../windows.ui.xaml.controls/swapchainbackgroundpanel.md) technique instead. Another alternative for non-full-screen content is to render to a separate scratch surface on a background thread, then copy its contents to the surface returned from **BeginDraw** on the UI thread. This can unblock the UI thread at the cost of higher memory usage.

For more info on how to draw to a SurfaceImageSource, including sample code, see [DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10)).

This class has additional API, but those API are for Microsoft DirectX interoperation and are not part of the general app programming model otherwise described in this documentation. For example, from the Microsoft DirectX side, you can call **BeginDraw**.

### **SurfaceImageSource** derived classes

SurfaceImageSource is the parent class for [VirtualSurfaceImageSource](virtualsurfaceimagesource.md).

## -examples

## -see-also
[DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10)), [VirtualSurfaceImageSource](virtualsurfaceimagesource.md), [SwapChainBackgroundPanel](../windows.ui.xaml.controls/swapchainbackgroundpanel.md), [SurfaceImageSource sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20SurfaceImageSource%20DirectX%20interop%20sample/C%23%20and%20C%2B%2B)
