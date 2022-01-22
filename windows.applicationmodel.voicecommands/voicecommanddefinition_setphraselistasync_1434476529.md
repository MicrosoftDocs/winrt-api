---
-api-id: M:Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition.SetPhraseListAsync(System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetPhraseListAsync(System.String phraseListName, Windows.Foundation.Collections.IIterable<System.String> phraseList)
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition.SetPhraseListAsync

## -description
Populates a `PhraseList` element with an array of `Item` elements.

## -parameters
### -param phraseListName
The string that corresponds to the label attribute of the `PhraseList` element.

### -param phraseList
A string array of values that will be added to the `PhraseList` element as `Item` elements.

## -returns
A string array of values that will be added to the [PhraseList](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) element as [Item](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) elements.

## -remarks

## -examples

## -see-also
[Voice Command Definition (VCD) elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
