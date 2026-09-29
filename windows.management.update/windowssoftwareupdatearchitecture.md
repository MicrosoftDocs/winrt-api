---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateArchitecture
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateArchitecture

<!--
public enum WindowsSoftwareUpdateArchitecture
-->


## -description

Defines constants that specify the processor architecture that a [WindowsSoftwareUpdateAppPackageInfo](./windowssoftwareupdateapppackageinfo.md) applies to.

## -enum-fields

### -field Neutral: 0
The package is architecture-neutral and applies to any processor architecture.

### -field X86: 1
The package targets 32-bit x86 processors.

### -field X64: 2
The package targets 64-bit x64 (AMD64) processors.

### -field Arm: 3
The package targets 32-bit ARM processors. This value is not supported on newer platforms.

### -field Arm64: 4
The package targets 64-bit ARM (ARM64) processors.

## -remarks


## -see-also

[WindowsSoftwareUpdateAppPackageInfo](./windowssoftwareupdateapppackageinfo.md)

## -examples

