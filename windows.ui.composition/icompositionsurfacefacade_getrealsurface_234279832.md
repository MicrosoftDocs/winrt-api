---
-api-id: M:Windows.UI.Composition.ICompositionSurfaceFacade.GetRealSurface
-api-type: winrt method
---

# Windows.UI.Composition.ICompositionSurfaceFacade.GetRealSurface

<!--
public Windows.UI.Composition.ICompositionSurface GetRealSurface ();
-->

## -description

Retrieves the `ICompositionSurface` object represented by this façade.

## -returns

The `ICompositionSurface` object represented by this façade.

## -remarks

The real object cannot in turn also be a façade; it must be a real object, or the assignment (or creation) method fails with `E_INVALIDARG`.

## -see-also

[ICompositionSurface](icompositionsurface.md)

## -examples
