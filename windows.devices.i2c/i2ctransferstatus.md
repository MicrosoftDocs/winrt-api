---
-api-id: T:Windows.Devices.I2c.I2cTransferStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.I2c.I2cTransferStatus : int
-->

# I2cTransferStatus

## -description
Describes whether the data transfers that the [ReadPartial](i2cdevice_readpartial_589466211.md), [WritePartial](i2cdevice_writepartial_1107922632.md), or [WriteReadPartial](i2cdevice_writereadpartial_776061530.md) method performed succeeded, or provides the reason that the transfers did not succeed.

## -enum-fields
### -field FullTransfer:0
The data was entirely transferred. For [WriteReadPartial](i2cdevice_writereadpartial_776061530.md), the data for both the write and the read operations was entirely transferred.

For this status code, the value of the **I2cTransferResult.BytesTransferred** member that the method returns is the same as the size of the buffer you specified when you called the method, or is equal to the sum of the sizes of two buffers that you specified for [WriteReadPartial](i2cdevice_writereadpartial_776061530.md).

### -field PartialTransfer:1
The I<sup>2</sup> C device negatively acknowledged the data transfer before all of the data was transferred.

For this status code, the value of the **I2cTransferResult.BytesTransferred** member that the method returns is the number of bytes actually transferred. For [WriteReadPartial](i2cdevice_writereadpartial_776061530.md), the value is the sum of the number of bytes that the operation wrote and the number of bytes that the operation read.

### -field SlaveAddressNotAcknowledged:2
The bus address was not acknowledged.

For this status code, the value of the **I2cTransferResult.BytesTransferred** member that the method returns of the method is 0.

### -field ClockStretchTimeout:3
The transfer failed due to the clock being stretched for too long. Ensure the clock line is not being held low.

### -field UnknownError:4
The transfer failed for an unknown reason.

## -remarks

## -examples

## -see-also
[ReadPartial](i2cdevice_readpartial_589466211.md), [WritePartial](i2cdevice_writepartial_1107922632.md), [WriteReadPartial](i2cdevice_writereadpartial_776061530.md), [I2cTransferResult](i2ctransferresult.md)

