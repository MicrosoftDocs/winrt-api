---
-api-id: T:Windows.UI.Core.CoreDispatcherPriority
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Core.CoreDispatcherPriority : int
-->

# CoreDispatcherPriority

## -description
Defines the priority for window event dispatches.

## -enum-fields
### -field Idle:-2
Lowest priority. Use this priority for background tasks. Delegates are processed when the window's main thread is idle and there is no input pending in the queue.

### -field Low:-1
Low priority. Delegates are processed if there are no higher priority events pending in the queue.

### -field Normal:0
Normal priority. Delegates are processed in the order they are scheduled.

### -field High:1
High priority. Delegates are invoked immediately for all synchronous requests. Asynchronous requests are queued and processed before any other request type.

> [!NOTE]
> Do not use this priority level in your app. It is reserved for system events. Using this priority can lead to the starvation of other messages, including system events.


## -remarks

## -examples

## -see-also