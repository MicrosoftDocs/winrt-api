---
-api-id: M:Windows.Media.SpeechRecognition.VoiceCommandManager.InstallCommandSetsFromStorageFileAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction InstallCommandSetsFromStorageFileAsync(Windows.Storage.StorageFile file)
-->

# Windows.Media.SpeechRecognition.VoiceCommandManager.InstallCommandSetsFromStorageFileAsync

## -description
Installs the [CommandSet](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md) elements in a [](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md) file.

## -parameters
### -param file
An object representing a Voice Command Definition (VCD) file.

## -returns
An asynchronous action.

## -remarks
Awaiting this call on the UI thread can delay loading of your app.

## -examples

## -see-also
[ elements and attributes](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md), [Speech interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/speech-interactions), [Speech design guidelines](https://docs.microsoft.com/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
