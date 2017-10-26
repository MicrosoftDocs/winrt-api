---
-api-id: N:Windows.System.Threading
-api-type: winrt namespace
---

# Windows.System.Threading

## -description
Enables an application to use the thread pool to run work items.

The thread pool provides a pool of worker threads that an application can use for work items that can run in parallel. Using the thread pool is simpler and more efficient than creating individual threads, because the thread pool manages thread lifetimes and schedules work items when threads become available.

Work items run asynchronously and can run in any order, so it's best to use the thread pool for work items that don't take a lot of time and don't depend on each other's output. You create a work item by calling the [RunAsync](threadpool_runasync.md) method. The work item is added to the thread pool's queue, where it stays until a thread becomes available. When a thread becomes available, the thread pool calls the work item's associated [WorkItemHandler](workitemhandler.md) delegate and the work item runs.

The thread pool schedules a work item as soon as a thread becomes available, so the item might run immediately. If you want the work item to run after a certain amount of time, use a timer. You create a timer and specify its timeout value by calling the [CreateTimer](threadpooltimer_createtimer.md) method. The timer begins counting down as soon as it is created, so you don't have to start it. When the timer expires, the thread pool calls the timer's [TimerElapsedHandler](timerelapsedhandler.md) delegate.

If you want to run a work item more than once at a regular interval, use the [CreatePeriodicTimer](threadpooltimer_createperiodictimer.md) method to create a periodic timer. A periodic timer is reset every time it expires and stays active until you cancel it.

If you want a work item to wait until an event or semaphore is signaled, or if you want to create a preallocated work item, see [Windows.System.Threading.Core](../windows.system.threading.core/windows_system_threading_core.md).

For example code that demonstrates how to use the thread pool, see the [Thread Pool Sample](http://code.msdn.microsoft.com/windowsapps/Pool-Sample-5aa60454).

> [!NOTE]
> The ThreadPool API is supported for desktop as well as UWP apps.

## -remarks

## -examples

## -see-also