---
-api-id: P:Windows.UI.Shell.Tasks.AppTaskInfo.HiddenByUser
-api-type: winrt property
---

# Windows.UI.Shell.Tasks.AppTaskInfo.HiddenByUser

<!--
public bool HiddenByUser { get; }
-->


## -description

Gets a value that indicates whether the user has hidden this task through the Windows Shell.

## -property-value

`true` if the user has hidden this task; otherwise, `false`.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

When a user hides a task from the taskbar it has no impact on the task running in the app; its representation is simply removed from the taskbar. Hidden tasks are still returned by [FindAll](apptaskinfo_findall_1149612203.md).

## -see-also

## -examples


