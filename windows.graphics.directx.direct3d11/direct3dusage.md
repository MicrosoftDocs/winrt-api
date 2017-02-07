---
-api-id: T:Windows.Graphics.DirectX.Direct3D11.Direct3DUsage
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.DirectX.Direct3D11.Direct3DUsage : int
-->

# Direct3DUsage

## -description
A Windows Runtime projection of the [D3D11_USAGE](http://msdn.microsoft.com/library/251d462e-964e-42db-8554-dba8f5a9b1ef) enumeration. Identifies expected resource use during rendering. The usage directly reflects whether a resource is accessible by the CPU and/or the graphics processing unit (GPU).

## -enum-fields
### -field Default:0
A resource that requires read and write access by the GPU.

### -field Immutable:1
A resource that can only be read by the GPU. It cannot be written by the GPU, and cannot be accessed at all by the CPU. This type of resource must be initialized when it is created, since it cannot be changed after creation.

### -field Dynamic:2
A resource that is accessible by both the GPU (read only) and the CPU (write only). A dynamic resource is a good choice for a resource that will be updated by the CPU at least once per frame.

### -field Staging:3
A resource that supports data transfer (copy) from the GPU to the CPU.


## -remarks

## -examples

## -see-also