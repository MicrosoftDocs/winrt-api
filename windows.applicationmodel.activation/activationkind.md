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

The app was activated as the lock screen. Introduced in Windows 10, version 1507 (10.0.10240).

### -field PickerReturned:1000

Windows Phone only. The app was activated after the completion of a picker.

### -field WalletAction:1001

Windows Phone only. The app was activated to perform a Wallet operation.

### -field PickFileContinuation:1002

Windows Phone only. The app was activated after the app was suspended for a file picker operation.

> [!NOTE]
> This value was deprecated in Windows 10, version 2004 (build 19041). The file/folder continuation APIs are no longer relevant with the discontinuation of Windows Phone.

### -field PickSaveFileContinuation:1003

Windows Phone only. The app was activated after the app was suspended for a file save picker operation.

> [!NOTE]
> This value was deprecated in Windows 10, version 2004 (build 19041). The file/folder continuation APIs are no longer relevant with the discontinuation of Windows Phone.

### -field PickFolderContinuation:1004

Windows Phone only. The app was activated after the app was suspended for a folder picker operation.

> [!NOTE]
> This value was deprecated in Windows 10, version 2004 (build 19041). The file/folder continuation APIs are no longer relevant with the discontinuation of Windows Phone.

### -field WebAuthenticationBrokerContinuation:1005

Windows Phone only. The app was activated after the app was suspended for a web authentication broker operation.

### -field WebAccountProvider:1006

The app was activated by a web account provider. Introduced in Windows 10, version 1507 (10.0.10240).

### -field ComponentUI:1007

Reserved for system use. Introduced in Windows 10, version 1507 (10.0.10240).

### -field ProtocolForResults:1009

The app was launched by another app with the expectation that it will return a result back to the caller. Introduced in Windows 10, version 1507 (10.0.10240).

### -field ToastNotification:1010

The app was activated when a user tapped on the body of a toast notification or performed an action inside a toast notification. Introduced in Windows 10, version 1507 (10.0.10240).

### -field Print3DWorkflow:1011

This app was launched by another app to provide a customized printing experience for a 3D printer. Introduced in Windows 10, version 1507 (10.0.10240).

### -field DialReceiver:1012

This app was launched by another app on a different device by using the DIAL protocol. Introduced in Windows 10, version 1507 (10.0.10240).

### -field DevicePairing:1013

This app was activated as a result of pairing a device.

### -field UserDataAccountsProvider:1014

The app was launched to handle the user interface for account management. In circumstances where the system would have shown the default system user interface, it instead has invoked your app with the UserDataAccountProvider contract. The activation payload contains information about the type of operation being requested and all the information necessary to replicate the system-provided user interface. This activation kind is limited to 1st party apps. To use this field, you must add the `userDataAccountsProvider` capability in your app's package manifest. For more info see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). Introduced in Windows 10, version 1607 (10.0.14393).

### -field FilePickerExperience:1015

Reserved for system use. Introduced in Windows 10, version 1607 (10.0.14393).

### -field ContactPanel:1017

The app was launched from the **My People** UI. Note: introduced in Windows 10, version 1703 (10.0.15063), but not used. Now used starting with Windows 10, version 1709 (10.0.16299).

### -field LockScreenComponent:1016

Reserved for system use. Introduced in Windows 10, version 1703 (10.0.15063).

### -field PrintWorkflowForegroundTask:1018

The app was activated because the user is printing to a printer that has a Print Workflow Application associated with it which has requested user input.

### -field GameUIProvider:1019

The app was activated because it was launched by the OS due to a request for game-specific UI. Introduced in Windows 10, version 1703 (10.0.15063).

### -field StartupTask:1020

The app was activated because the app is specified to launch at system startup or user log-in. Introduced in Windows 10, version 1703 (10.0.15063).

### -field CommandLineLaunch:1021

The app was launched from the command line. Introduced in Windows 10, version 1709 (10.0.16299)

### -field BarcodeScannerProvider:1022

The app was activated as a barcode scanner provider.

### -field PrintSupportJobUI: 1023

The app was activated as a print support settings UI extension. For more information, see For more information, see [PrintWorkflowJobUISession](../windows.graphics.printing.workflow/printworkflowjobuisession.md).

### -field PrintSupportSettingsUI: 1024

The app was activated as a print workflow job UI extension. For more information, see [PrintSupportSettingsUISession](../windows.graphics.printing.printsupport/printsupportsettingsuisession.md).

### -field PhoneCallActivation: 1025

The app was activated in response to a phone call.

### -field VpnForeground: 1026

The app is a VPN foreground app that was activated by the plugin. For more details, see [VpnChannel.ActivateForeground](../windows.networking.vpn/ivpnplugin_encapsulate_494498240.md).

## -remarks

Values are mutually exclusive and cannot be combined. Each one relates to a different type of activation, and an app instance can be activated in only one way at a time.

For more information about app activation, see the remarks on the [Application.OnActivated(IActivatedEventArgs)](../windows.ui.xaml/application_onactivated_603737819.md) page.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | DevicePairing |
| 1511 | 10586 | Print3DWorkflow |
| 1607 | 14393 | FilePickerExperience |
| 1607 | 14393 | UserDataAccountsProvider |
| 1703 | 15063 | ContactPanel |
| 1703 | 15063 | LockScreenComponent |
| 1709 | 16299 | CommandLineLaunch |
| 1709 | 16299 | GameUIProvider |
| 1709 | 16299 | PrintWorkflowForegroundTask |
| 1709 | 16299 | StartupTask |
| 1803 | 17134 | BarcodeScannerProvider |

## -examples

## -see-also

[CachedFileUpdaterActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.cachedfileupdateractivatedeventargs.kind), [CameraSettingsActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.camerasettingsactivatedeventargs.kind), [ContactPickerActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.contactpickeractivatedeventargs.kind), [DeviceActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.deviceactivatedeventargs.kind), [FileActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.fileactivatedeventargs.kind), [FileOpenPickerActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.fileopenpickeractivatedeventargs.kind), [FileSavePickerActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.filesavepickeractivatedeventargs.kind), [LaunchActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.launchactivatedeventargs.kind), [LockScreenActivatedEventsArg.Kind](/uwp/api/windows.applicationmodel.activation.lockscreenactivatedeventargs.kind), [PrintTaskSettingsActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.printtasksettingsactivatedeventargs.kind), [ProtocolActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.protocolactivatedeventargs.kind), [SearchActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.searchactivatedeventargs.kind), [ShareTargetActivatedEventArgs.Kind](/uwp/api/windows.applicationmodel.activation.sharetargetactivatedeventargs.kind), [WebUICachedFileUpdaterActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuicachedfileupdateractivatedeventargs.kind), [WebUICameraSettingsActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuicamerasettingsactivatedeventargs.kind), [WebUIContactPickerActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuicontactpickeractivatedeventargs.kind), [WebUIDeviceActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuideviceactivatedeventargs.kind), [WebUIFileActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuifileactivatedeventargs.kind), [WebUIFileOpenPickerActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuifileopenpickeractivatedeventargs.kind), [WebUIFileSavePickerActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuifilesavepickeractivatedeventargs.kind), [WebUILaunchActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuilaunchactivatedeventargs.kind), [WebUIPrintTaskSettingsActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuiprinttasksettingsactivatedeventargs.kind), [WebUIProtocolActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuiprotocolactivatedeventargs.kind), [WebUISearchActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuisearchactivatedeventargs.kind), [WebUIShareTargetActivatedEventArgs.Kind](/uwp/api/windows.ui.webui.webuisharetargetactivatedeventargs.kind)
