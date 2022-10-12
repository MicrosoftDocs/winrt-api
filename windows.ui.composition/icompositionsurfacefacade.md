---
-api-id: T:Windows.UI.Composition.ICompositionSurfaceFacade
-api-type: winrt interface
---

# Windows.UI.Composition.ICompositionSurfaceFacade

<!--
public interface ICompositionSurfaceFacade
-->

## -description

Represents a placeholder for a composition surface that can be used like a real composition surface.

## -remarks

The surface façade interface lets you create an object that can be assigned to the [Surface](compositionsurfacebrush_surface.md) property of a [CompositionSurfaceBrush](compositionsurfacebrush.md) object, or passed as the _`surface`_ argument to the [Compositor.CreateSurfaceBrush](/uwp/api/windows.ui.composition.compositor.createsurfacebrush) method. An application or framework object that implements this interface must also implement the [ICompositionSurface](icompositionsurface.md) interface, so that it can be assigned to the `Surface` property of a brush.

The `CompositionSurfaceBrush` [queries](/cpp/atl/queryinterface) for `ICompositionSurfaceFacade` and calls the [GetRealSurface](icompositionsurfacefacade_getrealsurface_234279832.md) method only once at property assignment time (which is at creation time, in the case of `CreateSurfaceBrush`) to retrieve the real `ICompositionSurface` object from the façade. The real object cannot in turn also be a façade; it must be a real object, or the assignment (or creation) method fails with `E_INVALIDARG`. The façade and the real surface are then referenced by the brush. In that way, the façade object is kept alive by the visual tree in the same way as a real surface.

## -see-also

[ICompositionSurface](icompositionsurface.md), [CompositionSurfaceBrush.Surface](compositionsurfacebrush_surface.md), [Compositor.CreateSurfaceBrush](/uwp/api/windows.ui.composition.compositor.createsurfacebrush)


## -examples


