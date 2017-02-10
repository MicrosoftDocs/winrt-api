---
-api-id: M:Windows.Media.Audio.AudioFrameInputNode.AddFrame(Windows.Media.AudioFrame)
-api-type: winrt method
---

<!-- Method syntax
public void AddFrame(Windows.Media.AudioFrame frame)
-->

# Windows.Media.Audio.AudioFrameInputNode.AddFrame

## -description
Adds an audio frame to the audio frame input node.

## -parameters
### -param frame
An [AudioFrame](../windows.media/audioframe.md) object representing the frame.

## -remarks
The provided [AudioFrame](../windows.media/audioframe.md) object must have an underlying [AudioBuffer](../windows.media/audiobuffer.md) with a [Length](../windows.media/audiobuffer_length.md) greater than 0 or an E_INVALIDARG error will result. Also, the underlying [IMemoryBuffer](../windows.foundation/imemorybuffer.md) containing the raw audio data must be block-aligned based on the bit depth per sample and number of channels. This means that the size of the buffer, in bytes, must be an integral multiple of ([BitsPerSample](../windows.media.mediaproperties/audioencodingproperties_bitspersample.md) / 8) * [ChannelCount](../windows.media.mediaproperties/audioencodingproperties_channelcount.md) of the [EncodingProperties](audioframeinputnode_encodingproperties.md) property for the node. Attempting to add a frame with a non-aligned audio buffer will result in an E_INVALIDARG error.

A maximum of 64 frames can be queued in the [AudioFrameInputNode](audioframeinputnode.md) at one time. Attempting to queue more than 64 frames will result in an error.

## -examples

## -see-also
