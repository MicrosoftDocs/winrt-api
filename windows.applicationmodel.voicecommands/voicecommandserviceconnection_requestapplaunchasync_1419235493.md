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

An app is launched to the foreground through Uniform Resource Identifier (URI) activation using a [Protocol](../windows.applicationmodel.activation/activationkind.md) contract. The app must override the [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) event and check for an [ActivationKind](../windows.applicationmodel.activation/activationkind.md) of [Protocol](../windows.applicationmodel.activation/activationkind.md). See [Handle URI activation](http://msdn.microsoft.com/library/92d06f3e-c8f3-42e0-a476-7e94fd14b2be) for more info.

**Cortana** terminates the background app service and launches the app in foreground with the launch parameter provided by the app.

## -examples

## -see-also
[Cortana interactions](http://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Deep link from Cortana to a background app](http://msdn.microsoft.com/library/be811a87-8821-476a-90e4-2e20d37e4043), [ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana design guidelines](http://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](http://go.microsoft.com/fwlink/p/?LinkID=619899)