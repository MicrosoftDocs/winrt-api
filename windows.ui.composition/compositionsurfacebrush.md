---
-api-id: T:Windows.UI.Composition.CompositionSurfaceBrush
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionSurfaceBrush : Windows.UI.Composition.CompositionBrush, Windows.UI.Composition.ICompositionSurfaceBrush, Windows.UI.Composition.ICompositionSurfaceBrush2
-->

# Windows.UI.Composition.CompositionSurfaceBrush

## -description
Paints a [SpriteVisual](spritevisual.md) with pixels from an ICompositionSurface.



## -remarks

The Stretch property, in conjunction with the HorizontalAlignmentRatio and VerticalAlignmentRatio properties, is used to specify the scale and positioning of the CompositionSurfaceBrush’s contents when painted onto a SpriteVisual.

CompositionSurfaceBrush also has the following properties that enable custom transformations:

+ AnchorPoint
+ CenterPoint
+ Offset
+ RotationAngle
+ RotationAngleInDegrees
+ Scale
+ TransformMatrix

The order of transformation operations on a CompositionSurfaceBrush is as follows:

1. The content of the CompositionSurfaceBrush is stretched and aligned onto the [SpriteVisual](spritevisual.md) (see [Stretch](compositionsurfacebrush_stretch.md), [HorizontalAlignmentRatio](compositionsurfacebrush_horizontalalignmentratio.md), and [VerticalAlignmentRatio](compositionsurfacebrush_verticalalignmentratio.md) properties).

1. Any other transformation properties set on the CompositionSurfaceBrush are applied.

    Custom transformations applied to a CompositionSurfaceBrush are therefore evaluated in the coordinate space of the SpriteVisual that the brush is painted onto. For example, setting an Offset of Vector2(100, 0) offsets the brush’s stretched and aligned contents by 100 units to the right relative to the left edge of the [SpriteVisual](spritevisual.md) it is painted onto.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | AnchorPoint |
| 1607 | 14393 | CenterPoint |
| 1607 | 14393 | Offset |
| 1607 | 14393 | RotationAngle |
| 1607 | 14393 | RotationAngleInDegrees |
| 1607 | 14393 | Scale |
| 1607 | 14393 | TransformMatrix |
| 1903 | 18362 | SnapToPixels |

## -examples
Draw an image asset onto a SpriteVisual

```csharp

private SpriteVisual CreateImageVisual(ICompositionSurface imageSurface)
{
  SpriteVisual imageVisual = _compositor.CreateSpriteVisual();
  imageVisual.Size = new Vector2(300, 200);

  CompositionSurfaceBrush imageBrush = _compositor.CreateSurfaceBrush();
  imageBrush.Surface = imageSurface;

  // specify CompositionStretch on SurfaceBrush and horizontal/vertical alignment
  imageBrush.Stretch = CompositionStretch.UniformToFill;
  imageBrush.HorizontalAlignmentRatio = 0.5f;
  imageBrush.VerticalAlignmentRatio = 0.5f;

  imageVisual.Brush = imageBrush;
  return imageVisual;
}
          
```

Apply a custom scale transformation animation to a CompositionSurfaceBrush

```csharp

private void AnimateBrushScale(SpriteVisual imageVisual)
{
  CompositionSurfaceBrush imageBrush = (CompositionSurfaceBrush)imageVisual.Brush;
            
  // set brush CenterPoint at the center of the content painted onto imageVisual 
  imageBrush.CenterPoint = imageVisual.Size / 2;

  // set up scale keyframe animation
  CompositionScopedBatch batch = _compositor.CreateScopedBatch(CompositionBatchTypes.Animation);
  Vector2KeyFrameAnimation scaleAnimation = _compositor.CreateVector2KeyFrameAnimation();
  scaleAnimation.InsertKeyFrame(1.0f, new Vector2(1.5f));
  scaleAnimation.Duration = TimeSpan.FromMilliseconds(500);

  // start animation on CompositionSurfaceBrush.Scale
  imageBrush.StartAnimation("Scale", scaleAnimation);

  // end animation batch and fire completion event
  batch.End();
  batch.Completed += ScaleAnimationBatch_Completed;
} 
        
        
```



## -see-also
[CompositionBrush](compositionbrush.md), [IClosable](../windows.foundation/iclosable.md)
