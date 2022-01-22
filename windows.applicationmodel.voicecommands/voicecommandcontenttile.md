---
-api-id: T:Windows.ApplicationModel.VoiceCommands.VoiceCommandContentTile
-api-type: winrt class
---

<!-- Class syntax.
public class VoiceCommandContentTile : Windows.ApplicationModel.VoiceCommands.IVoiceCommandContentTile
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandContentTile

## -description
An asset, containing image, text, and link data, provided by the background app service for display on the **Cortana** canvas.

## -remarks
[MaxSupportedVoiceCommandContentTiles](voicecommandresponse_maxsupportedvoicecommandcontenttiles.md) specifies the maximum number of tiles the background app service can display on the **Cortana** canvas.

The maximum number of tiles that can be displayed depends on the feedback screen being shown. One item when the [VoiceCommandResponse](voicecommandresponse.md) is created for [ReportProgressAsync](voicecommandserviceconnection_reportprogressasync_197749011.md) or [RequestConfirmationAsync](voicecommandserviceconnection_requestconfirmationasync_1656186355.md), and more than one item when the [VoiceCommandResponse](voicecommandresponse.md) is created for [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync_117243970.md).

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
