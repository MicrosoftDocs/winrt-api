---
-api-id: M:Windows.ApplicationModel.VoiceCommands.VoiceCommandServiceConnection.RequestDisambiguationAsync(Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.VoiceCommands.VoiceCommandDisambiguationResult> RequestDisambiguationAsync(Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse response)
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandServiceConnection.RequestDisambiguationAsync

## -description
Sends a response to **Cortana** indicating the voice command returned more than one result and requires the user to select one.

## -parameters
### -param response
The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.

## -returns
The [VoiceCommandDisambiguationResult](voicecommanddisambiguationresult.md) object with the user's response.

## -remarks

## -examples

## -see-also
[ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
