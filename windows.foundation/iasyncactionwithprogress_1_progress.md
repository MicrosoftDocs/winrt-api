---
-api-id: P:Windows.Foundation.IAsyncActionWithProgress`1.Progress
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.AsyncActionProgressHandler<TProgress> Progress { get;  set; }
-->

# Windows.Foundation.IAsyncActionWithProgress<TProgress>.Progress

## -description
Gets or sets the callback method that receives progress notification.

## -property-value
A reference to the callback method that handles progress notifications. Implement the [AsyncActionProgressHandler(TProgress)](asyncactionprogresshandler_1.md) delegate to define your callback. *TProgress* defines the progress unit type, which varies by method implementation.

## -remarks

## -examples
For example [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/) code illustrating how to handle the **Progress** event, see [Delegate types for asynchronous actions and operations](/windows/uwp/cpp-and-winrt-apis/handle-events#delegate-types-for-asynchronous-actions-and-operations).

## -see-also
[IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md), [AsyncActionProgressHandler(TProgress)](asyncactionprogresshandler_1.md)