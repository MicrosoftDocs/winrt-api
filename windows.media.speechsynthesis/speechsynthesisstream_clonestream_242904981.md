---
-api-id: M:Windows.Media.SpeechSynthesis.SpeechSynthesisStream.CloneStream
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IRandomAccessStream CloneStream()
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesisStream.CloneStream

## -description
Creates a copy of [SpeechSynthesisStream](speechsynthesisstream.md) that references the same bytes as the original stream.

## -returns
The new stream.

The [Position](speechsynthesisstream_position.md) (0), [Seek](speechsynthesisstream_seek_1797934981.md) pointer, and lifetime of this new stream are independent from those of the original stream.

## -remarks

## -examples

## -see-also
[Speech interactions](https://docs.microsoft.com/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
