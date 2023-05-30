---
-api-id: T:Windows.Media.Audio.AudioEffectsPackConfiguration
-api-type: winrt class
---

# Windows.Media.Audio.AudioEffectsPackConfiguration

<!--
public sealed class AudioEffectsPackConfiguration
-->


## -description

Represents a single effects pack on a single audio endpoint.

## -remarks

This class can be used by OEM Hardware Support Application (HSA) applications to query for their effects pack’s status on a given audio endpoint. Using this class, OEM's can only query for the status of their own effects packs, specified with an OEM-defined ID. The API does not allow for the setting of effects packs.

Get an instance of this class by calling [AudioEffectsPackConfiguration.GetForEffectsPackOnDeviceId](xref:Windows.Media.Audio.AudioEffectsPackConfiguration.GetForEffectsPackOnDeviceId(System.String,System.String)).

A given **AudioEffectsPackConfiguration** object represents a single effects pack on a single endpoint. Applications must create an **AudioEffectsPackConfiguration** instance for each effects pack, audio endpoint pair they want to query.



## -see-also

## -examples


