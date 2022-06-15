---
-api-id: P:Windows.UI.Composition.PointLight.MinAttenuationCutoff
-api-type: winrt property
---

<!-- Property syntax.
public float MinAttenuationCutoff { get;  set; }
-->

# Windows.UI.Composition.PointLight.MinAttenuationCutoff

## -description

Gets or sets the minimum range at which this light is effective.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Composition.PointLight.MinAttenuationCutoff](/windows/winui/api/microsoft.ui.composition.pointlight.minattenuationcutoff) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The minimum range at which this light is effective. The default is 0.0.

## -remarks

If the difference between MinAttenuationCutoff and MaxAttenuationCutoff is 0 or negative, the range is ignored.

## -see-also

## -examples

