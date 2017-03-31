---
-api-id: T:Windows.ApplicationModel.VoiceCommands.VoiceCommand
-api-type: winrt class
keywords: Cortana, voice command, VCD
---

<!-- Class syntax.
public class VoiceCommand : Windows.ApplicationModel.VoiceCommands.IVoiceCommand
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommand

## -description
The command given to **Cortana**, using either speech or text, and routed to a background app.

The command must be declared in a Voice Command Definition (VCD) file registered by the app referred to in the command. See [Launch a background app with voice commands in Cortana ](http://msdn.microsoft.com/library/df5b530c-57dd-4ca5-b3be-1a0b3695c9c6) for more info on creating and registering a Voice Command Definition (VCD) file for your app.

## -remarks
Access [VoiceCommand](voicecommand.md) objects by calling [GetVoiceCommandAsync](voicecommandserviceconnection_getvoicecommandasync.md) on a [VoiceCommandServiceConnection](voicecommandserviceconnection.md) that references the appropriate [Windows.ApplicationModel.AppService](../windows.applicationmodel.appservice/windows_applicationmodel_appservice.md) object.

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ elements and attributes v1.2](https://docs.microsoft.com/en-us/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md), [Cortana interactions](http://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](http://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](http://go.microsoft.com/fwlink/p/?LinkID=619899)