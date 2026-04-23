---
-api-id: T:Windows.UI.Shell.Tasks.AppTaskState
-api-type: winrt enum
---

# Windows.UI.Shell.Tasks.AppTaskState

<!--
public enum AppTaskState
-->


## -description

Defines constants that specify the state of the app task.

## -enum-fields

### -field Running: 0

The task is actively executing.

### -field Completed: 1

The task has finished execution successfully.

### -field NeedsAttention: 2

The task needs user input to continue.

### -field Paused: 3

The task execution is suspended but can be resumed without user intervention.

### -field Error: 4

The task completed with an error state.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

## -see-also

## -examples


