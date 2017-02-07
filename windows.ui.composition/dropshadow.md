---
-api-id: T:Windows.UI.Composition.DropShadow
-api-type: winrt class
---

<!-- Class syntax.
public class DropShadow : Windows.UI.Composition.CompositionShadow, Windows.UI.Composition.IDropShadow
-->

# Windows.UI.Composition.DropShadow

## -description
A drop shadow cast by a [SpriteVisual](spritevisual.md).

## -remarks
Shadows are not clipped by the implicit clip set on the visual (based on size of the visual). However, shadows respect the explicit clip set on the visual using SpriteVisual.Clip Property.

## -examples
Simple DropShadow

```csharp

private async void InitComposition()
{
  _compositor = ElementCompositionPreview.GetElementVisual(MyGrid).Compositor;
  _imageLoader = ImageLoaderFactory.CreateImageLoader(_compositor);

  //Create surface brush and load image
  CompositionSurfaceBrush surfaceBrush = _compositor.CreateSurfaceBrush();
  surfaceBrush.Surface = await _imageLoader.LoadImageFromUriAsync(new Uri("ms-appx:///Assets/cat.jpg"));

  //Create sprite visual
  SpriteVisual visual = _compositor.CreateSpriteVisual();
  visual.Brush = surfaceBrush;
  visual.Size = new Vector2(270, 200);

  //Create drop shadow
  DropShadow shadow = _compositor.CreateDropShadow();
  shadow.BlurRadius = 5;
  shadow.Offset = new Vector3(15, 15, -10);
  shadow.Color = Colors.DarkGray;

  //Associate shadow with visual
  visual.Shadow = shadow;
}         
         
```

DropShadow with Animations

```csharp

private async void InitComposition()
{
  _compositor = ElementCompositionPreview.GetElementVisual(MyGrid).Compositor;
  _imageLoader = ImageLoaderFactory.CreateImageLoader(_compositor);

  //Create surface brush and load image
  CompositionSurfaceBrush surfaceBrush = _compositor.CreateSurfaceBrush();
  surfaceBrush.Surface = await _imageLoader.LoadImageFromUriAsync(new Uri("ms-appx:///Assets/cat.jpg"));

  //Create sprite visual
  SpriteVisual visual = _compositor.CreateSpriteVisual();
  visual.Brush = surfaceBrush;
  visual.Size = new Vector2(270, 200);

  //Create drop shadow
  DropShadow shadow = _compositor.CreateDropShadow();
  shadow.BlurRadius = 5;
  shadow.Offset = new Vector3(15, 15, -10);
  shadow.Color = Colors.DarkGray;

  //Create animations
  ScalarKeyFrameAnimation blurAnimation = this.CreateBlurAnimation();
  Vector3KeyFrameAnimation offsetAnimation = this.CreateOffsetAnimation();

  //Apply animations
  shadow.StartAnimation("BlurRadius", blurAnimation);
  shadow.StartAnimation("Offset", offsetAnimation);

  //Associate shadow with visual
  visual.Shadow = shadow;
}

private ScalarKeyFrameAnimation CreateBlurAnimation()
{
  ScalarKeyFrameAnimation shadowBlurAnimation = _compositor.CreateScalarKeyFrameAnimation();
  shadowBlurAnimation.InsertKeyFrame(0.0f, 5.0f);
  shadowBlurAnimation.InsertKeyFrame(0.5f, 20.0f);
  shadowBlurAnimation.InsertKeyFrame(1.0f, 5.0f);
  shadowBlurAnimation.Duration = TimeSpan.FromSeconds(2);
  shadowBlurAnimation.IterationBehavior = AnimationIterationBehavior.Forever;

  return shadowBlurAnimation;
}

private Vector3KeyFrameAnimation CreateOffsetAnimation()
{
  Vector3 startOffset = new Vector3(15, 15, -10);
  Vector3 endOffset = new Vector3(30, 30, -20);

  Vector3KeyFrameAnimation offsetAnimation = _compositor.CreateVector3KeyFrameAnimation();
  offsetAnimation.InsertKeyFrame(0.0f, startOffset);
  offsetAnimation.InsertKeyFrame(0.5f, endOffset);
  offsetAnimation.InsertKeyFrame(1.0f, startOffset);
  offsetAnimation.Duration = TimeSpan.FromSeconds(2);
  offsetAnimation.IterationBehavior = AnimationIterationBehavior.Forever;

  return offsetAnimation;
}         
         
```



## -see-also
[CompositionShadow](compositionshadow.md), [IClosable](../windows.foundation/iclosable.md)