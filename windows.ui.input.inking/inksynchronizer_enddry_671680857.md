---
-api-id: M:Windows.UI.Input.Inking.InkSynchronizer.EndDry
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void EndDry()
-->

# Windows.UI.Input.Inking.InkSynchronizer.EndDry

## -description
Finalizes a custom "dry" of ink input to the Direct2D device context of your app, instead of the default [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control, and notifies the system that "wet" ink can be removed. This requires an [IInkD2DRenderer](https://docs.microsoft.com/windows/desktop/api/inkrenderer/nn-inkrenderer-iinkd2drenderer) object to manage the ink input (see the [Complex ink sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk)).

By default, ink input is processed on a low-latency background thread and rendered "wet" as it is drawn. When the stroke is completed (pen or finger lifted, or mouse button released), the stroke is processed on the UI thread and rendered "dry" to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) layer (above the application content and replacing the wet ink).

By calling [ActivateCustomDrying](inkpresenter_activatecustomdrying_1826048524.md) (before the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) is loaded), an app creates an [InkSynchronizer](inksynchronizer.md) object to customize how an ink stroke is rendered dry to a [SurfaceImageSource](../windows.ui.xaml.media.imaging/surfaceimagesource.md) or [VirtualSurfaceImageSource](../windows.ui.xaml.media.imaging/virtualsurfaceimagesource.md). For example, an ink stroke could be rasterized and integrated into application content instead of as a separate [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) layer.

## -remarks

## -examples

## -see-also

[Pen and stylus interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

