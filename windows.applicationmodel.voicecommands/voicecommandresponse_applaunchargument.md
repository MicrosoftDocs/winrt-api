---
-api-id: P:Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse.AppLaunchArgument
-api-type: winrt property
---

<!-- Property syntax
public string AppLaunchArgument { get;  set; }
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse.AppLaunchArgument

## -description
Gets or sets a string as a launch parameter that can be associated with the response by the background app service.

[AppLaunchArgument](voicecommandresponse_applaunchargument.md) is used to specify the state or context of the foreground app when launched through a deep link in **Cortana**.

## -property-value
The string used as a launch parameter.

## -remarks
To enable deep linking to an app, declare the `windows.personalAssistantLaunch` extension in the Package.appxmanifest file of the app project.

An app is launched to the foreground through Uniform Resource Identifier (URI) activation using a [Protocol](../windows.applicationmodel.activation/activationkind.md) contract. The app must override the [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) event and check for an [ActivationKind](../windows.applicationmodel.activation/activationkind.md) of [Protocol](../windows.applicationmodel.activation/activationkind.md). See [Handle URI activation](https://msdn.microsoft.com/library/92d06f3e-c8f3-42e0-a476-7e94fd14b2be) for more info.

## -examples

## -see-also
[Deep link from Cortana to a background app](https://msdn.microsoft.com/library/be811a87-8821-476a-90e4-2e20d37e4043), [ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](https://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](https://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](https://go.microsoft.com/fwlink/p/?LinkID=619899)
