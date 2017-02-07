---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapElementCollisionBehavior
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.Maps.MapElementCollisionBehavior : int
-->

# MapElementCollisionBehavior

## -description
Specifies the behavior of a [MapIcon](mapicon.md) when it collides with other map features due to zoom level.

## -enum-fields
### -field Hide:0
Hide the [MapIcon](mapicon.md) when it collides with other map features.

### -field RemainVisible:1
Show the [MapIcon](mapicon.md) at all zoom levels.


## -remarks
**RemainVisible** applies to the [MapIcon](mapicon.md) image only. Text from the map icon may still be hidden at times, even when the map icon's [CollisionBehaviorDesired](mapicon_collisionbehaviordesired.md) property is set to **RemainVisible**.

## -examples

## -see-also