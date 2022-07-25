---
-api-id: P:Windows.UI.Composition.SpotLight.Offset
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 Offset { get;  set; }
-->

# Windows.UI.Composition.SpotLight.Offset

## -description
Offset of the light source relative to its [CoordinateSpace](spotlight_coordinatespace.md) Visual. Animatable.



## -property-value
Offset of the light source relative to its coordinate space Visual.

## -remarks

    **SpotLight.Offset**
   is relative to [SpotLight.CoordinateSpace](spotlight_coordinatespace.md).

## -examples
```csharp

_spotLight.Offset = new Vector3(30, 30, 200);  
          
```



## -see-also
[SpotLight.CoordinateSpace](spotlight_coordinatespace.md)
