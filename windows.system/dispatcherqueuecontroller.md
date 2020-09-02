---
-api-id: T:Windows.System.DispatcherQueueController
-api-type: winrt class
---

<!-- Class syntax.
public class DispatcherQueueController
-->

# Windows.System.DispatcherQueueController

## -description
Manages the lifetime of a [DispatcherQueue](dispatcherqueue.md). Provides methods to create and shutdown the **DispatcherQueue**.

## -remarks
*Object and Thread Lifetime*

**DispatcherQueueController** and its associated **DispatcherQueue** will be kept alive while the event loop is running. When **Shutdown** is completed, the loop is terminated and the dedicated thread will unwind. However,
**DispacherQueueController** and the associated **DispatcherQueue** object can outlive thread’s lifetime and will be disposed when all their references are released.

## -see-also

[CreateDispatcherQueueController](/windows/win32/api/dispatcherqueue/nf-dispatcherqueue-createdispatcherqueuecontroller)


## -examples
