---
-api-id: P:Windows.Foundation.IAsyncOperationWithProgress`2.Progress
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.AsyncOperationProgressHandler<TResult, TProgress> Progress { get;  set; }
-->

# Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress>.Progress

## -description
Gets or sets the method that handles progress notifications.

## -property-value
A reference to the callback method that handles progress notifications. Implement the [AsyncOperationProgressHandler<TResult, TProgress>](asyncoperationprogresshandler_2.md) delegate to define your callback. *TProgress* defines the progress unit type, which varies by method implementation.

## -remarks

## -examples
For example [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/) code illustrating how to handle the **Progress** event, see [Delegate types for asynchronous actions and operations](/windows/uwp/cpp-and-winrt-apis/handle-events#delegate-types-for-asynchronous-actions-and-operations).

## -see-also
[IAsyncOperationWithProgress&lt;TResult, TProgress&gt;](iasyncoperationwithprogress_2.md)