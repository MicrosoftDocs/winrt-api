---
-api-id: T:Windows.ApplicationModel.Activation.ApplicationExecutionState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Activation.ApplicationExecutionState : int
-->

# ApplicationExecutionState

## -description
Specifies the execution state of the app.

## -enum-fields
### -field NotRunning:0
The app is not running.

### -field Running:1
The app is running.

### -field Suspended:2
The app is suspended.

### -field Terminated:3
The app was terminated after being suspended.

### -field ClosedByUser:4
The app was closed by the user.


## -remarks
This table provides more detail about when you'll see each of these states and what your app should do in response.

<table>
   <tr><th>State</th><th>When this state is seen</th><th>What your app should do</th></tr>
   <tr><td>**NotRunning**</td><td>The user first activates the app after:

<ul><li>installing the app from the Store</li><li>clicking **End task** in Task Manager while the app is running</li><li>rebooting the computer</li><li>logging off and back on</li></ul>The user closes the app through the close gesture or Alt+F4 and activates it within about 10 seconds of closing it.</td><td>Display its initial UI and perform initialization tasks.</td></tr>
   <tr><td>**Running**</td><td>The app is activated through a secondary tile or one of the [activation contracts and extensions](https://msdn.microsoft.com/library/08800074-78ba-410a-962f-876da3463629) while it is running.</td><td>Respond to the activation event as appropriate.</td></tr>
   <tr><td>**Suspended**</td><td>The app is activated through a secondary tile or one of the [activation contracts and extensions](https://msdn.microsoft.com/library/08800074-78ba-410a-962f-876da3463629) while Windows is suspending it or after Windows has suspended it.</td><td>Respond to the activation event as appropriate.</td></tr>
   <tr><td>**Terminated**</td><td>Windows successfully suspends the app and then it is terminated. For example, Windows can terminate a suspended app if the system is running low on resources. Some apps, such as games, can be pretty resource intensive.</td><td>Restore itself to the way the user left it, rather than starting fresh. Use data saved during app suspension. Refresh content or network connections that may have become stale.</td></tr>
   <tr><td>**ClosedByUser**</td><td>The user closes the app through the close gesture or Alt+F4 and takes longer than 10 seconds to activate the app again.</td><td>In Windows 8, display its initial UI and perform initialization tasks, rather than restoring its previous state.

In Windows 8.1, restore itself to the way the user left it, rather than starting fresh. Use data saved during app suspension. Refresh content or network connections that may have become stale.

> [!NOTE]
> If your Windows 8 app depends on the Windows 8**ClosedByUser** behavior, you can enable this behavior in your Windows 8.1 app when you upgrade it to Windows 8.1. To enable the Windows 8**ClosedByUser** behavior, set your Windows 8.1 app to terminate when the last window is closed with the [Windows.UI.ViewManagement.ApplicationView.TerminateAppOnFinalViewClose](../windows.ui.viewmanagement/applicationview_terminateapponfinalviewclose.md) property.</td></tr>
</table>

### Windows Phone 8

On Windows Phone, only **NotRunning** and **Suspended** are supported.

## -examples

## -see-also
[App lifecycle](https://msdn.microsoft.com/library/6c469e77-f1e3-4859-a27b-c326f9616d10), [UX guidelines for launch, suspend, and resume](https://msdn.microsoft.com/library/90770735-c2c5-4d3a-a21f-48a59e2a0ba9), [CachedFileUpdaterActivatedEventArgs.PreviousExecutionState](cachedfileupdateractivatedeventargs_previousexecutionstate.md), [CameraSettingsActivatedEventArgs.PreviousExecutionState](camerasettingsactivatedeventargs_previousexecutionstate.md), [ContactPickerActivatedEventArgs.PreviousExecutionState](contactpickeractivatedeventargs_previousexecutionstate.md), [DeviceActivatedEventArgs.PreviousExecutionState](deviceactivatedeventargs_previousexecutionstate.md), [FileActivatedEventArgs.PreviousExecutionState](fileactivatedeventargs_previousexecutionstate.md), [FileOpenPickerActivatedEventArgs.PreviousExecutionState](fileopenpickeractivatedeventargs_previousexecutionstate.md), [FileSavePickerActivatedEventArgs.PreviousExecutionState](filesavepickeractivatedeventargs_previousexecutionstate.md), [LaunchActivatedEventArgs.PreviousExecutionState](launchactivatedeventargs_previousexecutionstate.md), [PrintTaskSettingsActivatedEventArgs.PreviousExecutionState](printtasksettingsactivatedeventargs_previousexecutionstate.md), [ProtocolActivatedEventArgs.PreviousExecutionState](protocolactivatedeventargs_previousexecutionstate.md), [SearchActivatedEventArgs.PreviousExecutionState](searchactivatedeventargs_previousexecutionstate.md), [ShareTargetActivatedEventArgs.PreviousExecutionState](sharetargetactivatedeventargs_previousexecutionstate.md), [WebUICachedFileUpdaterActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuicachedfileupdateractivatedeventargs_previousexecutionstate.md), [WebUICameraSettingsActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuicamerasettingsactivatedeventargs_previousexecutionstate.md), [WebUIContactPickerActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuicontactpickeractivatedeventargs_previousexecutionstate.md), [WebUIDeviceActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuideviceactivatedeventargs_previousexecutionstate.md), [WebUIFileActivatedEventArgs.previousExecutionState](fileactivatedeventargs_previousexecutionstate.md), [WebUIFileOpenPickerActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuifileopenpickeractivatedeventargs_previousexecutionstate.md), [WebUIFileSavePickerActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuifilesavepickeractivatedeventargs_previousexecutionstate.md), [WebUILaunchActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuilaunchactivatedeventargs_previousexecutionstate.md), [WebUIPrintTaskSettingsActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuiprinttasksettingsactivatedeventargs_previousexecutionstate.md), [WebUIProtocolActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuiprotocolactivatedeventargs_previousexecutionstate.md), [WebUISearchActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuisearchactivatedeventargs_previousexecutionstate.md), [WebUIShareTargetActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuisharetargetactivatedeventargs_previousexecutionstate.md)
