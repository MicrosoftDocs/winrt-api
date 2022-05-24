---
-api-id: N:Windows.ApplicationModel.VoiceCommands
-api-type: winrt namespace
---

# Windows.ApplicationModel.VoiceCommands

## -description
Provides support for handling voice commands in **Cortana**, entered by speech or text, to access features and functionality from a background app. When an app handles a voice command in the background it can display feedback on the **Cortana** canvas and communicate with the user using the **Cortana** voice.

A Voice Command Definition (VCD) file must be registered by the app to enable voice command access to its functionality. See [Launch a background app with voice commands](/windows/apps/design/input/cortana-launch-a-background-app-with-voice-commands) for more info on creating and registering a Voice Command Definition (VCD) file for your app.

> [!NOTE]
> A voice command is a single utterance, defined in a Voice Command Definition (VCD) file, directed at an installed app through **Cortana**. The app can be launched in the foreground or background, depending on the level and complexity of the interaction. For instance, voice commands that require additional context or user input are best handled in the foreground, while basic commands can be handled in the background.

## -remarks

## -examples

## -see-also
[Custom user interactions](/windows/uwp/design/layout/index), [Voice Command Definition (VCD) elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
