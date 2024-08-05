---
-api-id: T:Windows.Graphics.Printing3D.Printing3DBufferFormat
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Graphics.Printing3D.Printing3DBufferFormat : int
-->

# Printing3DBufferFormat

## -description
Specifies the format used by the buffer.

## -enum-fields
### -field Unknown:0
The format is not known.

### -field R32G32B32A32Float:2
A four-component, 128-bit floating-point format that supports 32 bits per channel including alpha.

### -field R32G32B32A32UInt:3
A four-component, 128-bit unsigned-integer format that supports 32 bits per channel including alpha.

### -field R32G32B32Float:6
A three-component, 96-bit floating-point format that supports 32 bits per color channel.

### -field R32G32B32UInt:7
A three-component, 96-bit unsigned-integer format that supports 32 bits per color channel.

### -field Printing3DDouble:500
A buffer of type **double**.

### -field Printing3DUInt:501
A buffer of type **uint**.


## -remarks
This API is designed for use with 3D Manufacturing Format (3MF) packages. For more info about 3MF, see the [3MF Specification](https://3mf.io/spec/).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | Printing3DDouble |
| 1511 | 10586 | Printing3DUInt |

## -examples

## -see-also
