---
-api-id: P:Windows.Media.Effects.IBasicVideoEffect.SupportedMemoryTypes
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Effects.MediaMemoryTypes SupportedMemoryTypes { get; }
-->

# Windows.Media.Effects.IBasicVideoEffect.SupportedMemoryTypes

## -description
Gets a value that indicates whether the custom video effect supports the use of GPU memory or CPU memory.

## -property-value
A value that indicates the custom video effect's supported memory types.

## -remarks
If you specify [MediaMemoryTypes.GpuAndCpu](mediamemorytypes.md) when setting the memory type for your effect, the system will use either GPU or system memory, whichever is more efficient for the pipeline. When using this value, you must check in the [ProcessFrame](ibasicvideoeffect_processframe.md) method to see whether the [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) or [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md) passed into the method contains data and then process the frame accordingly.

## -examples

## -see-also
