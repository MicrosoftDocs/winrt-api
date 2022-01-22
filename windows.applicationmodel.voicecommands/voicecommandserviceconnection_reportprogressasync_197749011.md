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
**Cortana** presents the progress screen to the user for up to 5 seconds. The background app service send another progress message by calling ReportProgressAsync again, or move to the next screen in the interaction flow (confirmation, disambiguation, or completion).

## -examples

## -see-also
[ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
