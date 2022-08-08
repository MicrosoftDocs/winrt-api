---
-api-id: M:Windows.Media.SpeechRecognition.VoiceCommandSet.SetPhraseListAsync(System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetPhraseListAsync(System.String phraseListName, Windows.Foundation.Collections.IIterable<System.String> phraseList)
-->

# Windows.Media.SpeechRecognition.VoiceCommandSet.SetPhraseListAsync

## -description
Populates a [PhraseList](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) element with an array of [Item](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) elements.

## -parameters
### -param phraseListName
The string that corresponds to the label attribute of the [PhraseList](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) element.

### -param phraseList
A string array of values that will be added to the [PhraseList](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) element as [Item](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) elements.

## -returns
An asynchronous action.

## -remarks

## -examples

## -see-also
[ elements and attributes](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
