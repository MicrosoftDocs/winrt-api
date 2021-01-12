---
-api-id: P:Windows.System.AppResourceGroupBackgroundTaskReport.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.System.AppResourceGroupBackgroundTaskReport.Name

## -description
Gets the name of the background task.

## -property-value
The background task name.

## -remarks
This is the name supplied by the app when it registered the task with [BackgroundTaskBuilder](/uwp/api/Windows.ApplicationModel.Background.BackgroundTaskBuilder)

Some background tasks do not have names and will return an empty string because they are not explicitly registered. For example, background audio playback tasks and app-service tasks.

## -see-also

## -examples

## -capabilities
appDiagnostics
