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

The [Position](speechsynthesisstream_position.md) (0), [Seek](speechsynthesisstream_seek.md) pointer, and lifetime of this new stream are independent from those of the original stream.

## -remarks

## -examples

## -see-also
[Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)