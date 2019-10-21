---
-api-id: T:Windows.ApplicationModel.VoiceCommands.VoiceCommandCompletionReason
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.VoiceCommands.VoiceCommandCompletionReason : int
-->

# VoiceCommandCompletionReason

## -description
Specifies the possible reasons the voice command completed.

## -enum-fields
### -field Unknown:0
Unknown error.

### -field CommunicationFailed:1
Communication with **Cortana** failed.

### -field ResourceLimitsExceeded:2
The background app service exited because not enough resources were available.

### -field Canceled:3
The user cancelled the interaction with **Cortana**.

### -field TimeoutExceeded:4
The background app service took too long to provide a response to **Cortana**.

### -field AppLaunched:5
The background app service requested that the app launch in the foreground with a call to [RequestAppLaunchAsync](voicecommandserviceconnection_requestapplaunchasync_1419235493.md).

### -field Completed:6
The background app service completed the interaction by calling [ReportSuccessAsync](voicecommandserviceconnection_reportsuccessasync_2126991650.md) or [ReportFailureAsync](voicecommandserviceconnection_reportfailureasync_1581497711.md).


## -remarks

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [VoiceCommandCompletedEventArgs.Reason](voicecommandcompletedeventargs_reason.md), [ elements and attributes v1.2](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-interactions), [Cortana design guidelines](https://docs.microsoft.com/windows/uwp/input-and-devices/cortana-design-guidelines), [Cortana voice command sample](https://go.microsoft.com/fwlink/p/?LinkID=619899)
