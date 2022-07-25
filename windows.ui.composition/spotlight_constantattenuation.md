---
-api-id: P:Windows.UI.Composition.SpotLight.ConstantAttenuation
-api-type: winrt property
---

<!-- Property syntax
public float ConstantAttenuation { get;  set; }
-->

# Windows.UI.Composition.SpotLight.ConstantAttenuation

## -description
The constant coefficient in the light's attenuation equation. Controls light intensity. Animatable.



## -property-value
The constant coefficient in the light's attenuation equation. Controls light intensity. Range is from 0 to infinity.

## -remarks
The SpotLight.ConstantAttenuation property is part of the attenuation equation which also includes SpotLight.LinearAttenuation and SpotLight.QuadraticAttenuation:

<img src="images/attenuationequation.png" alt="1/(Constant+Linear*(Distance/100)+Quadratic*(Distance/100)*(Distance/100))" />

## -examples
```csharp

_spotLight.ConstantAttenuation =1; 
         
```



## -see-also
[LinearAttenuation](spotlight_linearattenuation.md), [QuadraticAttenuation](spotlight_quadraticattenuation.md)
