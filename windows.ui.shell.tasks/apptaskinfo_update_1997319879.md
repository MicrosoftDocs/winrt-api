---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskInfo.Update(Windows.UI.Shell.Tasks.AppTaskState,Windows.UI.Shell.Tasks.AppTaskContent)
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskInfo.Update(Windows.UI.Shell.Tasks.AppTaskState,Windows.UI.Shell.Tasks.AppTaskContent)

<!--
public void Update (Windows.UI.Shell.Tasks.AppTaskState state, Windows.UI.Shell.Tasks.AppTaskContent content);
-->


## -description

Updates both the state and content of this task.

## -parameters

### -param state

A value of the enumeration that indicates the new state of the task.

### -param content

The new content to display for this task, created using one of the [AppTaskContent](apptaskcontent.md) factory methods.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

Use this method to update the task representation as the task progresses, encounters errors, or completes.

## -see-also

## -examples


