---
-api-id: P:Windows.UI.Composition.SpotLight.Direction
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 Direction { get;  set; }
-->

# Windows.UI.Composition.SpotLight.Direction

## -description
The direction in which the light is pointing, specified relative to its CoordinateSpace Visual.



## -property-value
The direction in which the light is pointing, specified relative to its coordinate space Visual.

## -remarks
SpotLight.Direction is relative to [SpotLight.CoordinateSpace](spotlight_coordinatespace.md).

## -examples
```csharp

_spotLight.Direction = new Vector3(4, 10, 0); 
          
```



## -see-also
[SpotLight.CoordinateSpace](spotlight_coordinatespace.md)
