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
The profile provides hints to the driver to optimize for VoIP scenarios, prioritizing lower power consumption, lower latency, and concurrency (e.g. using the front and back cameras of a device simultaneously) while deprioritizing higher resolution.

### -field PhotoSequence:4
The profile provides hints to the driver to optimize for capturing photo sequences.


## -remarks
Use [FindKnownVideoProfiles](mediacapture_findknownvideoprofiles.md) to retrieve the list of known profiles that are supported for a specified video device.

## -examples

## -see-also
[FindKnownVideoProfiles](mediacapture_findknownvideoprofiles.md)