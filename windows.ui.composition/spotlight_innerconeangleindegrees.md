---
-api-id: P:Windows.UI.Composition.SpotLight.InnerConeAngleInDegrees
-api-type: winrt property
---

<!-- Property syntax
public float InnerConeAngleInDegrees { get;  set; }
-->

# Windows.UI.Composition.SpotLight.InnerConeAngleInDegrees

## -description
The SpotLight’s inner cone angle, expressed as a semi-vertical angle in degrees. Animatable.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Composition.SpotLight.InnerConeAngleInDegrees](/windows/winui/api/microsoft.ui.composition.spotlight.innerconeangleindegrees) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The SpotLight’s inner cone angle, expressed as a semi-vertical angle in degrees.

## -remarks

    **InnerConeAngleInDegrees**
   is not bound to [OuterConeAngleInDegrees](spotlight_outerconeangleindegrees.md) and can be greater than [OuterConeAngleInDegrees](spotlight_outerconeangleindegrees.md).

## -examples
```csharp

_spotLight.InnerConeAngleInDegrees = 30; 
         
```



## -see-also
