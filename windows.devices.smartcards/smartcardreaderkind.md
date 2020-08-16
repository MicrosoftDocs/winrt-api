---
-api-id: T:Windows.Devices.SmartCards.SmartCardReaderKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SmartCards.SmartCardReaderKind : int
-->

# SmartCardReaderKind

## -description
Represents the smart card reader's type.

## -enum-fields
### -field Any:0
This value is never returned.

This value can be used with [GetDeviceSelector(SmartCardReaderKind)](smartcardreader_getdeviceselector_1037956577.md) to specify no specific smart card reader type in the underlying Advanced Query Syntax (AQS) string.

### -field Generic:1
A generic smart card reader.

### -field Tpm:2
A Trusted Platform Module (TPM) virtual smart card reader.

### -field Nfc:3
A near field communication (NFC) smart card reader.

### -field Uicc:4
A Universal Integrated Circuit Card (UICC) smart card reader.

### -field EmbeddedSE:5
An embedded SE smart card reader.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | EmbeddedSE |

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
