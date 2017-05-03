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

## -see-also

## -examples

