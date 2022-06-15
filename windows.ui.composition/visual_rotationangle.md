---
-api-id: P:Windows.UI.Composition.Visual.RotationAngle
-api-type: winrt property
---

<!-- Property syntax
public float RotationAngle { get;  set; }
-->

# Windows.UI.Composition.Visual.RotationAngle

## -description

The rotation angle in radians of the visual. Animatable.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Composition.Visual.RotationAngle](/windows/winui/api/microsoft.ui.composition.visual.rotationangle) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The rotation angle in radians of the visual.

## -remarks

To use degrees instead of radians use [RotationAngleInDegrees](visual_rotationangleindegrees.md).

[Visual](visual.md) supports two forms of rotation, by axis-angle, and by orientation.

This property can be animated. Call [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) to associate it with a [CompositionAnimation](/windows/uwp/composition/composition-animation).

## -examples

## -see-also
