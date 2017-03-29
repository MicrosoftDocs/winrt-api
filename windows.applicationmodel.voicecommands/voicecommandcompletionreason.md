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
The background app service requested that the app launch in the foreground with a call to [RequestAppLaunchAsync](voicecommandserviceconnection_requestapplaunchasync.md).

### -field Completed:6
The background app service completed the interaction by calling [ReportSuccessAsync](voicecommandserviceconnection_reportsuccessasync.md) or [ReportFailureAsync](voicecommandserviceconnection_reportfailureasync.md).


## -remarks

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [VoiceCommandCompletedEventArgs.Reason](voicecommandcompletedeventargs_reason.md), [ elements and attributes v1.2](https://docs.microsoft.com/en-us/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md), [Cortana interactions](http://msdn.microsoft.com/library/4c11a7cf-da26-4ca1-a9b9-fe52670101f5), [Cortana design guidelines](http://msdn.microsoft.com/library/a92c084b-9913-4718-9a04-569d51ace55d), [Cortana voice command sample](http://go.microsoft.com/fwlink/p/?LinkID=619899)