---
-api-id: M:Windows.Devices.Gpio.GpioChangeReader.WaitForItemsAsync(System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction GpioChangeReader.WaitForItemsAsync(Int32 count)
-->

# Windows.Devices.Gpio.GpioChangeReader.WaitForItemsAsync

## -description
Waits for the buffer to fill with at least *count* number of items, at which point the async action will complete. This action is cancelable.

## -parameters

### -param count
The number of items with which the buffer must fill before the async operation completes.

## -returns

## -remarks
If the pin or change reader is closed while a wait is in progress, the async operation will be cancelled.

The following exceptions can be thrown by this method:

* E_INVALIDARG - *count* is 0, or *count* is greater than the buffer's capacity.
* HRESULT_FROM_WIN32(ERROR_INVALID_HANDLE) - The change reader was disposed of the associated pin was closed.
* HRESULT_FROM_WIN32(ERROR_OPERATION_ABORTED) - the async operation was canceled.

## -see-also

## -examples

