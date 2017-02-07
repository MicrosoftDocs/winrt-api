---
-api-id: T:Windows.ApplicationModel.Background.BackgroundAccessStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Background.BackgroundAccessStatus : int
-->

# BackgroundAccessStatus

## -description
This enumeration specifies an app's ability to perform background activity.



> Apps must successfully call [Windows.ApplicationModel.Background.BackgroundExecutionManager.requestAccessAsync](backgroundexecutionmanager_requestaccessasync.md) before registering background tasks.

## -enum-fields
### -field Unspecified:0
The app cannot perform background activity in this state.

On Windows 8 and Windows 8.1, [RequestAccessAsync](backgroundexecutionmanager_requestaccessasync.md) displayed a dialog that asked the user if the app should run in the background. This value was returned if the user did not select "allow" or "don't allow" in the dialog box, or dismissed it without making a choice.

### -field AllowedWithAlwaysOnRealTimeConnectivity:1
The app can set up background tasks, and, if it has the capability, can use the real-time connectivity (RTC) broker. This means that the app can function while the device is in the connected standby state.

This value is deprecated in Windows 10, version 1607.

On Windows 8 and Windows 8.1, [RequestAccessAsync](backgroundexecutionmanager_requestaccessasync.md) displayed a dialog that asked the user if the app should run in the background. This value was returned if the user chose "allow" in the dialog box. After this value had been returned, subsequent calls to the [RequestAccessAsync](backgroundexecutionmanager_requestaccessasync.md) method did not present the dialog box to the user.

### -field AllowedMayUseActiveRealTimeConnectivity:2
The app can set up background tasks, but it cannot use the real-time connectivity (RTC) broker. This means that the app might not function while the device is in connected standby. Note that apps that do not specify RTC in their manifest will always demonstrate this behavior.

This value is deprecated in Windows 10, version 1607.

On Windows 8 and Windows 8.1, [RequestAccessAsync](backgroundexecutionmanager_requestaccessasync.md) displayed a dialog that asked the user if the app should run in the background. This value was returned if the user chose "allow" in the dialog box. After this value had been returned, subsequent calls to the [RequestAccessAsync](backgroundexecutionmanager_requestaccessasync.md) method did not present the dialog box to the user.

### -field Denied:3
This value is deprecated in Windows 10, version 1607.

On Windows 8 and Windows 8.1, [RequestAccessAsync](backgroundexecutionmanager_requestaccessasync.md) displayed a dialog that asked the user if the app should run in the background. This value was returned if the user chose "don't allow" in the dialog box. After this value had been returned, subsequent calls to the [RequestAccessAsync](backgroundexecutionmanager_requestaccessasync.md) method did not present the dialog box to the user.

### -field AlwaysAllowed:4
On devices that have a battery, the user has given the app permission in the battery use settings to always allow background access. Introduced in Windows 10, version 1607.

### -field AllowedSubjectToSystemPolicy:5
The user has selected Balanced or System Managed in the battery use settings. Introduced in Windows 10, version 1607.

### -field DeniedBySystemPolicy:6
On devices that have a battery, the user has selected Battery Optimized in the battery use settings and the system has chosen not to allow this application to run in the background based on system resources. Introduced in Windows 10, version 1607.

### -field DeniedByUser:7
On devices that have a battery, the user has disabled the app from running in the background in the battery use settings. Introduced in Windows 10, version 1607.


## -remarks
On devices that do not have a battery, the settings that allow an app to use background activity are found in the background apps settings. On devices that have a battery, background task settings can be found in the Battery use settings.

Declare the RTC capability in your app's manifest by specifying the **Control channel** background task in the **Declarations** tab. For more information, see [How to set background connectivity options](http://msdn.microsoft.com/library/b6042b5f-5cee-4dee-8cb4-8f376f878e97).

If all hardware RTC slots are full at the time that the app is added to the lock screen, and if the app has specified **Control channel** in its manifest, together with **Timer** or **Push notification**, it is added to the lock screen, but without RTC capability. The app can then make further requests to be added to the lock screen, which do not present UI to the user. If a hardware slot is open when one such request is made, the app will take that slot.

## -examples

## -see-also
[How to set background connectivity options](http://msdn.microsoft.com/library/b6042b5f-5cee-4dee-8cb4-8f376f878e97), [BackgroundExecutionManager.getAccessStatus](backgroundexecutionmanager_getaccessstatus.md), [BackgroundExecutionManager.requestAccessAsync](backgroundexecutionmanager_requestaccessasync.md), [Lock screen apps sample](http://go.microsoft.com/fwlink/p/?linkid=239970)