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
[ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-interactions), [Cortana design guidelines](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-design-guidelines), [Cortana voice command sample](https://go.microsoft.com/fwlink/p/?LinkID=619899)
