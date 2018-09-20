---
-api-id: T:Windows.Foundation.AsyncOperationWithProgressCompletedHandler`2
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void AsyncOperationWithProgressCompletedHandler<TResult, TProgress>(Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress> asyncInfo, Windows.Foundation.AsyncStatus asyncStatus)
-->
# Windows.Foundation.AsyncOperationWithProgressCompletedHandler<TResult, TProgress>

## -description
Represents a method that handles the completed event of an asynchronous operation that provides progress updates.

## -parameters
### -param asyncInfo
The asynchronous operation.

### -param asyncStatus
One of the enumeration values.


## -remarks

## -examples
For example [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/) code illustrating how to handle the **Completed** event, see [Delegate types for asynchronous actions and operations](/windows/uwp/cpp-and-winrt-apis/handle-events#delegate-types-for-asynchronous-actions-and-operations).

## -see-also