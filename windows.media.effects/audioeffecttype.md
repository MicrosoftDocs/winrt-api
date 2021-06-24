---
-api-id: T:Windows.Media.Effects.AudioEffectType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Effects.AudioEffectType : int
-->

# AudioEffectType

## -description
Defines values for audio effect types.

## -enum-fields
### -field Other:0
Other.

### -field AcousticEchoCancellation:1
An acoustic echo cancellation effect.

### -field NoiseSuppression:2
A noise suppression effect.

### -field AutomaticGainControl:3
A automatic gain control effect.

### -field BeamForming:4
A beam forming effect.

### -field ConstantToneRemoval:5
A constant tone removal effect.

### -field Equalizer:6
A equalizer effect.

### -field LoudnessEqualizer:7
A loudness equalizer effect.

### -field BassBoost:8
A bass boost effect.

### -field VirtualSurround:9
A virtual surround sound effect.

### -field VirtualHeadphones:10
A virtual headphones effect.

### -field SpeakerFill:11
A speaker fill effect.

### -field RoomCorrection:12
A room correction effect.

### -field BassManagement:13
A bass management effect.

### -field EnvironmentalEffects:14
An environmental effect.

### -field SpeakerProtection:15
A speaker protection effect.

### -field SpeakerCompensation:16
A speaker compensation effect.

### -field DynamicRangeCompression:17
A dynamic range compression effect.

### -field FarFieldBeamForming:18
A far-field beam forming effect.

### -field DeepNoiseSuppression: 19
A noise suppression effect. This type differs from **NoiseSuppression** in that it is a more advanced AI / machine learning based noise suppression effect.

## -remarks
See the [Audio effects discovery sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Audio%20effects%20discovery%20sample) for an example of how to query and monitor audio effects on render and capture audio devices.

## -examples

## -see-also
[Audio effects discovery sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Audio%20effects%20discovery%20sample)
