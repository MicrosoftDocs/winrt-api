---
-api-id: M:Windows.UI.Composition.ICompositionSurfaceFacade.GetRealSurface
-api-type: winrt method
---

# Windows.UI.Composition.ICompositionSurfaceFacade.GetRealSurface

<!--
public Windows.UI.Composition.ICompositionSurface GetRealSurface ();
-->

## -description

Retrieves the real `CompositionSurface` object from the façade.

## -returns

The real `CompositionSurface` object from the façade.

## -remarks

The real object cannot in turn also be a façade; it must be a real object, or the assignment (or creation) method fails with E_INVALIDARG.

## -see-also

## -examples


