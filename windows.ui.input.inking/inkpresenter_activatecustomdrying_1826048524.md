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

By calling ActivateCustomDrying (before the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) is loaded), an app creates an [InkSynchronizer](inksynchronizer.md) object to customize how an ink stroke is rendered dry to a [SurfaceImageSource](../windows.ui.xaml.media.imaging/surfaceimagesource.md) or [VirtualSurfaceImageSource](../windows.ui.xaml.media.imaging/virtualsurfaceimagesource.md). For example, an ink stroke could be rasterized and integrated into application content instead of as a separate [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) layer.

**[InkDesktopHost](/previous-versions/windows/desktop/legacy/mt622161(v=vs.85))** (Windows 10 version 1511 and newer)

Win32 apps can host an [InkPresenter](inkpresenter.md) in an [InkDesktopHost](/previous-versions/windows/desktop/legacy/mt622161(v=vs.85))  using the DirectComposition visual tree.  

This requires an [IInkD2DRenderer](/windows/desktop/api/inkrenderer/nn-inkrenderer-iinkd2drenderer) object to manage the ink input (see the [Complex ink sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk)).

**[CoreInkPresenterHost](../windows.ui.input.inking.core/coreinkpresenterhost.md)** (Windows 10 Fall Creators Update and newer)

Host an [InkPresenter](inkpresenter.md) in your own [Windows.​UI.​Composition](../windows.ui.composition/windows_ui_composition.md) tree without an associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

## -returns
The object used for custom ink stroke rendering.

## -remarks
#### Error codes
##### E_ILLEGAL_METHOD_CALL  (0x8000000E)
Thrown if ActivateCustomDrying is called after [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) is loaded.

This method must be called prior to loading the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

**Custom drying and the InkToolbar**  
By default, ink input is processed on a low-latency background thread and rendered "wet" as it is drawn. When the stroke is completed (pen or finger lifted, or mouse button released), the stroke is processed on the UI thread and rendered "dry" to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) layer (above the application content and replacing the wet ink). The ink platform enables you to override this behavior and completely customize the inking experience by custom drying the ink input.  

If your app overrides the default ink rendering behavior of the [InkPresenter](inkpresenter.md) with a custom drying implementation, the rendered ink strokes are no longer available to the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md) and the built-in erase commands of the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md) do not work as expected. To provide erase functionality, you must handle all pointer events, perform hit-testing on each stroke, and override the built-in "Erase all ink" command.

For more info on custom drying, see [Pen interactions and Windows Ink in UWP apps](/windows/uwp/input-and-devices/pen-and-stylus-interactions).

## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

