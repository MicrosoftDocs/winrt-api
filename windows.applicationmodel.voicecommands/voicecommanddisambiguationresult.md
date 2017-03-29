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

Calling [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync.md) from the background app service causes **Cortana** to display the disambiguation screen.

## -remarks
Access [VoiceCommandDisambiguationResult](voicecommand.md) objects by calling [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync.md) on a [VoiceCommandServiceConnection](voicecommandserviceconnection.md) that references the appropriate [Windows.ApplicationModel.AppService](../windows.applicationmodel.appservice/windows_applicationmodel_appservice.md) object.

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ elements and attributes v1.2](https://docs.microsoft.com/en-us/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md), [Cortana interactions](http://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](http://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](http://go.microsoft.com/fwlink/p/?LinkID=619899)