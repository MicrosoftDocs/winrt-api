---
-api-id: M:Windows.Media.SpeechRecognition.VoiceCommandManager.InstallCommandSetsFromStorageFileAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction InstallCommandSetsFromStorageFileAsync(Windows.Storage.StorageFile file)
-->

# Windows.Media.SpeechRecognition.VoiceCommandManager.InstallCommandSetsFromStorageFileAsync

## -description
Installs the [CommandSet](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) elements in a [Voice Command Definition](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) file.

## -parameters
### -param file
An object representing a Voice Command Definition (VCD) file.

## -returns
An asynchronous action.

## -remarks
Awaiting this call on the UI thread can delay loading of your app.

## -examples

## -see-also
[ elements and attributes](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
