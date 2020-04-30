---
-api-id: P:Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse.MaxSupportedVoiceCommandContentTiles
-api-type: winrt property
---

<!-- Property syntax
public uint MaxSupportedVoiceCommandContentTiles { get; }
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse.MaxSupportedVoiceCommandContentTiles

## -description
Gets the maximum number of content tiles the background app service can display on the **Cortana** canvas.

## -property-value
The maximum number of content tiles.

## -remarks
The maximum number of tiles that can be displayed depends on the feedback screen being shown. One item when the [VoiceCommandResponse](voicecommandresponse.md) is created for [ReportProgressAsync](voicecommandserviceconnection_reportprogressasync_197749011.md) or [RequestConfirmationAsync](voicecommandserviceconnection_requestconfirmationasync_1656186355.md), and more than one item when the [VoiceCommandResponse](voicecommandresponse.md) is created for [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync_117243970.md).

## -examples

## -see-also
[ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-interactions), [Cortana design guidelines](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
