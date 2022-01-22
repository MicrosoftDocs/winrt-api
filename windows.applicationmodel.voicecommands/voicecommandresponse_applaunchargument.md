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

AppLaunchArgument is used to specify the state or context of the foreground app when launched through a deep link in **Cortana**.

## -property-value
The string used as a launch parameter.

## -remarks
To enable deep linking to an app, declare the `windows.personalAssistantLaunch` extension in the Package.appxmanifest file of the app project.

An app is launched to the foreground through Uniform Resource Identifier (URI) activation using a [Protocol](../windows.applicationmodel.activation/activationkind.md) contract. The app must override the [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) event and check for an [ActivationKind](../windows.applicationmodel.activation/activationkind.md) of [Protocol](../windows.applicationmodel.activation/activationkind.md). See [Handle URI activation](/windows/uwp/launch-resume/handle-uri-activation) for more info.

## -examples

## -see-also
[Deep link from Cortana to a background app](/windows/apps/design/input/cortana-deep-link-into-your-app), [ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
