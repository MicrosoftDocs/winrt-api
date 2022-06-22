---
-api-id: P:Windows.UI.Composition.SpotLight.LinearAttenuation
-api-type: winrt property
---

<!-- Property syntax
public float LinearAttenuation { get;  set; }
-->

# Windows.UI.Composition.SpotLight.LinearAttenuation

## -description
The linear coefficient in the light's attenuation equation that determines how the light falls off with distance. Animatable.



## -property-value
The linear coefficient in the light's attenuation equation that determines how the light falls off with distance. Range is from 0 to infinity.

## -remarks
The 
    **SpotLight.LinearAttenuation**
   property is part of the attenuation equation which also contains [SpotLight.ConstantAttenuation](spotlight_constantattenuation.md) and [SpotLight.QuadraticAttenuation](spotlight_quadraticattenuation.md):

<img src="images/attenuationequation.png" alt="1/(Constant+Linear*(Distance/100)+Quadratic*(Distance/100)*(Distance/100))" />

## -examples
```csharp

_spotLight.LinearAttenuation = .14F; 
         
```



## -see-also
[ConstantAttenuation](spotlight_constantattenuation.md), [QuadraticAttenuation](spotlight_quadraticattenuation.md)
