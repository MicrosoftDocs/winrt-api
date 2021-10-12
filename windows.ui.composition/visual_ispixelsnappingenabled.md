---
-api-id: P:Windows.UI.Composition.Visual.IsPixelSnappingEnabled
-api-type: winrt property
---

# Windows.UI.Composition.Visual.IsPixelSnappingEnabled

<!--
public bool IsPixelSnappingEnabled { get; set; }
-->

## -description

Gets or sets a value that indicates whether the composition engine aligns the rendered visual with a pixel boundary.

## -property-value

`true` if the composition engine aligns the rendered visual with a pixel boundary; otherwise, `false`. The default is `false`.

## -remarks

## -see-also

## -examples

```csharp
public Visual CreateVisualTree(Compositor compositor)
{
    // Say we have two visuals, one containing an image and one containing text.
    // The image can be resampled and still look fine, but the text looks bad if
    // it doesn't land perfectly on pixel boundaries.
    var root = compositor.CreateContainerVisual();

    var imageVisual = compositor.CreateSpriteVisual();
    ImageLoadingHelper(imageVisual);

    var textVisual = compositor.CreateSpriteVisual();
    TextLoadingHelper(textVisual);

    textVisual.Offset = new Vector3(50, 0, 0);
    textVisual.IsPixelSnappingEnabled = true;

    root.Children.Add(imageVisual);
    root.Children.Add(textVisual);

    return root;
}

```
