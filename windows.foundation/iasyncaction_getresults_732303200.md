---
-api-id: M:Windows.Foundation.IAsyncAction.GetResults
-api-type: winrt method
---

<!-- Method syntax
public void GetResults()
-->

# Windows.Foundation.IAsyncAction.GetResults

## -description
Returns the results of the action.

## -remarks
The interface definition of this method has a **void** return, and **void** is what methods that use the default [IAsyncAction](iasyncaction.md) behavior will return after completing, when an awaitable syntax is used.

If you want the method to return a result you probably should be using [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) instead. For [IAsyncAction](iasyncaction.md), any added logic should be in the [Completed](iasyncaction_completed.md) implementation, not GetResults.

## -examples

## -see-also
[Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
