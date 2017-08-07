---
-api-id: M:Windows.UI.Input.Inking.InkPresenter.ActivateCustomDrying
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Inking.InkSynchronizer ActivateCustomDrying()
-->

# Windows.UI.Input.Inking.InkPresenter.ActivateCustomDrying

## -description
Indicates that your app requires complete control of ink input rendering. 

By default, ink input is processed on a low-latency background thread and rendered "wet" as it is drawn. When the stroke is completed (pen or finger lifted, or mouse button released), the stroke is processed on the UI thread and rendered "dry" to the rendering layer (above the application content and replacing the wet ink).

### InkPresenter hosting models

**[InkCanvas](../windows.ui.xaml.controls/inkcanvas.md)**

By calling [ActivateCustomDrying](inkpresenter_activatecustomdrying.md) (before the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) is loaded), an app creates an [InkSynchronizer](inksynchronizer.md) object to customize how an ink stroke is rendered dry to a [SurfaceImageSource](../windows.ui.xaml.media.imaging/surfaceimagesource.md) or [VirtualSurfaceImageSource](../windows.ui.xaml.media.imaging/virtualsurfaceimagesource.md). For example, an ink stroke could be rasterized and integrated into application content instead of as a separate [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) layer.

**[InkDesktopHost](https://msdn.microsoft.com/library/windows/desktop/mt622161.aspx)** (Windows 10 version 1511 and newer)

Win32 apps can host an [InkPresenter](inkpresenter.md) in an [InkDesktopHost](https://msdn.microsoft.com/library/windows/desktop/mt622161.aspx)  using the DirectComposition visual tree.  

This requires an [IInkD2DRenderer](http://msdn.microsoft.com/library/d1bd910d-ce64-4424-a0e1-4f55110b0265) object to manage the ink input (see the [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)).

**[CoreInkPresenterHost](../windows.ui.input.inking.core/coreinkpresenterhost.md)** (Windows 10 Fall Creators Update and newer)

Host an [InkPresenter](inkpresenter.md) in your own [Windows.​UI.​Composition](../windows.ui.composition/windows_ui_composition.md) tree without an associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

## -returns
The object used for custom ink stroke rendering.

## -remarks
#### Error codes
##### E_ILLEGAL_METHOD_CALL  (0x8000000E)
Thrown if [ActivateCustomDrying](inkpresenter_activatecustomdrying.md) is called after [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) is loaded.

This method must be called prior to loading the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

**Custom drying and the InkToolbar**  
By default, ink input is processed on a low-latency background thread and rendered "wet" as it is drawn. When the stroke is completed (pen or finger lifted, or mouse button released), the stroke is processed on the UI thread and rendered "dry" to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) layer (above the application content and replacing the wet ink). The ink platform enables you to override this behavior and completely customize the inking experience by custom drying the ink input.  

If your app overrides the default ink rendering behavior of the [InkPresenter](inkpresenter.md) with a custom drying implementation, the rendered ink strokes are no longer available to the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md) and the built-in erase commands of the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md) do not work as expected. To provide erase functionality, you must handle all pointer events, perform hit-testing on each stroke, and override the built-in "Erase all ink" command.

For more info on custom drying, see [Pen interactions and Windows Ink in UWP apps](https://msdn.microsoft.com/en-us/windows/uwp/input-and-devices/pen-and-stylus-interactions#custom-ink-rendering).

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)