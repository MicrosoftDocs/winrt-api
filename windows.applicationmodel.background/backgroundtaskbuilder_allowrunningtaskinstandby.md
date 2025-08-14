---
-api-id: P:Windows.ApplicationModel.Background.BackgroundTaskBuilder.AllowRunningTaskInStandby
-api-type: winrt property
---

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.AllowRunningTaskInStandby

<!--
public bool AllowRunningTaskInStandby { get; set; }
-->

## -description

Gets or sets a value that indicates whether the background task can run in standby mode.

## -property-value

This value is `true` if the background task can run in standby mode; otherwise, `false`.

## -remarks

The property allows developers to opt-in a background task registration to run in modern standby. When using the [BackgroundTaskBuilder.Register(string)](backgroundtaskbuilder_register_1223384297.md) overload, running tasks in modern standby is not requested by default.

## -see-also

## -examples
