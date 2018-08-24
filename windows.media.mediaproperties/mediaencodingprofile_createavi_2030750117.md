---
-api-id: M:Windows.Media.MediaProperties.MediaEncodingProfile.CreateAvi(Windows.Media.MediaProperties.VideoEncodingQuality)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.MediaProperties.MediaEncodingProfile CreateAvi(Windows.Media.MediaProperties.VideoEncodingQuality quality)
-->

# Windows.Media.MediaProperties.MediaEncodingProfile.CreateAvi

## -description
Creates an instance of [MediaEncodingProfile](mediaencodingprofile.md) for AVI.

## -parameters
### -param quality
The video quality.

## -returns
The media encoding profile.

## -remarks
The encoding quality **Auto** is a special preset that fills in the proper settings based on the current camera settings. Settings that are manually modified are ignored. For example, if you create a preset profile using one the static create methods, such as [CreateM4a](mediaencodingprofile_createm4a_1230065862.md), and specify **Auto** as the encoding quality, any changes you make to the properties will be overwritten with values based on the current camera settings.

## -examples

## -see-also
