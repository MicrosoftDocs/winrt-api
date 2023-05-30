---
-api-id: M:Windows.Media.Audio.AudioEffectsPackConfiguration.GetForDeviceId(System.String,System.String)
-api-type: winrt method
---

# Windows.Media.Audio.AudioEffectsPackConfiguration.GetForDeviceId(System.String,System.String)

<!--
public static Windows.Media.Audio.AudioEffectsPackConfiguration GetForDeviceId (string effectsPackId, string deviceId);
-->


## -description

Gets an instance of the [AudioEffectsPackConfiguration](xref:Windows.Media.Audio.AudioEffectsPackConfiguration) class for the specified audio effects pack and audio endpoint.

## -parameters

### -param effectsPackId

The OEM-specified audio effects pack ID associated with the new **AudioEffectsPackConfiguration** object.

### -param deviceId

The device ID associated with the new **AudioEffectsPackConfiguration** object. 

## -returns

A new instance of [AudioEffectsPackConfiguration](xref:Windows.Media.Audio.AudioEffectsPackConfiguration).

## -remarks

A given **AudioEffectsPackConfiguration** object represents a single effects pack on a single endpoint. Applications must create an **AudioEffectsPackConfiguration** instance for each effects pack, audio endpoint pair they want to query.

## -see-also

## -examples


