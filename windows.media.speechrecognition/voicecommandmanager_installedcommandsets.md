---
-api-id: P:Windows.Media.SpeechRecognition.VoiceCommandManager.InstalledCommandSets
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, Windows.Media.SpeechRecognition.VoiceCommandSet> InstalledCommandSets { get; }
-->

# Windows.Media.SpeechRecognition.VoiceCommandManager.InstalledCommandSets

## -description
A dictionary that contains all installed command sets that have a [Name](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) attribute set in the [Voice Command Definition](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) file.

## -property-value
The dictionary of installed command sets that have a Name attribute set in the Voice Command Definition (VCD) file.

## -remarks
Avoid calling this property from the UI thread. Opening an app service connection can be resource intensive.

## -examples

## -see-also
[ elements and attributes](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
