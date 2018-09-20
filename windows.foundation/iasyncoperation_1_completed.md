---
-api-id: P:Windows.Foundation.IAsyncOperation`1.Completed
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.AsyncOperationCompletedHandler<TResult> Completed { get;  set; }
-->

# Windows.Foundation.IAsyncOperation<TResult>.Completed

## -description
Gets or sets the method that handles the operation completed notification.

## -property-value
The method that handles the notification.

## -remarks
The Windows Runtime enforces that this property can only be set once on an operation.

Generally, a completed [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) method called using awaitable syntax does nothing further than to return its result (an object of the **TResult** type) when it completes.

If you're implementing [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md), then the set implementation of [Completed](iasyncaction_completed.md) should store the handler, and the surrounding logic should invoke it when [Close](iasyncinfo_close_811482585.md) is called. The implementation should set the *asyncStatus* parameter of invoked callbacks appropriately if there is a [Cancel](iasyncinfo_cancel_1985564044.md) call, [Status](iasyncinfo_status.md) is not **Completed**, errors occurred, and so on.


<!--Needed- topic on roll-your-own async that covers stuff like that-->

## -examples
For example [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/) code illustrating how to handle the **Completed** event, see [Delegate types for asynchronous actions and operations](/windows/uwp/cpp-and-winrt-apis/handle-events#delegate-types-for-asynchronous-actions-and-operations).

## -see-also
[IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md)