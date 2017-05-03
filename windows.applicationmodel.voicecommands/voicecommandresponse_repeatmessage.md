---
-api-id: P:Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse.RepeatMessage
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.VoiceCommands.VoiceCommandUserMessage RepeatMessage { get;  set; }
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse.RepeatMessage

## -description
The secondary message (for disambiguation and confirmation screens only) that is spoken by **Cortana** and shown on the **Cortana** canvas, if a response was not understood.


This message should be both a variation of the first message and one of the following:

+ An unambiguous question that can be answered with either yes or no on confirmation screens (see [RequestConfirmationAsync](voicecommandserviceconnection_requestconfirmationasync.md)).
+ A request for the user to select from the list of choices presented on disambiguation screens (see [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync.md)).


## -property-value
The message that is spoken or shown by **Cortana**.

## -remarks

## -examples

## -see-also
[VoiceCommandContentTiles](voicecommandresponse_voicecommandcontenttiles.md), [Message](voicecommandresponse_message.md), [ elements and attributes v1.2](https://docs.microsoft.com/en-us/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md), [Cortana interactions](http://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](http://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](http://go.microsoft.com/fwlink/p/?LinkID=619899)