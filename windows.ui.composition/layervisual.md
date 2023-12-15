---
-api-id: T:Windows.UI.Composition.LayerVisual
-api-type: winrt class
---

<!-- Class syntax.
public class LayerVisual : Windows.UI.Composition.ContainerVisual, Windows.UI.Composition.ILayerVisual
-->

# Windows.UI.Composition.LayerVisual

## -description
A ContainerVisual whose children are flattened into a single layer.



## -remarks
A LayerVisual is a special input type that can be used to select a tree of visuals. The tree input is implicitly specified using the LayerVisual. When an EffectBrush is set to the Effect property of the LayerVisual, the EffectBrush automatically uses the subtree rooted at the LayerVisual as the input. The implicit input for LayerVisual works for effects as follows:

+ If the effect has one input, the EffectBrush uses the subtree rooted at the LayerVisual as the input.
+ If the effect has 2 inputs, the first unbounded input of the EffectBrush uses the subtree rooted at the LayerVisual as the input.
+ The system does not allow an effect with 0 inputs or effects with all inputs bounded to SurfaceBrush to be set as the EffectBrush on LayerVisual’s Effect property. This will throw an exception.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | Shadow |

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

This example shows how to apply a [DropShadow](dropshadow.md) to a LayerVisual.

```csharp

private async void InitComposition()
{
  Compositor compositor = ElementCompositionPreview.GetElementVisual(MyGrid).Compositor;

  //Create LayerVisual
  LayerVisual layerVisual = compositor.CreateLayerVisual();
  layerVisual.Size = new Vector2(900, 900);

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

  //Create DropShadow
  DropShadow shadow = compositor.CreateDropShadow();
  shadow.Color = Colors.DarkSlateGray;
  shadow.Offset = new Vector3(40, 40, 0);
  shadow.BlurRadius = 9;
  shadow.SourcePolicy = CompositionDropShadowSourcePolicy.InheritFromVisualContent;

  //Associate Shadow with LayerVisual
  layerVisual.Shadow = shadow;

  ElementCompositionPreview.SetElementChildVisual(MyGrid, layerVisual);
}         
         
```

The result looks like this.

:::image type="content" source="images/layer-visual-shadow.png" alt-text="A red square overlapping a blue square with a shadow applied to each square.":::

## -see-also
[ContainerVisual](containervisual.md), [IClosable](../windows.foundation/iclosable.md)
