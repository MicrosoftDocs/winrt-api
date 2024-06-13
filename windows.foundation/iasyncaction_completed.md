---
-api-id: P:Windows.Foundation.IAsyncAction.Completed
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.AsyncActionCompletedHandler Completed { get;  set; }
-->

# Windows.Foundation.IAsyncAction.Completed

## -description
Gets or sets the delegate that is called when the action completes.

## -property-value
The delegate that is called when the action completes.

## -remarks
You're not allowed to set the **Completed** property more than once.

Most applications don't use the **Completed** property directly,
but instead use a language-specific syntax for awaiting the completion
of an asynchronous action,
such as `co_await` (C++/WinRT), `await` (C#, Javascript), or `then` (Javascript, C++/CX).

If the **Completed** property is set after the action has already completed,
then the action behaves as if it had completed immediately after the handler was received.
Note that this can result in the handler being called before the **Completed** property setter
has returned; possibly even from the same thread.

<!--Needed- topic on roll-your-own async that covers stuff like that-->

## -examples
For example [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/) code illustrating how to handle the **Completed** event, see [Delegate types for asynchronous actions and operations](/windows/uwp/cpp-and-winrt-apis/handle-events#delegate-types-for-asynchronous-actions-and-operations).

## -see-also
[Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
