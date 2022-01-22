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

The command must be declared in a Voice Command Definition (VCD) file registered by the app referred to in the command. See [Launch a background app with voice commands](/windows/apps/design/input/cortana-launch-a-background-app-with-voice-commands) for more info on creating and registering a Voice Command Definition (VCD) file for your app.

## -remarks
Access VoiceCommand objects by calling [GetVoiceCommandAsync](voicecommandserviceconnection_getvoicecommandasync_1073619361.md) on a [VoiceCommandServiceConnection](voicecommandserviceconnection.md) that references the appropriate [Windows.ApplicationModel.AppService](../windows.applicationmodel.appservice/windows_applicationmodel_appservice.md) object.

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
