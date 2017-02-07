---
-api-id: T:Windows.System.Threading.WorkItemOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.Threading.WorkItemOptions : uint
-->

# WorkItemOptions

## -description
Specifies how work items should be run.

## -enum-fields
### -field None:0
The work item should be run when the thread pool has an available worker thread.

### -field TimeSliced:1
The work items should be run simultaneously with other work items sharing a processor.


## -remarks

## -examples

## -see-also
[ThreadPool.RunAsync](threadpool_runasync.md)