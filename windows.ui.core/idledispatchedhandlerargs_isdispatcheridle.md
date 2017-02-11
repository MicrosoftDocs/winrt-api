---
-api-id: P:Windows.UI.Core.IdleDispatchedHandlerArgs.IsDispatcherIdle
-api-type: winrt property
---

<!-- Property syntax
public bool IsDispatcherIdle { get; }
-->

# Windows.UI.Core.IdleDispatchedHandlerArgs.IsDispatcherIdle

## -description
Gets a value that indicates whether the event dispatcher's message queue is empty or not.

## -property-value
**true** if the event dispatcher's message queue is empty; **false** if it is not.

## -remarks
> [!NOTE]
> This property must be handled within the code for the event handler. This data becomes stale quickly and cannot be stored or used outside of the handler. If you access this property outside of the [IdleDispatchedHandler](idledispatchedhandler.md) invoked by the call to [CoreDispatcher::RunAsync](coredispatcher_runasync.md), your call to [IsDispatcherIdle](idledispatchedhandlerargs_isdispatcheridle.md) will fail.

When a work item is scheduled with the [CoreDispatcher::RunAsync](coredispatcher_runasync.md) method, the item performs any processing only when there are no message pending in the event queue. However, if the [IdleDispatchedHandler](idledispatchedhandler.md) delegate returned by the callback has the [IsDispatcherIdle](idledispatchedhandlerargs_isdispatcheridle.md) property set to **false**, the work item immediately exits background processing until the event queue is empty again.

## -examples

## -see-also
