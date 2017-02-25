---
-api-id: E:Windows.Graphics.Holographic.HolographicSpace.IsAvailableChanged
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler IsAvailableChanged<object>
-->

# Windows.Graphics.Holographic.HolographicSpace.IsAvailableChanged

## -description
Occurs when a configured and ready Mixed Reality headset is attached or detached from the system.

## -remarks
On Desktop PCs, this tells an app when a Mixed Reality headset that is configured and ready is either attached to the PC or detached from the PC.  Inspect the [IsAvailable](holographicspace_isavailable.md) property to determine the current state of the system.

On HoloLens, this event will never occur, as holographic rendering is always available.

## -see-also

## -examples

