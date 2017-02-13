---
-api-id: P:Windows.Foundation.IAsyncAction.Completed
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.AsyncActionCompletedHandler Completed { get;  set; }
-->

# Windows.Foundation.IAsyncAction.Completed

## -description
Gets or sets the method that handles the action completed notification.

## -property-value
The method that handles the notification.

## -remarks
The Windows Runtime enforces that this property can only be set once on an action.

Generally, a completed [IAsyncAction](iasyncaction.md) method called using language-specific awaitable syntax does nothing further than to return **null** when it completes.

If you're implementing [IAsyncAction](iasyncaction.md), then the set implementation of [Completed](iasyncaction_completed.md) should store the handler, and the surrounding logic should invoke it when [Close](iasyncinfo_close.md) is called. The implementation should set the *asyncStatus* parameter of invoked callbacks appropriately if there is a [Cancel](iasyncinfo_cancel.md) call, [Status](iasyncinfo_status.md) is not **Completed**, errors occurred, and so on.


<!--Needed- topic on roll-your-own async that covers stuff like that-->

## -examples

## -see-also
[Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)