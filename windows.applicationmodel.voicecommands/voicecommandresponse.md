---
-api-id: T:Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse
-api-type: winrt class
---

<!-- Class syntax.
public class VoiceCommandResponse : Windows.ApplicationModel.VoiceCommands.IVoiceCommandResponse
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse

## -description
The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.

## -remarks
The background app service cannot use the VoiceCommandResponse object to display anything on the **Cortana** canvas unless the app has access to a [VoiceCommandServiceConnection](voicecommandserviceconnection.md) object. A [VoiceCommandServiceConnection](voicecommandserviceconnection.md) object is created only when the background app service is invoked from **Cortana**.

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-interactions), [Cortana design guidelines](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
