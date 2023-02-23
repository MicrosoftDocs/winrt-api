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

| State | When this state is seen | What your app should do |
| --- | --- | --- |
| `NotRunning` | The user first activates the app after: 1) installing the app from the Store; 2) clicking **End task** in Task Manager while the app is running; 3) rebooting the computer; 4) logging off and back on.<br/>The user closes the app through the close gesture or Alt+F4 and activates it within about 10 seconds of closing it. | Display its initial UI and perform initialization tasks. |
| `Running` | The app is activated through a secondary tile or one of the [activation contracts and extensions](/previous-versions/windows/apps/hh464906(v=win.10)) while it is running. | Respond to the activation event as appropriate. |
| `Suspended` | The app is activated through a secondary tile or one of the [activation contracts and extensions](/previous-versions/windows/apps/hh464906(v=win.10)) while Windows is suspending it or after Windows has suspended it. | Respond to the activation event as appropriate. |
| `Terminated` | Windows successfully suspends the app and then it is terminated. For example, Windows can terminate a suspended app if the system is running low on resources. Some apps, such as games, can be pretty resource intensive. | Restore itself to the way the user left it, rather than starting fresh. Use data saved during app suspension. Refresh content or network connections that may have become stale. |
| `ClosedByUser` | The user closes the app through the close gesture or Alt+F4 and takes longer than 10 seconds to activate the app again. | Restore itself to the way the user left it, rather than starting fresh. Use data saved during app suspension. Refresh content or network connections that may have become stale. |

### Windows 8

In Windows 8, when the `State` is `ClosedByUser`, display the app's initial UI and perform initialization tasks, rather than restoring its previous state. If your Windows 8 app depends on the Windows 8 `ClosedByUser` behavior, you can enable it when you upgrade it to Windows 8.1 or later by setting the [Windows.UI.ViewManagement.ApplicationView.TerminateAppOnFinalViewClose](../windows.ui.viewmanagement/applicationview_terminateapponfinalviewclose.md) property to `true`.

### Windows Phone 8

On Windows Phone, only `NotRunning` and `Suspended` are supported.

## -examples

## -see-also

[App lifecycle](/windows/uwp/launch-resume/app-lifecycle),
[UX guidelines for launch, suspend, and resume](/windows/uwp/launch-resume/index),
[CachedFileUpdaterActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.cachedfileupdateractivatedeventargs.previousexecutionstate), [CameraSettingsActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.camerasettingsactivatedeventargs.previousexecutionstate),
[ContactPickerActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.contactpickeractivatedeventargs.previousexecutionstate),
[DeviceActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.deviceactivatedeventargs.previousexecutionstate),
[FileActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.fileactivatedeventargs.previousexecutionstate),
[FileOpenPickerActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.fileopenpickeractivatedeventargs.previousexecutionstate),
[FileSavePickerActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.filesavepickeractivatedeventargs.previousexecutionstate),
[LaunchActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.launchactivatedeventargs.previousexecutionstate),
[PrintTaskSettingsActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.printtasksettingsactivatedeventargs.previousexecutionstate),
[ProtocolActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.protocolactivatedeventargs.previousexecutionstate),
[SearchActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.searchactivatedeventargs.previousexecutionstate),
[ShareTargetActivatedEventArgs.PreviousExecutionState](/uwp/api/windows.applicationmodel.activation.sharetargetactivatedeventargs.previousexecutionstate),
[WebUICachedFileUpdaterActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuicachedfileupdateractivatedeventargs.previousexecutionstate),
[WebUICameraSettingsActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuicamerasettingsactivatedeventargs.previousexecutionstate),
[WebUIContactPickerActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuicontactpickeractivatedeventargs.previousexecutionstate),
[WebUIDeviceActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuideviceactivatedeventargs.previousexecutionstate),
[WebUIFileActivatedEventArgs.previousExecutionState](/uwp/api/windows.applicationmodel.activation.fileactivatedeventargs.previousexecutionstate),
[WebUIFileOpenPickerActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuifileopenpickeractivatedeventargs.previousexecutionstate),
[WebUIFileSavePickerActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuifilesavepickeractivatedeventargs.previousexecutionstate),
[WebUILaunchActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuilaunchactivatedeventargs.previousexecutionstate),
[WebUIPrintTaskSettingsActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuiprinttasksettingsactivatedeventargs.previousexecutionstate),
[WebUIProtocolActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuiprotocolactivatedeventargs.previousexecutionstate),
[WebUISearchActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuisearchactivatedeventargs.previousexecutionstate),
[WebUIShareTargetActivatedEventArgs.previousExecutionState](/uwp/api/windows.ui.webui.webuisharetargetactivatedeventargs.previousexecutionstate)
