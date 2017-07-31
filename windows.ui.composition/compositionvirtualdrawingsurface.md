---
-api-id: T:Windows.UI.Composition.CompositionVirtualDrawingSurface
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionVirtualDrawingSurface : CompositionDrawingSurface, CompositionDrawingSurface
-->

# Windows.UI.Composition.CompositionVirtualDrawingSurface

## -description

Represents sparsely allocated bitmaps that can be associated with visuals for composition in a visual tree.

## -remarks

The virtual drawing surface is designed for use in scenarios where an application needs to define a large amount of content but only expects a small portion of content to be visible to a user at a given time. For example, think of a long scrolling document or webpage. In such cases, the app only needs to draw the part of the surface that is currently visible to the user, and can defer drawing portions that are not visible until later when they become visible.

## -see-also

## -examples

