---
-api-id: P:Windows.Foundation.IAsyncActionWithProgress`1.Completed
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.AsyncActionWithProgressCompletedHandler<TProgress> Completed { get;  set; }
-->

# Windows.Foundation.IAsyncActionWithProgress<TProgress>.Completed

## -description
Gets or sets the method that handles the action completed notification.

## -property-value
The method that handles the notification.

## -remarks
The Windows Runtime enforces that this property can only be set once on an action.

Generally, a completed [IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md) method called using language-specific awaitable syntax does nothing further than to return **null** when it completes.

If you're implementing [IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md), then the set implementation of [Completed](iasyncoperationwithprogress_2_completed.md) should store the handler, and the surrounding logic should invoke it when [Close](iasyncinfo_close_811482585.md) is called. The implementation should set the *asyncStatus* parameter of invoked callbacks appropriately if there is a [Cancel](iasyncinfo_cancel_1985564044.md) call, [Status](iasyncinfo_status.md) is not **Completed**, errors occurred, and so on.


<!--Needed- topic on roll-your-own async that covers stuff like that-->

## -examples
For example [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/) code illustrating how to handle the **Completed** event, see [Delegate types for asynchronous actions and operations](/windows/uwp/cpp-and-winrt-apis/handle-events#delegate-types-for-asynchronous-actions-and-operations).

## -see-also
[IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md)