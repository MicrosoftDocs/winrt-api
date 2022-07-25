---
-api-id: P:Windows.UI.Composition.SpotLight.QuadraticAttenuation
-api-type: winrt property
---

<!-- Property syntax
public float QuadraticAttenuation { get;  set; }
-->

# Windows.UI.Composition.SpotLight.QuadraticAttenuation

## -description
The quadratic portion of the attenuation equation that determines how the light falls off with distance. Animatable.



## -property-value
The quadratic coefficient in the light's attenuation equation. Controls light intensity falloff based on distance squared. Range is from 0 to infinity.

## -remarks
The SpotLight.QuadraticAttenuation property is part of the attenuation equation which also includes SpotLight.LinearAttenuation and SpotLight.ConstantAttenuation:

<img src="images/attenuationequation.png" alt="1/(Constant+Linear*(Distance/100)+Quadratic*(Distance/100)*(Distance/100))" />

## -examples
```csharp

_spotLight.QuadraticAttenuation = .0007F; 
         
```



## -see-also
[LinearAttenuation](spotlight_linearattenuation.md), QuadraticAttenuation
