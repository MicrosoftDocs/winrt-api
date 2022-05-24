---
-api-id: T:Windows.ApplicationModel.VoiceCommands.VoiceCommandDisambiguationResult
-api-type: winrt class
---

<!-- Class syntax.
public class VoiceCommandDisambiguationResult : Windows.ApplicationModel.VoiceCommands.IVoiceCommandDisambiguationResult
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandDisambiguationResult

## -description
The result obtained from the disambiguation screen displayed on the **Cortana** canvas.

Calling [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync_117243970.md) from the background app service causes **Cortana** to display the disambiguation screen.

## -remarks
Access [VoiceCommandDisambiguationResult](voicecommand.md) objects by calling [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync_117243970.md) on a [VoiceCommandServiceConnection](voicecommandserviceconnection.md) that references the appropriate [Windows.ApplicationModel.AppService](../windows.applicationmodel.appservice/windows_applicationmodel_appservice.md) object.

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
