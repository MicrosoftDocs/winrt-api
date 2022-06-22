---
-api-id: T:Windows.UI.Composition.CompositionMaskBrush
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionMaskBrush : Windows.UI.Composition.CompositionBrush, Windows.UI.Composition.ICompositionMaskBrush
-->

# Windows.UI.Composition.CompositionMaskBrush

## -description
Paints a SpriteVisual with a CompositionBrush with an opacity mask applied to it. The source of the opacity mask can be any CompositionBrush of type CompositionColorBrush, CompositionLinearGradientBrush, CompositionSurfaceBrush, CompositionEffectBrush or a CompositionNineGridBrush. The opacity mask must be specified as a CompositionSurfaceBrush.



## -remarks
CompositionMaskBrush can not be set as the source parameter to a [CompositionEffectBrush](compositioneffectbrush.md). If you wish to apply an IGraphicsEffect to your masked content, use a [CompositionEffectBrush](compositioneffectbrush.md) with the [Composite effect](/windows/uwp/graphics/composition-effects?f=255&amp;MSPPError=-2147217396) instead.

## -examples
Apply a star-shaped mask to an image.

```csharp

private SpriteVisual CreateCircleImage(ICompositionSurface myImageSurface, ICompositionSurface myStarMaskSurface) 
{ 
  // Create SurfaceBrush with image surface and specify stretch and alignment 
  CompositionSurfaceBrush imageBrush = _compositor.CreateSurfaceBrush(myImageSurface); 
  imageBrush.HorizontalAlignmentRatio = 0.5f; 
  imageBrush.VerticalAlignmentRatio = 0.5f; 
  imageBrush.Stretch = CompositionStretch.UniformToFill; 
 
  // Create surface brush with opacity mask surface and specify stretch and alignment 
  CompositionSurfaceBrush starMaskBrush = _compositor.CreateSurfaceBrush(myStarMaskSurface); 
  starMaskBrush.Stretch = CompositionStretch.Uniform; 
 
  // SpriteVisual to be painted with masked content 
  SpriteVisual imageVisual = _compositor.CreateSpriteVisual(); 
  imageVisual.Size = new Vector2(200, 200); 

  // Create MaskBrush 
  CompositionMaskBrush maskBrush = _compositor.CreateMaskBrush(); 
  maskBrush.Source = imageBrush; // Set source to content that is to be masked 
  maskBrush.Mask = starMaskBrush; // Set mask to content that is the opacity mask 
 
  imageVisual.Brush = maskBrush; // Paint SpriteVisual with MaskBrush 
 
  return imageVisual;           
} 
          
      
```

Applying an opacity mask to solid color fill to create a shape; animate the transform property on the opacity mask [CompositionSurfaceBrush](compositionsurfacebrush.md) to create a color bloom animation

```csharp

private void CreateCircleMaskSprite(ICompositionSurface myCircleMaskSurface, ICompositionSurface myImageSurface)
{
  // SpriteVisual to be painted by MaskBrush
  _circleVisual = _compositor.CreateSpriteVisual();
  _circleVisual.Size = MyContainerGrid.RenderSize.ToVector2();

  // SurfaceBrush w/ image as MaskBrush.Source
  CompositionSurfaceBrush imageBrush = _compositor.CreateSurfaceBrush(myImageSurface);
  imageBrush.Stretch = CompositionStretch.UniformToFill;

  // SurfaceBrush w/ opacity mask surface as MaskBrush.Mask
  CompositionSurfaceBrush circleBrush = _compositor.CreateSurfaceBrush(myCircleMaskSurface);
   
  // Specify stretch and transform properties to scale and position brush for initial state
  circleBrush.Stretch = CompositionStretch.Uniform;
  circleBrush.CenterPoint = _circleVisual.Size / 2;
  circleBrush.Scale = new Vector2(0.5f);

  // Create MaskBrush
  CompositionMaskBrush maskBrush = _compositor.CreateMaskBrush();
  maskBrush.Source = imageBrush;
  maskBrush.Mask = circleBrush;
  _circleVisual.Brush = maskBrush;

  // Set SpriteVisual as child of XAML Grid
  ElementCompositionPreview.SetElementChildVisual(MyContainerGrid, _circleVisual);
}

private void BloomAnimation()
{
  // Create KeyFrame Animation to target Scale transform on SurfaceBrush 
  Vector2KeyFrameAnimation scaleAnimation = _compositor.CreateVector2KeyFrameAnimation();
  scaleAnimation.InsertKeyFrame(1.0f, new Vector2(2));
  scaleAnimation.Duration = TimeSpan.FromMilliseconds(500);

  var maskBrush = (CompositionMaskBrush)_circleVisual.Brush;
  var surfaceBrush = (CompositionSurfaceBrush) maskBrush.Mask;

  // Animate the Scale on the circle opacity mask
  surfaceBrush.StartAnimation("Scale", scaleAnimation);      
}
          
      
```

Applying a rounded rectangle mask to create a solid color rounded rectangle whose corner radius does not increase upon resizing (use [CompositionNineGridBrush](compositionninegridbrush.md) as input to a 
    **CompositionMaskBrush**
  ).

```csharp

private SpriteVisual CreateMaskedRoundedRectVisual(ICompositionSurface myRoundedRectMaskSurface)
{
  // ColorBrush to be set as MaskBrush.Source
  CompositionColorBrush colorBrush = _compositor.CreateColorBrush(Colors.Blue);

  // SurfaceBrush w/ opacity mask surface
  CompositionSurfaceBrush roundedRectBrush = _compositor.CreateSurfaceBrush(myRoundedRectMaskSurface);
  roundedRectBrush.Stretch = CompositionStretch.Fill; // stretch for center of nine-grid

  // NineGridBrush w/ insets on opacity mask surface
  CompositionNineGridBrush ninegridBrush = _compositor.CreateNineGridBrush();
  ninegridBrush.Source = roundedRectBrush;
  ninegridBrush.SetInsets(_cornerRadius); // the radius, in pixels, of the corner as specified on my opacity mask surface 

  // Create MaskBrush
  CompositionMaskBrush maskBrush = _compositor.CreateMaskBrush();
  maskBrush.Source = colorBrush;
  maskBrush.Mask = ninegridBrush;

  // Paint SpriteVisual with MaskBrush
  SpriteVisual sprite = _compositor.CreateSpriteVisual();
  sprite.Size = new Vector2(300, 200);
  sprite.Brush = maskBrush;
  return sprite;

}
          
      
```



## -see-also
[CompositionBrush](compositionbrush.md), [IClosable](../windows.foundation/iclosable.md)
