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
A reference to the callback method that handles progress notifications. Implement the [AsyncOperationProgressHandler&lt;TResult, TProgress&gt;](asyncoperationprogresshandler_2.md) delegate to define your callback. *TProgress* defines the progress unit type, which varies by method implementation.

## -remarks

## -examples

## -see-also
[IAsyncOperationWithProgress&lt;TResult, TProgress&gt;](iasyncoperationwithprogress_2.md)