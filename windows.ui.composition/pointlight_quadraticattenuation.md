---
-api-id: P:Windows.UI.Composition.PointLight.QuadraticAttenuation
-api-type: winrt property
---

<!-- Property syntax
public float QuadraticAttenuation { get;  set; }
-->

# Windows.UI.Composition.PointLight.QuadraticAttenuation

## -description
The quadratic portion of the attenuation equation that determines how the light falls off with distance.



## -property-value
The quadratic portion of the attenuation equation that determines how the light falls off with distance. Controls light intensity falloff based on distance squared. Range is from 0 to infinity.

## -remarks
The 
    **PointLight.QuadraticAttenuation**
   property is part of the attenuation equation which also includes [PointLight.LinearAttenuation](pointlight_linearattenuation.md) and [PointLight.ConstantAttenuation](pointlight_constantattenuation.md):

<img src="images/attenuationequation.png" alt="1/(Constant+Linear*(Distance/100)+Quadratic*(Distance/100)*(Distance/100))" />

## -examples
```csharp

_pointLight.QuadraticAttenuation = .0007F; 
         
```



## -see-also
[LinearAttenuation](pointlight_linearattenuation.md), [ConstantAttenuation](pointlight_constantattenuation.md)
