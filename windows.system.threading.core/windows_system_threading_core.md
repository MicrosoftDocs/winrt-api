---
-api-id: N:Windows.System.Threading.Core
-api-type: winrt namespace
---

# Windows.System.Threading.Core

## -description
Creates work items that run in response to named events and semaphores. Also preallocates resources for work items that must be guaranteed the ability to run, even in circumstances of heavy (or full) resource allocation.

> [!NOTE]
> The ThreadPool API is supported for desktop as well as UWP apps.

[PreallocatedWorkItem](preallocatedworkitem.md)When work items are created using [ThreadPool](../windows.system.threading/threadpool.md).[RunAsync](../windows.system.threading/threadpool_runasync_514988780.md), the work item is created and submitted as a single operation. This is acceptable for most scenarios, but it is sometimes necessary to set aside resources for a work item in advance.

The [PreallocatedWorkItem](preallocatedworkitem.md) class constructs a work item ahead of time, putting the work item "on standby" so that it can be submitted to the thread pool when it's needed. This is useful in circumstances where the resources available to your app are completely allocated before the work item is needed - for example, calling a deallocation routine that uses a work item. If a work item has already been allocated, the resource deallocation routine can still be called and the [PreallocatedWorkItem](preallocatedworkitem.md) can still be submitted to the thread pool even if all resources are already in use. Sometimes it is necessary to queue work items in response to named events or semaphores created by Win32 COM objects. You can run a Windows Runtime method in response to a named event or semaphore using a [SignalNotifier](signalnotifier.md) object. This allows you to write Windows Runtime code that responds to events and signals sent using [Win32 and COM for ](/uwp/win32-and-com/win32-and-com-for-uwp-apps), provided that the event or semaphore has a name. For example, the [SignalNotifier](signalnotifier.md) can be used to work with Win32 code that's being ported to a UWP app. [ISignalableNotifier](/uwp/api/Windows.System.Threading.Core)Occasionally it is not possible to know the name of an event or semaphore, but your app still needs to respond to it; for example legacy code, and some well-known events and semaphores, still use waitable handles instead of names. [ISignalableNotifier](/uwp/api/Windows.System.Threading.Core) allows you to create [ISignalNotifier](/uwp/api/Windows.System.Threading.Core) objects registered with waitable handles.
<!--Note: In the future, create content describing how to use the three step process for responding to un-named events and semaphores.-->
> [!NOTE]
> Preallocated work items are only needed for apps that may use up all available resources, or that need to create work items for resource deallocation routines. Signal notifiers are only applicable to certain apps that use [Win32 and COM for ](/uwp/win32-and-com/win32-and-com-for-uwp-apps). If you don't need to use preallocation or signaling in your app, create work items by using [Windows.System.Threading](../windows.system.threading/windows_system_threading.md).


<!--Insert link here to Threading.Core sample when it exists-->

## -remarks

## -examples

## -see-also
