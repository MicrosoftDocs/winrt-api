---
-api-id: T:Windows.Graphics.Holographic.HolographicSpaceUserPresence
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum HolographicSpaceUserPresence : int 
-->

# Windows.Graphics.Holographic.HolographicSpaceUserPresence

## -description
Represents whether the user is present within the headset to view and interact with a particular HolographicSpace.

## -enum-fields
### -field Absent:0
This HolographicSpace is not visible in the headset or the user is not wearing the headset.

The app may wish to pause and stop rendering to conserve system resources.

### -field PresentPassive:1
This HolographicSpace is visible in the headset and the user is wearing the headset, but a modal dialog is taking all input from the app.

The app should continue rendering, but may wish to pause its simulation.

### -field PresentActive:2
This HolographicSpace is visible in the headset, the user is wearing the headset, and input is being routed to the app.

The app should render and run its simulation as normal.

## -remarks

## -see-also
[HolographicSpace.UserPresence](holographicspace_userpresence.md)

## -examples

