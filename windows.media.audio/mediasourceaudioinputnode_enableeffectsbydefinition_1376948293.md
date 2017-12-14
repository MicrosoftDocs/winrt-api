---
-api-id: M:Windows.Media.Audio.MediaSourceAudioInputNode.EnableEffectsByDefinition(Windows.Media.Effects.IAudioEffectDefinition)
-api-type: winrt method
---

<!-- Method syntax.
public void MediaSourceAudioInputNode.EnableEffectsByDefinition(IAudioEffectDefinition definition)
-->

# Windows.Media.Audio.MediaSourceAudioInputNode.EnableEffectsByDefinition

## -description
Enables all effects in the [EffectDefinitions](mediasourceaudioinputnode_effectdefinitions.md) list with the specified effect definition.

## -parameters

### -param definition
The effect definition of the effects to enable.

## -remarks
Apply an audio effect to a node by adding an object that implements [IAudioEffectDefinition](../windows.media.effects/iaudioeffectdefinition.md) to the [EffectDefinitions](mediasourceaudioinputnode_effectdefinitions.md) collection. Disable effects by calling [DisableEffectsByDefinition](mediasourceaudioinputnode_disableeffectsbydefinition_730128310.md).

## -see-also

## -examples

