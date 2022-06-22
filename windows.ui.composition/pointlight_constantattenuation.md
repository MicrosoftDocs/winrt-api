---
-api-id: P:Windows.UI.Composition.PointLight.ConstantAttenuation
-api-type: winrt property
---

<!-- Property syntax
public float ConstantAttenuation { get;  set; }
-->

# Windows.UI.Composition.PointLight.ConstantAttenuation

## -description
The constant coefficient in the light's attenuation equation. Controls light intensity.



## -property-value
The constant coefficient in the light's attenuation equation. Controls light intensity. Range is from 0 to infinity.

## -remarks
The PointLight.ConstantAttenuation property is part of the attenuation equation which also includes PointLight.LinearAttenuation and PointLight.QuadraticAttenuation:

<img src="images/attenuationequation.png" alt="1/(Constant+Linear*(Distance/100)+Quadratic*(Distance/100)(Distance/100))" />

## -examples
```csharp

_pointLight.ConstantAttenuation =1; 
         
```



## -see-also
[LinearAttenuation](pointlight_linearattenuation.md), [QuadraticAttenuation](pointlight_quadraticattenuation.md)
