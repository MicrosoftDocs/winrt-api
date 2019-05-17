---
-api-id: T:Windows.System.ProcessorArchitecture
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax
public enum Windows.System.ProcessorArchitecture : int
-->

# ProcessorArchitecture

## -description
Specifies the processor architecture supported by an app.

## -enum-fields
### -field X86:0
The x86 processor architecture.

### -field Arm:5
The ARM processor architecture.

### -field X64:9
The x64 processor architecture.

### -field Neutral:11
A neutral processor architecture.

### -field Unknown:65535
An unknown processor architecture.

### -field Arm64:12
The Arm64 processor architecture

### -field X86OnArm64:14
The Arm64 processor architecture emulating the X86 architecture

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | Arm64 |
| 1903 | 18362 | X86OnArm64 |

## -examples

## -see-also
[Windows.ApplicationModel.PackageId.Architecture](../windows.applicationmodel/packageid_architecture.md)

