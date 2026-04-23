---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskInfo.IsSupported
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskInfo.IsSupported

<!--
public static bool IsSupported ();
-->


## -description

Gets a value that indicates whether the app task feature is supported on the current device.

## -returns

`true` if app tasks are supported; otherwise, `false`.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

Call this method before using other `AppTaskInfo` APIs. At startup, call `IsSupported` and [FindAll](apptaskinfo_findall_1149612203.md) to enumerate existing tasks that may have been added previously. `AppTaskInfo` instances are persisted beyond the lifetime of the calling app and also persist through reboots. If an app adds a task, it is the app's responsibility to remove it at the appropriate time in the future. If this method returns `false`, [FindAll](apptaskinfo_findall_1149612203.md) returns an empty collection.

## -see-also

## -examples


