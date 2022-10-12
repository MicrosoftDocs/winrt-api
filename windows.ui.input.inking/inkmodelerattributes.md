---
-api-id: T:Windows.UI.Input.Inking.InkModelerAttributes
-api-type: winrt class
---

<!-- Class syntax.
public class InkModelerAttributes 
-->

# Windows.UI.Input.Inking.InkModelerAttributes

## -description

Manages which types of ink modeler attributes can be processed by the [InkPresenter](inkpresenter.md) object.

## -remarks

Ink modeling refers to the process of processing and optimizing input for rendering as ink strokes. This can inlcude filtering, smoothing, prediction (to reduce perceived latency), and transformation (such as scaling for display DPI, or mapping pointer pressure to stroke width).

When using the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md), [InkModelerAttributes](inkmodelerattributes.md) should be set in the [InkToolbar.ActiveToolChanged](../windows.ui.xaml.controls/inktoolbar_activetoolchanged.md) event as attributes are overwritten whenever the active tool is changed.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | UseVelocityBasedPressure |

## -see-also

[InkDrawingAttributes](inkdrawingattributes.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

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
