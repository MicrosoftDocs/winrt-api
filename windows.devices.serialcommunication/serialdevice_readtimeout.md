---
-api-id: P:Windows.Devices.SerialCommunication.SerialDevice.ReadTimeout
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan ReadTimeout { get;  set; }
-->

# Windows.Devices.SerialCommunication.SerialDevice.ReadTimeout

## -description

Gets or sets the time-out value for a read operation.

## -property-value

The span of time before a time-out occurs when a read operation doesn't finish.

- If **ReadTimeout** is 0, then there's no maximum interval between consecutive bytes in read operations. That is, read operations never time out.
- If **ReadTimeout** is set to `TimeSpan.FromMilliseconds(ulong.MaxValue)` (see [TimeSpan](/uwp/api/windows.foundation.timespan)), then a read request completes immediately with the bytes that have already been received, even if no bytes have been received.
- If **ReadTimeout** is less than `TimeSpan.FromMilliseconds(ulong.MaxValue)`, and greater than 0, then a read operation times out only if the interval between a pair of consecutively received bytes exceeds **ReadTimeout**.

> [!NOTE]
> The Windows Runtime APIs for serial devices thinly wrap the functionality of the corresponding Win32 APIs. So the meaning of the *ReadIntervalTimeout* member of the Win32 [SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts) structure applies to **SerialDevice.ReadTimeout**. For specifics, see the [SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts) structure, and [Setting read and write timeouts for a serial device](/previous-versions/ff547486(v=vs.85)).

## -examples

## -see-also

[SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts), [Setting read and write timeouts for a serial device](/previous-versions/ff547486(v=vs.85)).
