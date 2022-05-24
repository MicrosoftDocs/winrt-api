---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.ActualStereo3DVideoPackingMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Stereo3DVideoPackingMode ActualStereo3DVideoPackingMode { get; }
-->

# Windows.UI.Xaml.Controls.MediaElement.ActualStereo3DVideoPackingMode

## -description
Gets an enumeration value that determines the current value of stereo 3-D video frame-packing mode, accounting for other factors such as whether the media engine is ready for use.


## -property-value
A value of the enumeration. May be **None** if media engine is not ready for use.

## -remarks
ActualStereo3DVideoPackingMode is used to determine the current [Stereo3DVideoPackingMode](mediaelement_stereo3dvideopackingmode.md) being used by the subsystem. This could be different than what is set by the app author or if the app author sets **None** which is the default of [Stereo3DVideoPackingMode](mediaelement_stereo3dvideopackingmode.md).

## -examples

## -see-also
[Stereo3DVideoPackingMode](mediaelement_stereo3dvideopackingmode.md)
