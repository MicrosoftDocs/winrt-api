---
-api-id: T:Windows.Media.Capture.KnownVideoProfile
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.KnownVideoProfile : int
-->

# KnownVideoProfile

## -description
Specifies the names of video recording profiles that are known by the system.

## -enum-fields
### -field VideoRecording:0
The profile provides hints to the driver to optimize for high-quality video, prioritizing higher resolution and frame rates over power consumption and latency.

### -field HighQualityPhoto:1
The profile provides hints to the driver to optimize for high-quality photo capture.

### -field BalancedVideoAndPhoto:2
The profile provides hints to the driver to allow for photo capture during video capture with balanced quality between both.

### -field VideoConferencing:3
The profile provides hints to the driver to optimize for VoIP scenarios, prioritizing lower power consumption, lower latency, and concurrency (for example, using the front and back cameras of a device simultaneously) while deprioritizing higher resolution.

### -field PhotoSequence:4
The profile provides hints to the driver to optimize for capturing photo sequences.

### -field HighFrameRate:5
The profile provides hints to the driver to optimize for high frame rate video capture.

### -field VariablePhotoSequence:6
The profile provides hints to the driver to optimize for capturing variable photo sequences.

### -field HdrWithWcgVideo:7
The profile provides hints to the driver to optimize for High Dynamic Range (HDR) with Wide Color Gamut (WCG) video.

### -field HdrWithWcgPhoto:8
The profile provides hints to the driver to optimize for High Dynamic Range (HDR) with Wide Color Gamut (WCG) photo.

### -field VideoHdr8:9
The profile provides hints to the driver to optimize for High Dynamic Range (HDR) video.

### -field CompressedCamera:10
The profile enables the enumeration of compressed video streams.

## -remarks
Use [FindKnownVideoProfiles](mediacapture_findknownvideoprofiles_875917242.md) to retrieve the list of known profiles that are supported for a specified video device.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | HdrWithWcgPhoto |
| 1803 | 17134 | HdrWithWcgVideo |
| 1803 | 17134 | HighFrameRate |
| 1803 | 17134 | VariablePhotoSequence |
| 1803 | 17134 | VideoHdr8 |

## -examples

## -see-also
[FindKnownVideoProfiles](mediacapture_findknownvideoprofiles_875917242.md)
