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
The span of time before a time-out occurs when a write operation does not finish.

> [!NOTE]
> The Windows Runtime APIs for serial devices thinly wrap the functionality of the corresponding Win32 APIs. So the meanings of the timeout values of the Win32 APIs also apply to **SerialDevice.WriteTimeout**. For specifics, including the meaning of the special value zero (0), see the [SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts) structure, and [Setting read and write timeouts for a serial device](/previous-versions/ff547486(v=vs.85)). Also see the **Remarks** section of this topic.

## -remarks

[SERIAL_TIMEOUTS::WriteTotalTimeoutConstant](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts) is the only *Write\** value from the underlying Win32 APIs that is used by this Windows Runtime API. *WriteTotalTimeoutMultiplier* is not used (it's always set to 0).

- If *WriteTotalTimeoutConstant* is 0, then write operations never time out.
- If *WriteTotalTimeoutConstant* is greater than 0, then a write operation (to send the entire payload) times out if it exceeds *WriteTotalTimeoutConstant*.
- **MAXULONG** has no special meaning for *WriteTotalTimeoutConstant*.

## -examples

## -see-also
[SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts), [Setting read and write timeouts for a serial device](/previous-versions/ff547486(v=vs.85)).
