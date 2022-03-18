---
-api-id: P:Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.AppendedSilence
-api-type: winrt property
---

<!-- Property syntax.
public SpeechAppendedSilence AppendedSilence { get;  set; }
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.AppendedSilence

## -description
Gets or sets the amount of silence added to the end of the speech synthesis utterance (before another utterance begins).

## -property-value
The [SpeechAppendedSilence](speechappendedsilence.md) duration.

## -remarks
By default, approximately 750ms of silence is appended to the end of each generated utterance. If the utterance is not a complete sentence, this can complicate concatenation of multiple utterances. For example, a streaming app that reads text from a document as it downloads, might start reading from its cache at a predetermined number of words. 

## -see-also
[PunctuationSilence](speechsynthesizeroptions_punctuationsilence.md), [SpeakingRate](speechsynthesizeroptions_speakingrate.md), [Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)

## -examples

