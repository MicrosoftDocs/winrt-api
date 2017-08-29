---
-api-id: P:Windows.Graphics.Holographic.HolographicSpace.IsConfigured
-api-type: winrt property
---

<!-- Property syntax.
public bool IsConfigured { get; }
-->

# Windows.Graphics.Holographic.HolographicSpace.IsConfigured

## -description
Gets whether the current system has been configured by the user for Mixed Reality headsets.

## -property-value
Whether headsets are configured by the user.

## -remarks
On Desktop PCs running 64-bit Windows, this is initially false.  Once the user has set up Mixed Reality through the Mixed Reality Portal, this becomes true.  If this is false, but [IsSupported](holographicspace_issupported.md) is true, calling [CreateForCoreWindow](holographicspace_createforcorewindow_1849825339.md) anyway will guide the user through the setup flow.

On HoloLens, this is always true.

On any other system, including Desktop PCs running 32-bit Windows, this is false, as Mixed Reality headsets are not supported on those systems.

## -see-also

## -examples

