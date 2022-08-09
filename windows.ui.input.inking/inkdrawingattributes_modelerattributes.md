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

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

