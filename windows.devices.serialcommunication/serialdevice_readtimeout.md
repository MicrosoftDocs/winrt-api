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
> The Windows Runtime APIs for serial devices thinly wrap the functionality of the corresponding Win32 APIs. So the meanings of the timeout values of the Win32 APIs also apply to **SerialDevice.ReadTimeout**. For specifics, including the meaning of the special value zero (0), see the [SERIAL_TIMEOUTS](/windows-hardware/drivers/ddi/ntddser/ns-ntddser-_serial_timeouts) structure, and [Setting read and write timeouts for a serial device](/previous-versions/ff547486(v=vs.85)).

## -remarks

## -examples

## -see-also
