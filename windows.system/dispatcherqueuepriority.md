---
-api-id: T:Windows.System.DispatcherQueuePriority
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum DispatcherQueuePriority : int
-->

# Windows.System.DispatcherQueuePriority

## -description
Defines the priority levels that can be given to work assigned to a [DispatcherQueue](dispatcherqueue.md).

## -enum-fields
### -field Normal:0
Work will be dispatched once all **High** priority tasks are dispatched. If a new **High** priority work is scheduled, all new **High** priority tasks are processed before resuming **Normal** tasks. This is the default priority.

### -field Low:-10
**Low** priority work will be scheduled when there isn't any other work to process. Work at **Low** priority can be preempted by new incoming **High** and **Normal** priority tasks.

### -field High:10
Work scheduled at **High** priority will be dispatched first, along with other **High** priority System tasks, before processing **Normal** or **Low** priority work.

## -remarks

## -see-also

## -examples
