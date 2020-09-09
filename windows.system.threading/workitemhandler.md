---
-api-id: T:Windows.System.Threading.WorkItemHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void WorkItemHandler(Windows.Foundation.IAsyncAction operation)
-->
# Windows.System.Threading.WorkItemHandler

## -description
Represents a method that is called when a work item runs.

## -parameters
### -param operation
The work item to associate with the callback method.


## -remarks
The thread pool calls a work item's WorkItemHandler delegate when a thread becomes available to run the work item. If a work item is canceled, WorkItemHandler delegates that have not yet started running are not called. WorkItemHandler delegates that are already running are allowed to finish unless the application stops them. If a work item might run for a relatively long time, the application should check if cancellation has been requested and stop the handler in an orderly way.

For an example, see [Submit a work item to the thread pool](/windows/uwp/threading-async/submit-a-work-item-to-the-thread-pool).

## -examples

## -see-also
