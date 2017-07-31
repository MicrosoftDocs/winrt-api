---
-api-id: P:Windows.ApplicationModel.Core.CoreApplicationView.DispatcherQueue
-api-type: winrt property
---

<!-- Property syntax.
public DispatcherQueue DispatcherQueue { get; }
-->

# Windows.ApplicationModel.Core.CoreApplicationView.DispatcherQueue

## -description
Gets the **DispatcherQueue** for the window.

## -property-value
A **DispatcherQueue** instance.

## -remarks
The **DispatcherQueue** allows you to run your tasks on the thread associated with the **DispatcherQueue** instance. To make UI changes on a **CoreApplicationView** from a different thread, use the **DispatcherQueue** from that **CoreApplicationView**.

## -see-also

## -examples
