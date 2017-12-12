---
-api-id: M:Windows.Media.Audio.MediaSourceAudioInputNode.DisableEffectsByDefinition(Windows.Media.Effects.IAudioEffectDefinition)
-api-type: winrt method
---

<!-- Method syntax.
public void MediaSourceAudioInputNode.DisableEffectsByDefinition(IAudioEffectDefinition definition)
-->

# Windows.Media.Audio.MediaSourceAudioInputNode.DisableEffectsByDefinition

## -description
Disables all effects in the [EffectDefinitions](mediasourceaudioinputnode_effectdefinitions.md) list with the specified effect definition.

## -parameters
### -param definition
The effect definition of the effects to disable.

## -remarks
Apply an audio effect to a node by adding an object that implements [IAudioEffectDefinition](../windows.media.effects/iaudioeffectdefinition.md) to the [EffectDefinitions](mediasourceaudioinputnode_effectdefinitions.md) collection. Reenable disabled effects by calling [EnableEffectsByDefinition](mediasourceaudioinputnode_enableeffectsbydefinition_1376948293.md).

## -see-also

## -examples




