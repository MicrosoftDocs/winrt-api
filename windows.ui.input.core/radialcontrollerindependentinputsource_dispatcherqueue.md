---
-api-id: P:Windows.UI.Input.Core.RadialControllerIndependentInputSource.DispatcherQueue
-api-type: winrt property
---

<!-- Property syntax.
public DispatcherQueue DispatcherQueue { get; }
-->

# Windows.UI.Input.Core.RadialControllerIndependentInputSource.DispatcherQueue

## -description
Gets the [DispatcherQueue](../windows.system/dispatcherqueue.md) associated with this [RadialControllerIndependentInputSource](radialcontrollerindependentinputsource.md).

## -property-value
The [DispatcherQueue](../windows.system/dispatcherqueue.md) for managing prioritized tasks that execute in a serial fashion on a thread.

## -remarks
Some platform objects require thread affinity for posting events back to the thread where the object was instantiated. The [DispatcherQueue](../windows.system/dispatcherqueue.md) lets you post work to this thread. 

These platform objects can be created on the UI thread, where the [DispatcherQueue](../windows.system/dispatcherqueue.md) already exists, or they can be created on a long running, non-UI thread with a DispatcherQueue created with the [DispatcherQueueController.CreateOnDedicatedThread](../windows.system/dispatcherqueuecontroller_createondedicatedthread_660689653.md) method. 

## -see-also

## -examples

