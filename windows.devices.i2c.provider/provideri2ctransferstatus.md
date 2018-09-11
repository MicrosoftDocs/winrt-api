---
-api-id: T:Windows.Devices.I2c.Provider.ProviderI2cTransferStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.I2c.Provider.ProviderI2cTransferStatus : int
-->

# ProviderI2cTransferStatus

## -description
Describes whether the data transfers that the [ReadPartial](ii2cdeviceprovider_readpartial_589466211.md), [WritePartial](ii2cdeviceprovider_writepartial_1107922632.md), or [WriteReadPartial](ii2cdeviceprovider_writereadpartial_776061530.md) method performed succeeded, or provides the reason that the transfers did not succeed.

## -enum-fields
### -field FullTransfer:0
The data was entirely transferred. For [WriteReadPartial](ii2cdeviceprovider_writereadpartial_776061530.md), the data for both the write and the read operations was entirely transferred.

For this status code, the value of the **ProviderI2cTransferResult.BytesTransferred** member that the method returns is the same as the size of the buffer you specified when you called the method, or is equal to the sum of the sizes of two buffers that you specified for [WriteReadPartial](ii2cdeviceprovider_writereadpartial_776061530.md).

### -field PartialTransfer:1
The I<sup>2</sup> C device negatively acknowledged the data transfer before all of the data was transferred.

For this status code, the value of the **ProviderI2cTransferResult.BytesTransferred** member that the method returns is the number of bytes actually transferred. For [WriteReadPartial](ii2cdeviceprovider_writereadpartial_776061530.md), the value is the sum of the number of bytes that the operation wrote and the number of bytes that the operation read.

### -field SlaveAddressNotAcknowledged:2
The bus address was not acknowledged.

For this status code, the value of the **ProviderI2cTransferResult.BytesTransferred** member that the method returns of the method is 0.


## -remarks

## -examples

## -see-also