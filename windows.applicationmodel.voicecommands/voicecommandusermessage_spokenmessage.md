---
-api-id: P:Windows.ApplicationModel.VoiceCommands.VoiceCommandUserMessage.SpokenMessage
-api-type: winrt property
---

<!-- Property syntax
public string SpokenMessage { get;  set; }
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandUserMessage.SpokenMessage

## -description
The message that is spoken by **Cortana**.

## -property-value

+ An informative statement on progress, completion, and error screens (see [ReportProgressAsync](voicecommandserviceconnection_reportprogressasync_197749011.md), [ReportSuccessAsync](voicecommandserviceconnection_reportsuccessasync_2126991650.md), [ReportFailureAsync](voicecommandserviceconnection_reportfailureasync_1581497711.md)).
+ An unambiguous question that can be answered with either yes or no on confirmation screens (see [RequestConfirmationAsync](voicecommandserviceconnection_requestconfirmationasync_1656186355.md)).
+ A request for the user to select from the list of choices presented on disambiguation screens (see [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync_117243970.md)).


## -remarks

## -examples

## -see-also
[ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
