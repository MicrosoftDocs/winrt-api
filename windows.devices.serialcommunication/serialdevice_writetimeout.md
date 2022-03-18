---
-api-id: P:Windows.Devices.SerialCommunication.SerialDevice.WriteTimeout
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan WriteTimeout { get;  set; }
-->

# Windows.Devices.SerialCommunication.SerialDevice.WriteTimeout

## -description

Gets or sets the time-out value for a write operation.

## -property-value

The span of time before a time-out occurs when a write operation doesn't finish.

- If **WriteTimeout** is 0, then write operations never time out.
- If **WriteTimeout** is greater than 0, then a write operation (to send the entire payload) times out if it exceeds **WriteTimeout**.
- The value of `TimeSpan.FromMilliseconds(ulong.MaxValue)` (see [TimeSpan](/uwp/api/windows.foundation.timespan)) has no special meaning for **WriteTimeout**.

> [!NOTE]
> The Windows Runtime APIs for serial devices thinly wrap the functionality of the corresponding Win32 APIs. So the meaning of the *WriteTotalTimeoutConstant* member of the Win32 [SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts) structure applies to **SerialDevice.WriteTimeout**. For specifics, see the [SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts) structure, and [Setting read and write timeouts for a serial device](/previous-versions/ff547486(v=vs.85)).

## -examples

## -see-also

[SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts), [Setting read and write timeouts for a serial device](/previous-versions/ff547486(v=vs.85)).
