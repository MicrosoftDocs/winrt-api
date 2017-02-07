---
-api-id: T:Windows.Media.Effects.MediaMemoryTypes
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Effects.MediaMemoryTypes : int
-->

# MediaMemoryTypes

## -description
Specifies the types of memory that can be used for a media operation.

## -enum-fields
### -field Gpu:0
GPU memory.

### -field Cpu:1
CPU memory.

### -field GpuAndCpu:2
Both GPU and CPU memory.


## -remarks
If you specify [MediaMemoryTypes.GpuAndCpu](mediamemorytypes.md) when setting the memory type for your effect, the system will use either GPU or system memory, whichever is more efficient for the pipeline. When using this value, you must check in the [ProcessFrame](ibasicvideoeffect_processframe.md) method to see whether the [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) or [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) passed into the method contains data and then process the frame accordingly.

## -examples

## -see-also