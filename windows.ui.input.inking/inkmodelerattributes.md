---
-api-id: T:Windows.UI.Input.Inking.InkModelerAttributes
-api-type: winrt class
---

<!-- Class syntax.
public class InkModelerAttributes 
-->

# Windows.UI.Input.Inking.InkModelerAttributes

## -description
Manages which types of ink modeler attributes can be processed by the the [InkPresenter](inkpresenter.md) object.

## -remarks
Ink modeling refers to the process of processing and optimizing input for rendering as ink strokes. This can inlcude filtering, smoothing, prediction (to reduce perceived latency), and transformation (such as scaling for display DPI, or mapping pointer pressure to stroke width).

## -see-also
[InkDrawingAttributes](inkdrawingattributes.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)

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

