---
-api-id: T:Windows.Graphics.Holographic.HolographicReprojectionMode
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum HolographicReprojectionMode : int 
-->

# Windows.Graphics.Holographic.HolographicReprojectionMode

## -description
Represents the kind of reprojection an app is requesting to stabilize its holographic rendering relative to the user's head motion.

## -enum-fields
### -field PositionAndOrientation:0
The image should be stabilized for changes to both the user's head position and orientation.  This is best for world-locked content that should remain physically stationary as the user walks around.

### -field OrientationOnly:1
The image should be stabilized only for changes to both the user's head orientation, ignoring positional changes.  This is best for body-locked content that should tag along with the user as they walk around, such as 360-degree video.

### -field Disabled:2
The image should not be stabilized for the user's head motion, instead remaining fixed in the display.  This is generally discouraged, as it is only comfortable for users when used sparingly, such as when the only visible content is a small cursor.

## -remarks

## -see-also

## -examples

