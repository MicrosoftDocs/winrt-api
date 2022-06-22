---
-api-id: T:Windows.UI.Composition.Compositor
-api-type: winrt class
---

<!-- Class syntax.
public class Compositor : Windows.Foundation.IClosable, Windows.UI.Composition.ICompositor, Windows.UI.Composition.ICompositor2, Windows.UI.Composition.ICompositor3, Windows.UI.Composition.ICompositor4
-->

# Windows.UI.Composition.Compositor

## -description

Manages the session between an application and the system compositor process.

The Compositor class creates an instance of the Compositor for the application that can be used as a factory for a variety of types in the Windows.UI.Composition namespace spanning the visual layer, effects system and animation system. The Compositor class also manages the lifetime of objects created from the factory.



## -remarks

The Compositor implicitly synchronizes changes made to associated visuals to ensure they get applied in a transactional manner.

See the [Composition UI Overview](/windows/uwp/composition/visual-layer) and [Composition Visual Tree Overview](/windows/uwp/composition/composition-visual-tree) for more information.

New instances of Compositor must be created on a thread that has a CoreDispatcher.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | CreateAmbientLight |
| 1607 | 14393 | CreateAnimationGroup |
| 1607 | 14393 | CreateBackdropBrush |
| 1607 | 14393 | CreateDistantLight |
| 1607 | 14393 | CreateDropShadow |
| 1607 | 14393 | CreateImplicitAnimationCollection |
| 1607 | 14393 | CreateLayerVisual |
| 1607 | 14393 | CreateMaskBrush |
| 1607 | 14393 | CreateNineGridBrush |
| 1607 | 14393 | CreatePointLight |
| 1607 | 14393 | CreateSpotLight |
| 1607 | 14393 | CreateStepEasingFunction |
| 1607 | 14393 | CreateStepEasingFunction(Int32) |
| 1703 | 15063 | CreateHostBackdropBrush |
| 1709 | 16299 | CreateColorGradientStop |
| 1709 | 16299 | CreateColorGradientStop(Single,Color) |
| 1709 | 16299 | CreateLinearGradientBrush |
| 1709 | 16299 | CreateSpringScalarAnimation |
| 1709 | 16299 | CreateSpringVector2Animation |
| 1709 | 16299 | CreateSpringVector3Animation |
| 1803 | 17134 | Comment |
| 1803 | 17134 | CreateBounceScalarAnimation |
| 1803 | 17134 | CreateBounceVector2Animation |
| 1803 | 17134 | CreateBounceVector3Animation |
| 1803 | 17134 | CreateContainerShape |
| 1803 | 17134 | CreateEllipseGeometry |
| 1803 | 17134 | CreateLineGeometry |
| 1803 | 17134 | CreatePathGeometry |
| 1803 | 17134 | CreatePathGeometry(CompositionPath) |
| 1803 | 17134 | CreatePathKeyFrameAnimation |
| 1803 | 17134 | CreateRectangleGeometry |
| 1803 | 17134 | CreateRoundedRectangleGeometry |
| 1803 | 17134 | CreateShapeVisual |
| 1803 | 17134 | CreateSpriteShape |
| 1803 | 17134 | CreateSpriteShape(CompositionGeometry) |
| 1803 | 17134 | CreateViewBox |
| 1803 | 17134 | GlobalPlaybackRate |
| 1803 | 17134 | MaxGlobalPlaybackRate |
| 1803 | 17134 | MinGlobalPlaybackRate |
| 1803 | 17134 | RequestCommitAsync |
| 1809 | 17763 | CreateBooleanKeyFrameAnimation |
| 1809 | 17763 | CreateGeometricClip |
| 1809 | 17763 | CreateGeometricClip(CompositionGeometry) |
| 1809 | 17763 | CreateRedirectVisual |
| 1809 | 17763 | CreateRedirectVisual(Visual) |
| 1903 | 18362 | CreateProjectedShadow |
| 1903 | 18362 | CreateProjectedShadowCaster |
| 1903 | 18362 | CreateProjectedShadowReceiver |
| 1903 | 18362 | CreateRadialGradientBrush |
| 1903 | 18362 | CreateVisualSurface |

## -examples

## -see-also

[Composition UI Overview](/windows/uwp/composition/visual-layer), [Composition Visual Tree Overview](/windows/uwp/composition/composition-visual-tree), [IClosable](../windows.foundation/iclosable.md), [Composition visual without framework sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CompositionVisual), [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)
