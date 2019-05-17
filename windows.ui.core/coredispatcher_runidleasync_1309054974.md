---
-api-id: M:Windows.UI.Core.CoreDispatcher.RunIdleAsync(Windows.UI.Core.IdleDispatchedHandler)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RunIdleAsync(Windows.UI.Core.IdleDispatchedHandler agileCallback)
-->

# Windows.UI.Core.CoreDispatcher.RunIdleAsync

## -description
Schedules a callback on the UI thread from a worker thread at idle priority, and returns the results asynchronously.

## -parameters
### -param agileCallback
The callback on which the idle priority dispatcher returns when the event is dispatched.

## -returns
Object that contains the results of the asynchronous action.

## -remarks
The RunIdleAsync method is very similar to [CoreDispatcher.RunAsync](coredispatcher_runasync_447339746.md), except that it always schedules the work item at [CoreDispatcherPriority.Low](coredispatcherpriority.md) priority. When you schedule a work item by calling RunIdleAsync from a worker thread, the work item is processed only when there are no event messages pending in the queue. This allows your app to perform tasks such as spell check or other discrete processing while the system is idle. If the [IdleDispatchedHandler](idledispatchedhandler.md) delegate returned by the callback has the [IsDispatcherIdle](idledispatchedhandlerargs_isdispatcheridle.md) property set to **false**, the work item immediately exits background processing until the event queue is empty again.

However, while your app is processing a background task, it can continue processing as long as there are no event messages pending in the [CoreDispatcher](coredispatcher.md) event message queue. If your app receives an event message in the queue, then it must break out of the background processing. To determine when your app must exit background processing, access the [IsDispatcherIdle](idledispatchedhandlerargs_isdispatcheridle.md) property on the [IdleDispatchedHandlerArgs](idledispatchedhandlerargs.md) object returned by the [IdleDispatchedHandler](idledispatchedhandler.md) callback you provided to RunIdleAsync. If there is a message, exit background processing and set the priority to [CoreDispatcherPriority.Normal](coredispatcherpriority.md). Otherwise, if the callback continues to run without checking the dispatcher status, it could lead to input starvation.

## -examples

## -see-also
[CoreDispatcher.RunAsync](coredispatcher_runasync_447339746.md)
