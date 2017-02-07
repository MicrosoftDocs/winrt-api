---
-api-id: T:Windows.ApplicationModel.Background.ApplicationTriggerResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Background.ApplicationTriggerResult : int
-->

# ApplicationTriggerResult

## -description
The result of the request to trigger a background task. The [RequestAsync](applicationtrigger_requestasync_1234533424.md) method returns a value of this enumeration type.

## -enum-fields
### -field Allowed:0
The trigger has been set. The task will run, unless an exception is thrown in the background infrastructure.

### -field CurrentlyRunning:1
The system denied triggering the background task because it is currently running.

### -field DisabledByPolicy:2
A system policy doesn't allow this background task to be triggered.

### -field UnknownError:3
The background task cannot be triggered because of an unknown issue.


## -remarks

## -examples

## -see-also