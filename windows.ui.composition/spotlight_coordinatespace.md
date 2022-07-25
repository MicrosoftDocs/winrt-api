---
-api-id: P:Windows.UI.Composition.SpotLight.CoordinateSpace
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.Visual CoordinateSpace { get;  set; }
-->

# Windows.UI.Composition.SpotLight.CoordinateSpace

## -description
The Visual used to determine the light's direction and offset. The light's offset and direction properties are relative to this Visual's coordinate space.
    **SpotLight.CoordinateSpace**
   is a required property. If 
    **SpotLight.CoordinateSpace**
   is not set, the SpotLight will not render.



## -property-value
The visual the light's offset is relative to.

## -remarks
[SpotLight.Offset](spotlight_offset.md) and[ SpotLight.Direction](spotlight_direction.md) are relative to 
    **Spotlight.CoordiateSpace**
  . Every Visual has an implicit 3D coordinate space, defined in this way:

<img src="images/coordinatespace.png" alt="X-axis runs from the left edge to the right edge of the visual.  Y-axis runs from the top of the visual to the bottom.  Z-axis is perpandicular to the visual." />

X direction is from left to right. Y direction is from top to bottom. Z direction is pointing out of the plane. The original point of this coordinate is the upper-left corner of the visual, and the unit is DIP. A light’s offset and direction are defined in this coordinate.

## -examples
```csharp

_spotLight.CoordinateSpace = root;  
        
```



## -see-also
[Direction](spotlight_direction.md), [Offset](spotlight_offset.md)
