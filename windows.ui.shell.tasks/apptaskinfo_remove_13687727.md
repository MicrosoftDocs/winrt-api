---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskInfo.Remove
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskInfo.Remove

<!--
public void Remove ();
-->


## -description

Removes this task from the Windows Shell, but doesn't change its state.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

Call this method when the app determines it no longer wants to display the task on the taskbar, such as when the task has completed or the user has deleted the task from within the app. Calling `Remove` multiple times is harmless.

## -see-also

## -examples


