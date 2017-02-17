---
-api-id: T:Windows.Media.MediaProperties.VideoEncodingQuality
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.MediaProperties.VideoEncodingQuality : int
-->

# VideoEncodingQuality

## -description
Determines the video encoding format.

## -enum-fields
### -field Auto:0
**Auto** fills in the proper settings based on the current camera settings. So when **Auto** is used, settings that are manually modified are ignored. For example, if you create a preset profile using one the static create methods, such as [CreateWmv](mediaencodingprofile_createwmv.md), and specify **Auto** as the encoding quality, any changes you make to the properties will be overwritten with values based on the current camera settings.

### -field HD1080p:1
HD1080p format.

### -field HD720p:2
HD720p format.

### -field Wvga:3
Wvga format.

### -field Ntsc:4
Ntsc format.

### -field Pal:5
Pal format.

### -field Vga:6
Vga format.

### -field Qvga:7
Qvga format.


### -field Uhd2160p:8


### -field Uhd4320p:9


## -remarks

## -examples

## -see-also

