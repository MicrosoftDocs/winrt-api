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

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Composition.SpotLight.OuterConeAngle](/windows/winui/api/microsoft.ui.composition.spotlight.outerconeangle) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

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
