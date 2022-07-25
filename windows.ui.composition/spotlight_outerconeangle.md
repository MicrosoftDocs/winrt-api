---
-api-id: P:Windows.UI.Composition.SpotLight.OuterConeAngle
-api-type: winrt property
---

<!-- Property syntax
public float OuterConeAngle { get;  set; }
-->

# Windows.UI.Composition.SpotLight.OuterConeAngle

## -description
The SpotLight’s outer cone angle, expressed as a semi-vertical angle in radians. Animatable.



## -property-value
The SpotLight’s outer cone angle, expressed as a semi-vertical angle in radians. The value must be between 0 and pi.

## -remarks
Light emitted from a spotlight is made up of a bright inner cone and a larger outer cone, with the light intensity diminishing between the two.


    **OuterConeAngle**
   is not bound to 
    **InnerConeAngle**
   parameters.

## -examples
```csharp

_spotLight.OuterConeAngle = (float)(Math.PI/2); 
         
```



## -see-also
