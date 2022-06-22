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

`CompositionVirtualDrawingSurface` is similar to [CompositionDrawingSurface](compositiondrawingsurface.md), except the surface is sparsely allocated. The content can be rendered using [Win2D](https://github.com/Microsoft/Win2D) (or D2D).

The virtual drawing surface is designed for use in scenarios where an application needs to define a large amount of content but only expects a small portion of content to be visible to a user at a given time. For example, think of a long scrolling document or webpage. In such cases, the app only needs to draw the part of the surface that is currently visible to the user, and can defer drawing portions that are not visible until later when they become visible.

The maximum size of a virtual surface is 2^24(16M) pixels. This limit has been imposed because of floating point precision limits, that come into play beyond that size, which prevents guaranteed accurate pixel alignment of drawn patches.

## -see-also

## -examples

