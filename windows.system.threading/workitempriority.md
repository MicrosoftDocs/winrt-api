---
-api-id: T:Windows.System.Threading.WorkItemPriority
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.Threading.WorkItemPriority : int
-->

# WorkItemPriority

## -description
Specifies the priority of a work item relative to other work items in the thread pool.

## -enum-fields
### -field Low:-1
The work item should run at low priority.

### -field Normal:0
The work item should run at normal priority. This is the default value.

### -field High:1
The work item should run at high priority.


## -remarks

## -examples

## -see-also
[ThreadPool.RunAsync](threadpool_runasync.md)