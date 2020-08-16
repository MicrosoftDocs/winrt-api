---
-api-id: M:Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse.CreateResponse(Windows.ApplicationModel.VoiceCommands.VoiceCommandUserMessage)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse CreateResponse(Windows.ApplicationModel.VoiceCommands.VoiceCommandUserMessage userMessage)
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse.CreateResponse

## -description
Creates a [VoiceCommandResponse](voicecommandresponse.md) object used in calls to [ReportProgressAsync](voicecommandserviceconnection_reportprogressasync_197749011.md), [ReportSuccessAsync](voicecommandserviceconnection_reportsuccessasync_2126991650.md) or [ReportFailureAsync](voicecommandserviceconnection_reportfailureasync_1581497711.md).

## -parameters
### -param userMessage
The message that is spoken by **Cortana** and shown on the **Cortana** canvas. 
This message should be:

+ An informative statement on progress, completion, and error screens (see [ReportProgressAsync](voicecommandserviceconnection_reportprogressasync_197749011.md), [ReportSuccessAsync](voicecommandserviceconnection_reportsuccessasync_2126991650.md), [ReportFailureAsync](voicecommandserviceconnection_reportfailureasync_1581497711.md)).
+ An unambiguous question that can be answered with either yes or no on confirmation screens (see [RequestConfirmationAsync](voicecommandserviceconnection_requestconfirmationasync_1656186355.md)).
+ A request for the user to select from the list of choices presented on disambiguation screens (see [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync_117243970.md)).


## -returns
The response from the background app service for progress, completion, confirmation, or disambiguation screens displayed on the **Cortana** canvas.

## -remarks

## -examples

## -see-also
[CreateResponse(VoiceCommandUserMessage, IIterable(VoiceCommandContentTile))](voicecommandresponse_createresponse_493218068.md), [ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-interactions), [Cortana design guidelines](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
