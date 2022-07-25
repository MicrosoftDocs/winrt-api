---
-api-id: P:Windows.UI.Composition.SpotLight.InnerConeAngle
-api-type: winrt property
---

<!-- Property syntax
public float InnerConeAngle { get;  set; }
-->

# Windows.UI.Composition.SpotLight.InnerConeAngle

## -description
The SpotLight’s inner cone angle, expressed as a semi-vertical angle in radians. Animatable.



## -property-value
The SpotLight’s inner cone angle, expressed as a semi-vertical angle in radians.

## -remarks

    **InnerConeAngle**
   is not bound to [OuterConeAngle](spotlight_outerconeangle.md) and can be greater than [OuterConeAngle](spotlight_outerconeangle.md).

## -examples
```csharp

_spotLight.InnerConeAngle = (float)(Math.PI/3); 
         
```



## -see-also
