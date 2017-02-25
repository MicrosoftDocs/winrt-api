---
-api-id: P:Windows.Graphics.Holographic.HolographicSpace.IsSupported
-api-type: winrt property
---

<!-- Property syntax.
public bool IsSupported { get; }
-->

# Windows.Graphics.Holographic.HolographicSpace.IsSupported

## -description
Gets whether the current system supports Mixed Reality headsets.

## -property-value
Whether headsets are supported.

## -remarks
On Desktop PCs running 64-bit Windows, this is always true.  If [IsAvailable](holographicspace_isavailable.md) is false because the user has not yet set up their holographic headset, calling [CreateForCoreWindow](holographicspace_createforcorewindow_1849825339.md) anyway will guide them through the setup flow.

On HoloLens, this is always true.

On any other system, including Desktop PCs running 32-bit Windows, this is false, as Mixed Reality headsets are not supported on those systems.

## -see-also

## -examples

