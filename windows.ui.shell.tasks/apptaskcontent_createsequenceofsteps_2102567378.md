---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskContent.CreateSequenceOfSteps(System.String[],System.String)
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskContent.CreateSequenceOfSteps(System.String[],System.String)

<!--
public static Windows.UI.Shell.Tasks.AppTaskContent CreateSequenceOfSteps (string[] completedSteps, string executingStep);
-->


## -description

Creates task content that displays a sequence of steps showing task progress.

## -parameters

### -param completedSteps

An array of strings that represent the steps that have already been completed.

### -param executingStep

A string that represents the step that is currently executing.

## -returns

A new [AppTaskContent](apptaskcontent.md) object that displays step-by-step progress.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

This content type is useful for tasks that process a series of steps, such as AI agent workflows. The task doesn't need to know what steps will come next; it shows only past and current progress.

## -see-also

## -examples


