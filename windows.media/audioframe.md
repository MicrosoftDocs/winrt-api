---
-api-id: T:Windows.Media.AudioFrame
-api-type: winrt class
---

<!-- Class syntax.
public class AudioFrame : Windows.Foundation.IClosable, Windows.Media.IAudioFrame, Windows.Media.IMediaFrame
-->

# Windows.Media.AudioFrame

## -description
Represents a single frame of audio data.

## -remarks
An audio frame typically contains multiple audio samples. Access the audio data by calling [LockBuffer](audioframe_lockbuffer.md) which returns an [AudioBuffer](audiobuffer.md).

## -examples

## -see-also
[IMediaFrame](imediaframe.md), [IClosable](../windows.foundation/iclosable.md), [AudioBuffer](audiobuffer.md)