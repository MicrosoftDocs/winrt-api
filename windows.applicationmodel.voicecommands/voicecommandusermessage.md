---
-api-id: T:Windows.ApplicationModel.VoiceCommands.VoiceCommandUserMessage
-api-type: winrt class
---

<!-- Class syntax.
public class VoiceCommandUserMessage : Windows.ApplicationModel.VoiceCommands.IVoiceCommandUserMessage
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandUserMessage

## -description
The message that is spoken by **Cortana** and shown on the **Cortana** canvas.


This message should be:

+ An informative statement on progress, completion, and error screens (see [ReportProgressAsync](voicecommandserviceconnection_reportprogressasync.md), [ReportSuccessAsync](voicecommandserviceconnection_reportsuccessasync.md), [ReportFailureAsync](voicecommandserviceconnection_reportfailureasync.md)).
+ An unambiguous question that can be answered with either yes or no on confirmation screens (see [RequestConfirmationAsync](voicecommandserviceconnection_requestconfirmationasync.md)).
+ A request for the user to select from the list of choices presented on disambiguation screens (see [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync.md)).


## -remarks

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ elements and attributes v1.2](https://docs.microsoft.com/en-us/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](http://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](http://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](http://go.microsoft.com/fwlink/p/?LinkID=619899)