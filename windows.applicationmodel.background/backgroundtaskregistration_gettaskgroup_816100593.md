---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskRegistration.GetTaskGroup(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public BackgroundTaskRegistrationGroup BackgroundTaskRegistration.GetTaskGroup(String groupId)
-->

# Windows.ApplicationModel.Background.BackgroundTaskRegistration.GetTaskGroup


## -description

Gets the task group object that is associated with the group identifier.

## -parameters

### -param groupId

The group identifier.

## -returns

The task group object that is associated with the group identifier.

## -remarks

If no group with the specified ID is found, `null` is returned.   
To get all of the tasks associated with the group, call [BackgroundTaskRegistrationGroup.AllTasks()](backgroundtaskregistrationgroup_alltasks.md)

## -see-also

## -examples

