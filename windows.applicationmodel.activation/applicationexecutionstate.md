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

State|When this state is seen|What your app should do
---|---|---
**NotRunning**|The user first activates the app after 1) installing the app from the Store 2) clicking **End task** in Task Manager while the app is running 3) rebooting the computer 4) logging off and back on. The user closes the app through the close gesture or Alt+F4 and activates it within about 10 seconds of closing it.|Display its initial UI and perform initialization tasks.
**Running**|The app is activated through a secondary tile or one of the [activation contracts and extensions](/previous-versions/windows/apps/hh464906(v=win.10)) while it is running.|Respond to the activation event as appropriate.
**Suspended**|The app is activated through a secondary tile or one of the [activation contracts and extensions](/previous-versions/windows/apps/hh464906(v=win.10)) while Windows is suspending it or after Windows has suspended it.|Respond to the activation event as appropriate.
**Terminated**|Windows successfully suspends the app and then it is terminated. For example, Windows can terminate a suspended app if the system is running low on resources. Some apps, such as games, can be pretty resource intensive.|Restore itself to the way the user left it, rather than starting fresh. Use data saved during app suspension. Refresh content or network connections that may have become stale.
**ClosedByUser**|The user closes the app through the close gesture or Alt+F4 and takes longer than 10 seconds to activate the app again.|In Windows 8, display its initial UI and perform initialization tasks, rather than restoring its previous state. In Windows 8.1, restore itself to the way the user left it, rather than starting fresh. Use data saved during app suspension. Refresh content or network connections that may have become stale.

If your Windows 8 app depends on the Windows 8 **ClosedByUser** behavior, you can enable it when you upgrade it to Windows 8.1 by setting the [Windows.UI.ViewManagement.ApplicationView.TerminateAppOnFinalViewClose](../windows.ui.viewmanagement/applicationview_terminateapponfinalviewclose.md) property to **true**.

### Windows Phone 8

On Windows Phone, only **NotRunning** and **Suspended** are supported.

## -examples

## -see-also
[App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [UX guidelines for launch, suspend, and resume](/windows/uwp/launch-resume/index), [CachedFileUpdaterActivatedEventArgs.PreviousExecutionState](cachedfileupdateractivatedeventargs_previousexecutionstate.md), [CameraSettingsActivatedEventArgs.PreviousExecutionState](camerasettingsactivatedeventargs_previousexecutionstate.md), [ContactPickerActivatedEventArgs.PreviousExecutionState](contactpickeractivatedeventargs_previousexecutionstate.md), [DeviceActivatedEventArgs.PreviousExecutionState](deviceactivatedeventargs_previousexecutionstate.md), [FileActivatedEventArgs.PreviousExecutionState](fileactivatedeventargs_previousexecutionstate.md), [FileOpenPickerActivatedEventArgs.PreviousExecutionState](fileopenpickeractivatedeventargs_previousexecutionstate.md), [FileSavePickerActivatedEventArgs.PreviousExecutionState](filesavepickeractivatedeventargs_previousexecutionstate.md), [LaunchActivatedEventArgs.PreviousExecutionState](launchactivatedeventargs_previousexecutionstate.md), [PrintTaskSettingsActivatedEventArgs.PreviousExecutionState](printtasksettingsactivatedeventargs_previousexecutionstate.md), [ProtocolActivatedEventArgs.PreviousExecutionState](protocolactivatedeventargs_previousexecutionstate.md), [SearchActivatedEventArgs.PreviousExecutionState](searchactivatedeventargs_previousexecutionstate.md), [ShareTargetActivatedEventArgs.PreviousExecutionState](sharetargetactivatedeventargs_previousexecutionstate.md), [WebUICachedFileUpdaterActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuicachedfileupdateractivatedeventargs_previousexecutionstate.md), [WebUICameraSettingsActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuicamerasettingsactivatedeventargs_previousexecutionstate.md), [WebUIContactPickerActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuicontactpickeractivatedeventargs_previousexecutionstate.md), [WebUIDeviceActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuideviceactivatedeventargs_previousexecutionstate.md), [WebUIFileActivatedEventArgs.previousExecutionState](fileactivatedeventargs_previousexecutionstate.md), [WebUIFileOpenPickerActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuifileopenpickeractivatedeventargs_previousexecutionstate.md), [WebUIFileSavePickerActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuifilesavepickeractivatedeventargs_previousexecutionstate.md), [WebUILaunchActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuilaunchactivatedeventargs_previousexecutionstate.md), [WebUIPrintTaskSettingsActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuiprinttasksettingsactivatedeventargs_previousexecutionstate.md), [WebUIProtocolActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuiprotocolactivatedeventargs_previousexecutionstate.md), [WebUISearchActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuisearchactivatedeventargs_previousexecutionstate.md), [WebUIShareTargetActivatedEventArgs.previousExecutionState](../windows.ui.webui/webuisharetargetactivatedeventargs_previousexecutionstate.md)
