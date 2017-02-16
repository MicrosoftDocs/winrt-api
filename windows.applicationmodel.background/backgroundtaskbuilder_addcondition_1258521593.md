---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskBuilder.AddCondition(Windows.ApplicationModel.Background.IBackgroundCondition)
-api-type: winrt method
---

<!-- Method syntax
public void AddCondition(Windows.ApplicationModel.Background.IBackgroundCondition condition)
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.AddCondition

## -description
Adds a condition to a background task.

## -parameters
### -param condition
An instance of a [SystemCondition](systemcondition.md) object.

## -remarks
[AddCondition](backgroundtaskbuilder_addcondition.md) can be called more than once to specify more than one condition for a background task. All specified conditions must be met before the system will schedule the task.

## -examples

## -see-also
