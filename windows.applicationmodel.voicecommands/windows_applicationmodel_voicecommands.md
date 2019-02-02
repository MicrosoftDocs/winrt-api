---
-api-id: N:Windows.ApplicationModel.VoiceCommands
-api-type: winrt namespace
---

# Windows.ApplicationModel.VoiceCommands

## -description
Provides support for handling voice commands in **Cortana**, entered by speech or text, to access features and functionality from a background app. When an app handles a voice command in the background it can display feedback on the **Cortana** canvas and communicate with the user using the **Cortana** voice.

A Voice Command Definition (VCD) file must be registered by the app to enable voice command access to its functionality. See [Launch a background app with voice commands in Cortana ](https://msdn.microsoft.com/library/df5b530c-57dd-4ca5-b3be-1a0b3695c9c6) for more info on creating and registering a Voice Command Definition (VCD) file for your app.

> [!NOTE]
> A voice command is a single utterance, defined in a Voice Command Definition (VCD) file, directed at an installed app through **Cortana**. The app can be launched in the foreground or background, depending on the level and complexity of the interaction. For instance, voice commands that require additional context or user input are best handled in the foreground, while basic commands can be handled in the background.

## -remarks

## -examples

## -see-also
[Custom user interactions](https://msdn.microsoft.com/library/9403c46c-60da-4c13-a381-6fbd069dd9ce), [ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana design guidelines](https://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](https://go.microsoft.com/fwlink/p/?LinkID=619899)
