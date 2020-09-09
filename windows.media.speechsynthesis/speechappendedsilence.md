---
-api-id: T:Windows.Media.SpeechSynthesis.SpeechAppendedSilence
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum SpeechAppendedSilence : int 
-->

# Windows.Media.SpeechSynthesis.SpeechAppendedSilence

## -description
Specifies the amount of silence added to the end of the speech synthesis utterance (before another utterance begins).

## -enum-fields
### -field Min:1
The minimum amount of silence defined by the speech synthesis voice.

### -field Default:0
The default amount of silence defined by the speech synthesis voice.

## -remarks
By default, approximately 750ms of silence is appended to the end of each generated utterance. If the utterance is not a complete sentence, this can complicate concatenation of multiple utterances. For example, a streaming app that reads text from a document as it downloads, might start reading from its cache at a predetermined number of words. 

## -see-also
[SpeechSynthesizerOptions.AppendedSilence](speechsynthesizeroptions_appendedsilence.md), [SpeakingRate](speechsynthesizeroptions_speakingrate.md), [Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)

## -examples

