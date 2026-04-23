---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskInfo.UpdateTitles(System.String,System.String)
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskInfo.UpdateTitles(System.String,System.String)

<!--
public void UpdateTitles (string title, string subtitle);
-->


## -description

Updates the title and subtitle of this task.

## -parameters

### -param title

The new title for the task. This value is required.

### -param subtitle

The new subtitle for the task. Can be an empty string.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

Use this method to update the task titles, for example, when an agent takes time to generate an appropriate name for a conversation.

## -see-also

## -examples


