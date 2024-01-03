---
-api-id: P:Windows.UI.Composition.LayerVisual.Shadow
-api-type: winrt property
---

<!-- Property syntax.
public CompositionShadow Shadow { get;  set; }
-->

# Windows.UI.Composition.LayerVisual.Shadow

## -description

Gets or sets the shadow to be applied to the flattened representation of the children of a [LayerVisual](layervisual.md).

## -property-value

The shadow to be applied to the flattened representation of the children of a [LayerVisual](layervisual.md).

## -remarks

## -see-also

## -examples

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
