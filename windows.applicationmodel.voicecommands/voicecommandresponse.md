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
The background app service cannot use the [VoiceCommandResponse](voicecommandresponse.md) object to display anything on the **Cortana** canvas unless the app has access to a [VoiceCommandServiceConnection](voicecommandserviceconnection.md) object. A [VoiceCommandServiceConnection](voicecommandserviceconnection.md) object is created only when the background app service is invoked from **Cortana**.

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](http://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](http://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](http://go.microsoft.com/fwlink/p/?LinkID=619899)