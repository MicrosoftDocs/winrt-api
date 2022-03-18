---
-api-id: M:Windows.Foundation.IAsyncActionWithProgress`1.GetResults
-api-type: winrt method
---

<!-- Method syntax
public void GetResults()
-->

# Windows.Foundation.IAsyncActionWithProgress<TProgress>.GetResults

## -description
Returns the results of the action.

## -remarks
The interface definition of this method has a **void** return, and **void** is what methods that use the default [IAsyncActionWithProgress<TProgress>](iasyncactionwithprogress_1.md) behavior will return after completing, when a language-specific awaitable syntax is used.

If you want the method to return a result you probably should be using [IAsyncOperationWithProgress<TResult,TProgress>](iasyncoperationwithprogress_2.md) instead. For [IAsyncActionWithProgress<TProgress>](iasyncactionwithprogress_1.md), any added logic should be in the [Completed](iasyncactionwithprogress_1_completed.md) implementation, not GetResults.

## -examples

## -see-also
[IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md)
