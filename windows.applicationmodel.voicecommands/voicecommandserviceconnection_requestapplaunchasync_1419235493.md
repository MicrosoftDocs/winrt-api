---
-api-id: M:Windows.ApplicationModel.VoiceCommands.VoiceCommandServiceConnection.RequestAppLaunchAsync(Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RequestAppLaunchAsync(Windows.ApplicationModel.VoiceCommands.VoiceCommandResponse response)
-->

# Windows.ApplicationModel.VoiceCommands.VoiceCommandServiceConnection.RequestAppLaunchAsync

## -description
Sends a response to **Cortana** indicating the command should be handled by the app in the foreground.

## -parameters
### -param response
The response from a background app service for progress, confirmation, disambiguation, completion, or failure screens displayed on the **Cortana** canvas.

## -returns
An asynchronous handler called when the operation is complete.

## -remarks
To enable deep linking to an app, declare the `windows.personalAssistantLaunch` extension in the Package.appxmanifest file of the app project.

An app is launched to the foreground through Uniform Resource Identifier (URI) activation using a [Protocol](../windows.applicationmodel.activation/activationkind.md) contract. The app must override the [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) event and check for an [ActivationKind](../windows.applicationmodel.activation/activationkind.md) of [Protocol](../windows.applicationmodel.activation/activationkind.md). See [Handle URI activation](/windows/uwp/launch-resume/handle-uri-activation) for more info.

**Cortana** terminates the background app service and launches the app in foreground with the launch parameter provided by the app.

## -examples

## -see-also
[Cortana interactions](/windows/apps/design/input/cortana-interactions), [Deep link from Cortana to a background app](/windows/apps/design/input/cortana-deep-link-into-your-app), [ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
