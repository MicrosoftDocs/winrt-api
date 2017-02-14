---
-api-id: T:Windows.ApplicationModel.Activation.ActivationKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Activation.ActivationKind : int
-->

# ActivationKind

## -description
Specifies the type of activation.

## -enum-fields
### -field Launch:0
The user launched the app or tapped a content tile.

### -field Search:1
The user wants to search with the app.

### -field ShareTarget:2
The app is activated as a target for share operations.

### -field File:3
An app launched a file whose file type this app is registered to handle.

### -field Protocol:4
An app launched a URI whose scheme name this app is registered to handle.

### -field FileOpenPicker:5
The user wants to pick files that are provided by the app.

### -field FileSavePicker:6
The user wants to save a file and selected the app as the location.

### -field CachedFileUpdater:7
The user wants to save a file that the app provides content management for.

### -field ContactPicker:8
The user wants to pick contacts.

### -field Device:9
The app handles AutoPlay.

### -field PrintTaskSettings:10
The app handles print tasks.

### -field CameraSettings:11
The app captures photos or video from an attached camera.

### -field RestrictedLaunch:12
Windows Store only. The user launched the restricted app.

### -field AppointmentsProvider:13
The user wants to manage appointments that are provided by the app.

### -field Contact:14
Windows Store only. The user wants to handle calls or messages for the phone number of a contact that is provided by the app.

### -field LockScreenCall:15
Windows Store only. The app launches a call from the lock screen. If the user wants to accept the call, the app displays its call UI directly on the lock screen without requiring the user to unlock. A lock-screen call is a special type of launch activation.

### -field VoiceCommand:16
The app was activated as the result of a voice command.

> [!NOTE]
> Not supported in Windows 8 and Windows 8.1 apps.

### -field LockScreen:17
The app was activated as the lock screen. Introduced in Windows 10.

### -field PickerReturned:1000
Windows Phone only. The app was activated after the completion of a picker.

### -field WalletAction:1001
Windows Phone only. The app was activated to perform a Wallet operation.

### -field PickFileContinuation:1002
Windows Phone only. The app was activated after the app was suspended for a file picker operation.

### -field PickSaveFileContinuation:1003
Windows Phone only. The app was activated after the app was suspended for a file save picker operation.

### -field PickFolderContinuation:1004
Windows Phone only. The app was activated after the app was suspended for a folder picker operation.

### -field WebAuthenticationBrokerContinuation:1005
Windows Phone only. The app was activated after the app was suspended for a web authentication broker operation.

### -field WebAccountProvider:1006
The app was activated by a web account provider. Introduced in Windows 10.

### -field ComponentUI:1007
Reserved for system use. Introduced in Windows 10.

### -field ProtocolForResults:1009
The app was launched by another app with the expectation that it will return a result back to the caller. Introduced in Windows 10.

### -field ToastNotification:1010
The app was activated when a user tapped on the body of a toast notification or performed an action inside a toast notification. Introduced in Windows 10.

### -field Print3DWorkflow:1011
This app was launched by another app to provide a customized printing experience for a 3D printer. Introduced in Windows 10.

### -field DialReceiver:1012
This app was launched by another app on a different device by using the DIAL protocol. Introduced in Windows 10.

### -field DevicePairing:1013
This app was activated as a result of pairing a device.

### -field UserDataAccountsProvider:1014
The app was launched to handle the user interface for account management. In circumstances where the system would have shown the default system user interface, it instead has invoked your app with the UserDataAccountProvider contract. The activation payload contains information about the type of operation being requested and all the information necessary to replicate the system-provided user interface.This activation kind is limited to 1st party apps. To use this field, you must add the **userDataAccountsProvider** capability in your app's package manifest. For more info see [App capability declarations](http://aka.ms/appcap).

Introduced in Windows 10, version 1607.

### -field FilePickerExperience:1015
Reserved for system use. Introduced in Windows 10, version 1607.


### -field ContactPanel:1017


### -field LockScreenComponent:1016


### -field PrintWorkflowForegroundTask:1018


## -remarks

## -examples

## -see-also
[CachedFileUpdaterActivatedEventArgs.Kind](cachedfileupdateractivatedeventargs_kind.md), [CameraSettingsActivatedEventArgs.Kind](camerasettingsactivatedeventargs_kind.md), [ContactPickerActivatedEventArgs.Kind](contactpickeractivatedeventargs_kind.md), [DeviceActivatedEventArgs.Kind](deviceactivatedeventargs_kind.md), [FileActivatedEventArgs.Kind](fileactivatedeventargs_kind.md), [FileOpenPickerActivatedEventArgs.Kind](fileopenpickeractivatedeventargs_kind.md), [FileSavePickerActivatedEventArgs.Kind](filesavepickeractivatedeventargs_kind.md), [LaunchActivatedEventArgs.Kind](launchactivatedeventargs_kind.md), [LockScreenActivatedEventsArg.Kind](lockscreenactivatedeventargs_kind.md), [PrintTaskSettingsActivatedEventArgs.Kind](printtasksettingsactivatedeventargs_kind.md), [ProtocolActivatedEventArgs.Kind](protocolactivatedeventargs_kind.md), [SearchActivatedEventArgs.Kind](searchactivatedeventargs_kind.md), [ShareTargetActivatedEventArgs.Kind](sharetargetactivatedeventargs_kind.md), [WebUICachedFileUpdaterActivatedEventArgs.kind](../windows.ui.webui/webuicachedfileupdateractivatedeventargs_kind.md), [WebUICameraSettingsActivatedEventArgs.kind](../windows.ui.webui/webuicamerasettingsactivatedeventargs_kind.md), [WebUIContactPickerActivatedEventArgs.kind](../windows.ui.webui/webuicontactpickeractivatedeventargs_kind.md), [WebUIDeviceActivatedEventArgs.kind](../windows.ui.webui/webuideviceactivatedeventargs_kind.md), [WebUIFileActivatedEventArgs.kind](../windows.ui.webui/webuifileactivatedeventargs_kind.md), [WebUIFileOpenPickerActivatedEventArgs.kind](../windows.ui.webui/webuifileopenpickeractivatedeventargs_kind.md), [WebUIFileSavePickerActivatedEventArgs.kind](../windows.ui.webui/webuifilesavepickeractivatedeventargs_kind.md), [WebUILaunchActivatedEventArgs.kind](../windows.ui.webui/webuilaunchactivatedeventargs_kind.md), [WebUIPrintTaskSettingsActivatedEventArgs.kind](../windows.ui.webui/webuiprinttasksettingsactivatedeventargs_kind.md), [WebUIProtocolActivatedEventArgs.kind](../windows.ui.webui/webuiprotocolactivatedeventargs_kind.md), [WebUISearchActivatedEventArgs.kind](../windows.ui.webui/webuisearchactivatedeventargs_kind.md), [WebUIShareTargetActivatedEventArgs.kind](../windows.ui.webui/webuisharetargetactivatedeventargs_kind.md)


