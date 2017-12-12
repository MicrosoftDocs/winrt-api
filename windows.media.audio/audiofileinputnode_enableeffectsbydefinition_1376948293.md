---
-api-id: M:Windows.Media.Audio.AudioFileInputNode.EnableEffectsByDefinition(Windows.Media.Effects.IAudioEffectDefinition)
-api-type: winrt method
---

<!-- Method syntax
public void EnableEffectsByDefinition(Windows.Media.Effects.IAudioEffectDefinition definition)
-->

# Windows.Media.Audio.AudioFileInputNode.EnableEffectsByDefinition

## -description
Enables all effects in the [EffectDefinitions](audiofileinputnode_effectdefinitions.md) list with the specified effect definition.

## -parameters
### -param definition
The effect definition of the effects to enable.

## -remarks
Apply an audio effect to a node by adding an object that implements [IAudioEffectDefinition](../windows.media.effects/iaudioeffectdefinition.md) to the [EffectDefinitions](audiofileinputnode_effectdefinitions.md) collection. Disable effects by calling [DisableEffectsByDefinition](audiofileinputnode_disableeffectsbydefinition_730128310.md).

## -examples

## -see-also
