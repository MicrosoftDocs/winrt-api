---
-api-id: M:Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager.InstallCommandDefinitionsFromStorageFileAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction InstallCommandDefinitionsFromStorageFileAsync(Windows.Storage.StorageFile file)
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager.InstallCommandDefinitionsFromStorageFileAsync

## -description
Installs the [CommandSet](../windows.media.speechrecognition/voice_command_elements_and_attributes.md) elements in a Voice Command Definition (VCD) file.

## -parameters
### -param file
An object representing a Voice Command Definition (VCD) file.

## -returns
An asynchronous handler called when the operation is complete.

## -remarks
Call this method only from your [OnLaunched](../windows.ui.xaml/application_onlaunched_859642554.md) override, or a [Resuming](../windows.applicationmodel.core/coreapplication_resuming.md) event handler.

Do not call this method from a [Suspending](../windows.applicationmodel.core/coreapplication_suspending.md) event handler as the action might take longer than the time allotted by the system for app suspension.

## -examples

## -see-also
[ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](http://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](http://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](http://go.microsoft.com/fwlink/p/?LinkID=619899)