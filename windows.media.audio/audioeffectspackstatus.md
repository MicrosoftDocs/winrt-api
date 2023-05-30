---
-api-id: T:Windows.Media.Audio.AudioEffectsPackStatus
-api-type: winrt enum
---

# Windows.Media.Audio.AudioEffectsPackStatus

<!--
public enum AudioEffectsPackStatus
-->


## -description

Specifies the supported and enabled status of an audio effects pack and audio endpoint represented by an [AudioEffectsPackConfiguration](xref:Windows.Media.Audio.AudioEffectsPackConfiguration) object.

## -enum-fields

### -field NotEnabled: 0

The audio effects pack is supported, but not enabled for the associated audio endpoint.

### -field Enabled: 1

The audio effects pack is supported and enabled for the associated audio endpoint.

### -field NotSupported: 2

The audio effects pack is not supported for the associated audio endpoint.

## -remarks

This enumeration is used by the [AudioEffectsPackConfiguration.Status](xref:Windows.Media.Audio.AudioEffectsPackConfiguration.Status) property.

## -see-also

## -examples


