---
-api-id: M:Windows.Media.SpeechRecognition.VoiceCommandSet.SetPhraseListAsync(System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetPhraseListAsync(System.String phraseListName, Windows.Foundation.Collections.IIterable<System.String> phraseList)
-->

# Windows.Media.SpeechRecognition.VoiceCommandSet.SetPhraseListAsync

## -description
Populates a [PhraseList](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md) element with an array of [Item](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md) elements.

## -parameters
### -param phraseListName
The string that corresponds to the label attribute of the [PhraseList](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md) element.

### -param phraseList
A string array of values that will be added to the [PhraseList](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md) element as [Item](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md) elements.

## -returns
An asynchronous action.

## -remarks

## -examples

## -see-also
[ elements and attributes](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)