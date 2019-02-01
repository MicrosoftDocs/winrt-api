---
-api-id: M:Windows.ApplicationModel.VoiceCommands.VoiceCommandServiceConnection.ReportProgressAsync(Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ReportProgressAsync(Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse response)
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandServiceConnection.ReportProgressAsync

## -description
Sends a response to **Cortana** indicating voice command is being processed.

## -parameters
### -param response
The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.

## -returns
An asynchronous handler called when the operation is complete.

## -remarks
**Cortana** presents the progress screen to the user for up to 5 seconds. The background app service send another progress message by calling [ReportProgressAsync](voicecommandserviceconnection_reportprogressasync_197749011.md) again, or move to the next screen in the interaction flow (confirmation, disambiguation, or completion).

## -examples

## -see-also
[ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](https://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](https://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](https://go.microsoft.com/fwlink/p/?LinkID=619899)
