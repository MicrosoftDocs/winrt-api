---
-api-id: M:Windows.UI.Composition.DelegatedInkTrailVisual.CreateForSwapChain(Windows.UI.Composition.Compositor,Windows.UI.Composition.ICompositionSurface)
-api-type: winrt method
---

# Windows.UI.Composition.DelegatedInkTrailVisual.CreateForSwapChain(Windows.UI.Composition.Compositor,Windows.UI.Composition.ICompositionSurface)

<!--
public static Windows.UI.Composition.DelegatedInkTrailVisual CreateForSwapChain (Windows.UI.Composition.Compositor compositor, Windows.UI.Composition.ICompositionSurface swapChain);
-->

## -description

Creates the [DelegatedInkTrailVisual](delegatedinktrailvisual.md) for rendering "wet" ink to a swap chain.

## -parameters

### -param compositor

A factory that creates a variety of types in the Windows.UI.Composition namespace, including visuals, the effects system, and the animation system.

### -param swapChain

The hosting surface for the "wet" ink object.

## -returns

The "wet" ink stroke.

## -remarks

## -see-also

[Create(Windows.UI.Composition.Compositor)](delegatedinktrailvisual_create_996921895.md), [Swap chains](/windows/win32/direct3d12/swap-chains)

## -examples
