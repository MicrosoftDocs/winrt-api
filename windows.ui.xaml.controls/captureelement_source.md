---
-api-id: P:Windows.UI.Xaml.Controls.CaptureElement.Source
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Capture.MediaCapture Source { get;  set; }
-->

# Windows.UI.Xaml.Controls.CaptureElement.Source

## -description
Gets or sets the source [MediaCapture](../windows.media.capture/mediacapture.md) that this [CaptureElement](captureelement.md) represents.


## -property-value
The source [MediaCapture](../windows.media.capture/mediacapture.md)

## -remarks
This property should not be set in XAML, because XAML represents initial state, and there is no good way to reference a [MediaCapture](../windows.media.capture/mediacapture.md) through XAML resources. Initializing a [MediaCapture](../windows.media.capture/mediacapture.md) is typically done by async operations or only when a capture is about to begin.

> [!IMPORTANT]
> You should always set the Source property to null when you are shutting down media capture in your app. For more information on properly cleaning up media capture resources, see [Capture photos and video with MediaCapture](/windows/uwp/audio-video-camera/capture-photos-and-video-with-mediacapture).

## -examples

## -see-also
