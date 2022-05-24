---
-api-id: P:Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager.InstalledCommandDefinitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition> InstalledCommandDefinitions { get; }
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager.InstalledCommandDefinitions

## -description
A dictionary that contains all installed command sets that have a [Name](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) attribute set in the Voice Command Definition (VCD) file.

> [!NOTE]
> Opening an app service connection can be resource intensive. Avoid accessing this property during time-sensitive operations, especially from the UI thread or when [Suspending](../windows.ui.xaml/application_suspending.md).

## -property-value
The dictionary of installed command sets that have a Name attribute set in the Voice Command Definition (VCD) file.

## -remarks

## -examples

## -see-also
[Voice Command Definition (VCD) elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
