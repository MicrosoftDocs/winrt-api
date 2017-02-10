---
-api-id: M:Windows.Media.SpeechRecognition.VoiceCommandManager.InstallCommandSetsFromStorageFileAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction InstallCommandSetsFromStorageFileAsync(Windows.Storage.StorageFile file)
-->

# Windows.Media.SpeechRecognition.VoiceCommandManager.InstallCommandSetsFromStorageFileAsync

## -description
Installs the [CommandSet](voice_command_elements_and_attributes.md) elements in a [](voice_command_elements_and_attributes.md) file.

## -parameters
### -param file
An object representing a Voice Command Definition (VCD) file.

## -returns
An asynchronous action.

## -remarks
Awaiting this call on the UI thread can delay loading of your app.

## -examples

## -see-also
[ elements and attributes](voice_command_elements_and_attributes.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)