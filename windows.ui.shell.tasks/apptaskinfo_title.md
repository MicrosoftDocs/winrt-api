---
-api-id: P:Windows.UI.Shell.Tasks.AppTaskInfo.Title
-api-type: winrt property
---

# Windows.UI.Shell.Tasks.AppTaskInfo.Title

<!--
public string Title { get; }
-->


## -description

Gets the title of this task.

## -property-value

The title that represents the type of task.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

Title and subtitle are text fields that represent the type of task. They are displayed in the UI, sometimes appended together (for example, "Researcher - Trends in smart appliances"). Tasks are grouped based on the title.

Use the [Create](apptaskinfo_create_1666284704.md) or [UpdateTitles](apptaskinfo_updatetitles_872526535.md) methods to set title and subtitle values.

## -see-also

## -examples


