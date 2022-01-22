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

+ An unambiguous question that can be answered with either yes or no on confirmation screens (see [RequestConfirmationAsync](voicecommandserviceconnection_requestconfirmationasync_1656186355.md)).
+ A request for the user to select from the list of choices presented on disambiguation screens (see [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync_117243970.md)).


## -property-value
The message that is spoken or shown by **Cortana**.

## -remarks

## -examples

## -see-also
[VoiceCommandContentTiles](voicecommandresponse_voicecommandcontenttiles.md), [Message](voicecommandresponse_message.md), [ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
