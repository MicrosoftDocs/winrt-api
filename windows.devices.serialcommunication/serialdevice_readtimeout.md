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

The span of time before a time-out occurs when a read operation does not finish.

> [!NOTE]
> The Windows Runtime APIs for serial devices thinly wrap the functionality of the corresponding Win32 APIs. So the meanings of the timeout values of the Win32 APIs also apply to **SerialDevice.ReadTimeout**. For specifics, including the meaning of the special value zero (0), see the [SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts) structure, and [Setting read and write timeouts for a serial device](/previous-versions/ff547486(v=vs.85)). Also see the **Remarks** section of this topic.

## -remarks

[SERIAL_TIMEOUTS::ReadIntervalTimeout](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts) is the only *Read\** value from the underlying Win32 APIs that is used by this Windows Runtime API. *ReadTotalTimeoutMultiplier* and *ReadTotalTimeoutConstant* are not used (they're always set to 0).

- If *ReadIntervalTimeout* is 0, then there's no maximum interval between consecutive bytes in read operations. That is, read operations never time out.
- If *ReadIntervalTimeout* is set to **MAXULONG**, then a read request completes immediately with the bytes that have already been received, even if no bytes have been received.
- If *ReadIntervalTimeout* is less than **MAXULONG**, and greater than 0, then a read operation times out only if the interval between a pair of consecutively received bytes exceeds **ReadIntervalTimeout**.

## -examples

## -see-also
[SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts), [Setting read and write timeouts for a serial device](/previous-versions/ff547486(v=vs.85)).