---
-api-id: T:Windows.ApplicationModel.Store.Preview.StoreSystemFeature
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Store.Preview.StoreSystemFeature : int
-->

# StoreSystemFeature

## -description
Defines values that represent hardware features that can be queried for the current device by using the [FilterUnsupportedSystemFeaturesAsync](storeconfiguration_filterunsupportedsystemfeaturesasync_1497477694.md) method.

## -enum-fields
### -field ArchitectureX86:0
The device chipset uses the x86 CPU architecture.

### -field ArchitectureX64:1
The device chipset uses the x64 CPU architecture.

### -field ArchitectureArm:2
The device chipset uses the ARM CPU architecture.

### -field DirectX9:3
The device supports DirectX9.

### -field DirectX10:4
The device supports DirectX10.

### -field DirectX11:5
The device supports DirectX11.

### -field D3D12HardwareFL11:6
The device supports Direct3D 12 feature level 12.0.

### -field D3D12HardwareFL12:7
The device supports Direct3D 12 feature level 12.1.

### -field Memory300MB:8
The device has 300 MB of RAM.

### -field Memory750MB:9
The device has 750 MB of RAM.

### -field Memory1GB:10
The device has 1 GB of RAM.

### -field Memory2GB:11
The device has 2 GB of RAM.

### -field CameraFront:12
The device has a front-facing camera.

### -field CameraRear:13
The device has a rear-facing camera.

### -field Gyroscope:14
The device has a gyroscope.

### -field Hover:15
The device supports hover touch.

### -field Magnetometer:16
The device has a magnetometer.

### -field Nfc:17
The device includes an NFC device.

### -field Resolution720P:18
The display resolution is 720p.

### -field ResolutionWvga:19
The display resolution is WVGA.

### -field ResolutionWvgaOr720P:20
The display resolution is 720p or WVGA.

### -field ResolutionWxga:21
The display resolution is WXGA

### -field ResolutionWvgaOrWxga:22
The display resolution is WVGA or WXGA.

### -field ResolutionWxgaOr720P:23
The display resolution is WXGA or 720p.

### -field Memory4GB:24
The device has 4 GB of memory.

### -field Memory6GB:25
The device has 6 GB of memory.

### -field Memory8GB:26
The device has 8 GB of memory.

### -field Memory12GB:27
The device has 12 GB of memory.

### -field Memory16GB:28
The device has 16 GB of memory.

### -field Memory20GB:29
The device has 20 GB of memory.

### -field VideoMemory2GB:30
The device has 2 GB of video memory.

### -field VideoMemory4GB:31
The device has4 GB of video memory.

### -field VideoMemory6GB:32
The device has 6 GB of video memory.

### -field VideoMemory1GB:33
The device has 1 GB of video memory.

### -field ArchitectureArm64:34
The device chipset uses the ARM64 CPU architecture.

## -remarks

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | Memory12GB |
| 1607 | 14393 | Memory16GB |
| 1607 | 14393 | Memory20GB |
| 1607 | 14393 | Memory4GB |
| 1607 | 14393 | Memory6GB |
| 1607 | 14393 | Memory8GB |
| 1607 | 14393 | VideoMemory1GB |
| 1607 | 14393 | VideoMemory2GB |
| 1607 | 14393 | VideoMemory4GB |
| 1607 | 14393 | VideoMemory6GB |
| 1803 | 17134 | ArchitectureArm64 |

## -examples

## -see-also
