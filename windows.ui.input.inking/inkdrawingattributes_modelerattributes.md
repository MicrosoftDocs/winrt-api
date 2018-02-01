---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.ModelerAttributes
-api-type: winrt property
---

<!-- Property syntax.
public InkModelerAttributes ModelerAttributes { get; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.ModelerAttributes

## -description
Gets an instance of a [ModelerAttributes](inkmodelerattributes.md) object for accessing modeler properties of an ink stroke.

## -property-value
A [ModelerAttributes](inkmodelerattributes.md) object used to process ink stroke rendering properties.

## -remarks

## -examples

Here, we show how increasing latency when rendering ink strokes can be used to reduce possible stroke correction artifacts due to incorrect prediction. This example reduces the default forward-looking prediction time from 15ms to 8ms.

```csharp
public sealed partial class AdjustPrediction : Page
{
    public AdjustPrediction()
    {
        this.InitializeComponent();
        var inkPresenter = inkCanvas.InkPresenter;
        InkDrawingAttributes drawingAttributes =
            inkPresenter.CopyDefaultDrawingAttributes();
        
        InkModelingAttributes modelingAttributes = drawingAttributes.ModelingAttributes;
        modelingAttributes.PredictionTime = TimeSpan.FromMilliseconds(8);
        inkPresenter.UpdateDefaultDrawingAttributes(drawingAttributes);
    }
}
```

## -see-also

