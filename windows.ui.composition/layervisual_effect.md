---
-api-id: P:Windows.UI.Composition.LayerVisual.Effect
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.CompositionEffectBrush Effect { get;  set; }
-->

# Windows.UI.Composition.LayerVisual.Effect

## -description

Gets or sets the effect to be applied to the flattened representation of the children of a [LayerVisual](layervisual.md).

## -property-value

The effect to be applied to the flattened representation of the children of a [LayerVisual](layervisual.md).

## -remarks

This CompositionEffectBrush cannot take a [CompositionBackdropBrush](compositionbackdropbrush.md) as input, including HostBackdropBrush.

## -examples

This example shows how to apply a [GaussianBlurEffect](https://microsoft.github.io/Win2D/WinUI3/html/T_Microsoft_Graphics_Canvas_Effects_GaussianBlurEffect.htm) to a LayerVisual.

```csharp

private async void InitComposition()
{
  Compositor compositor = ElementCompositionPreview.GetElementVisual(MyGrid).Compositor;

  //Create LayerVisual
  LayerVisual layerVisual = compositor.CreateLayerVisual();
  layerVisual.Size = new Vector2(900,900);

  //Create SpriteVisuals to use as LayerVisual child
  SpriteVisual sv1 = compositor.CreateSpriteVisual();
  sv1.Brush = compositor.CreateColorBrush(Windows.UI.Colors.Blue);
  sv1.Size = new Vector2(300, 300);
  sv1.Offset = new Vector3(200, 200, 0);

  SpriteVisual sv2 = compositor.CreateSpriteVisual();
  sv2.Brush = compositor.CreateColorBrush(Colors.Red);
  sv2.Size = new Vector2(300, 300);
  sv2.Offset = new Vector3(400, 400, 0);

  //Add children to the LayerVisual
  layerVisual.Children.InsertAtTop(sv1);
  layerVisual.Children.InsertAtTop(sv2);

  //Create Effect
  var graphicsEffect = new GaussianBlurEffect
  {
     Name = "Blur",
     Source = new CompositionEffectSourceParameter("Backdrop"),
     BlurAmount = 10.0f,
     BorderMode = EffectBorderMode.Hard,
     Optimization = EffectOptimization.Balanced
  };

  var blurEffectFactory = compositor.CreateEffectFactory(graphicsEffect,
      new[] { "Blur.BlurAmount" });
  var blurBrush = blurEffectFactory.CreateBrush();

  //Apply Effect
  layerVisual.Effect = blurBrush;

  ElementCompositionPreview.SetElementChildVisual(MyGrid, layerVisual);
}        
         
```

The result looks like this.

:::image type="content" source="images/layer-visual-blur.png" alt-text="A red square overlapping a blue square with a blur effect applied.":::

## -see-also
