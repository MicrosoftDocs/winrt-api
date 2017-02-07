---
-api-id: T:Windows.Devices.I2c.I2cTransferResult
-api-type: winrt struct
---

<!-- Structure syntax.
public struct I2cTransferResult 
-->

# I2cTransferResult

## -description
Provides information about whether the data transfers that the [ReadPartial](i2cdevice_readpartial.md), [WritePartial](i2cdevice_writepartial.md), or [WriteReadPartial](i2cdevice_writereadpartial.md) method performed succeeded, and the actual number of bytes the method transferred.

## -struct-fields

### -field Status
An enumeration value that indicates if the read or write operation transferred the full number of bytes that the method requested, or the reason that the full transfer did not succeed. For [WriteReadPartial](i2cdevice_writereadpartial.md), the value indicates whether the data for both the write and the read operations was entirely transferred.
    

### -field BytesTransferred
The actual number of bytes that the operation actually transferred. The following table describes what this value represents for each method.

<table>
   <tr><th>Method</th><th>Description</th></tr>
   <tr><td>[ReadPartial](i2cdevice_readpartial.md)</td><td>The actual number of bytes that the read operation read into the buffer. If the value of the **Status** member is **I2CTransferStatus.PartialTransfer**, this value may be less than the number of bytes in the buffer that you specified in the *buffer* parameter.</td></tr>
   <tr><td>[WritePartial](i2cdevice_writepartial.md)</td><td>The actual number of bytes that the write operation transferred to the I<sup>2</sup> C device. If the value of the **Status** member is **I2CTransferStatus.PartialTransfer**, this value may be less than the number of bytes in the buffer that you specified in the *buffer* parameter.</td></tr>
   <tr><td>[WriteReadPartial](i2cdevice_writereadpartial.md)</td><td>The actual number of bytes that the operation transferred, which is the sum of the number of bytes that the operation wrote and the number of bytes that the operation read. If the value of the **Status** member is **I2CTransferStatus.PartialTransfer**, this value may be less than the sum of lengths of the buffers that you specified in the *writeBuffer* and *readBuffer* parameters.</td></tr>
</table>
    

## -remarks

## -examples

## -see-also
[ReadPartial](i2cdevice_readpartial.md), [WritePartial](i2cdevice_writepartial.md), [WriteReadPartial](i2cdevice_writereadpartial.md), [I2cTransferStatus](i2ctransferstatus.md)