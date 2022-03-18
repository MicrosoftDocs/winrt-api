---
-api-id: P:Windows.Media.Audio.AudioDeviceInputNode.EffectDefinitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Media.Effects.IAudioEffectDefinition> EffectDefinitions { get; }
-->

# Windows.Media.Audio.AudioDeviceInputNode.EffectDefinitions

## -description
Gets the list of effect definitions for the audio device input node. The effects in the list process audio data that flows through the node in the order in which they appear in the list.

## -property-value
The list of effect definitions for the node.

## -remarks
To add an audio effect to the node, add an object that implements [IAudioEffectDefinition](../windows.media.effects/iaudioeffectdefinition.md) to the **EffectDefinitions** property. You can disable effects by passing a previously added effect definition to the [DisableEffectsByDefinition](audiodeviceinputnode_disableeffectsbydefinition_730128310.md) method. Reenable a disabled effect by passing the definition to [EnableEffectsByDefinition](audiodeviceinputnode_enableeffectsbydefinition_1376948293.md).

Several platform-provided effects can be found in the **Windows.Media.Audio** namespace. These include:
* [EchoEffectDefinition](echoeffectdefinition.md)
* [EqualizerEffectDefinition](equalizereffectdefinition.md)
* [LimiterEffectDefinition](limitereffectdefinition.md)
* [ReverbEffectDefinition](reverbeffectdefinition.md)

Also, you can create your own custom audio effects by creating a Windows Runtime component that implements the [IBasicAudioEffect](../windows.media.effects/ibasicaudioeffect.md) interface. For a walkthrough of creating a custom audio effect, see [Custom audio effects](/windows/uwp/audio-video-camera/custom-audio-effects).


## -see-also

[Custom audio effects](/windows/uwp/audio-video-camera/custom-audio-effects), [IAudioEffectDefinition](../windows.media.effects/iaudioeffectdefinition.md), [EchoEffectDefinition](echoeffectdefinition.md), [EqualizerEffectDefinition](equalizereffectdefinition.md), [LimiterEffectDefinition](limitereffectdefinition.md), [ReverbEffectDefinition](reverbeffectdefinition.md), [IBasicAudioEffect](../windows.media.effects/ibasicaudioeffect.md)
