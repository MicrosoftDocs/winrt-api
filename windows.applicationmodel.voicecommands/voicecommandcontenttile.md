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

The maximum number of tiles that can be displayed depends on the feedback screen being shown. One item when the [VoiceCommandResponse](voicecommandresponse.md) is created for [ReportProgressAsync](voicecommandserviceconnection_reportprogressasync.md) or [RequestConfirmationAsync](voicecommandserviceconnection_requestconfirmationasync.md), and more than one item when the [VoiceCommandResponse](voicecommandresponse.md) is created for [RequestDisambiguationAsync](voicecommandserviceconnection_requestdisambiguationasync.md).

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ elements and attributes v1.2](https://docs.microsoft.com/en-us/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](http://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](http://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](http://go.microsoft.com/fwlink/p/?LinkID=619899)