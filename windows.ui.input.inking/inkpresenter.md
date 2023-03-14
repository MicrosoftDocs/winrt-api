---
-api-id: T:Windows.UI.Input.Inking.InkPresenter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkPresenter : Windows.UI.Input.Inking.IInkPresenter, Windows.UI.Input.Inking.IInkPresenter2
-->

# Windows.UI.Input.Inking.InkPresenter

## -description

Provides properties, methods, and events for managing the input, processing, and rendering of ink input (standard and modified) for an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

## -remarks

For Universal Windows apps, we recommend using InkPresenter and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

The InkPresenter class cannot be instantiated directly. It is returned as a property of an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) object.

> [!NOTE]
> Standard ink input (pen tip or eraser tip/button) is not modified with a secondary affordance, such as a pen barrel button, right mouse button, or similar (see [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md)).

By default, both standard and modified ink input is managed entirely by the [InkPresenter](inkunprocessedinput_inkpresenter.md) and rendered to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) as either an ink stroke or an erase stroke, based on [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md).

Modified input can be passed through to your app for processing by setting [InkInputProcessingConfiguration.RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) to [InkInputRightDragAction.LeaveUnprocessed](inkinputrightdragaction.md).

All input can be passed through to your app for processing by setting [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) to [None](inkinputprocessingmode.md).

Leaving input unprocessed by the [InkPresenter](inkunprocessedinput_inkpresenter.md) lets you support a customized ink experience and extended functionality such as selection.

For complete control of ink input and to render it to the Direct2D device context of your Universal Windows app, instead of the default [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control, call [ActivateCustomDrying](inkpresenter_activatecustomdrying_1826048524.md) prior to loading the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md). This requires an [IInkD2DRenderer](/windows/desktop/api/inkrenderer/nn-inkrenderer-iinkd2drenderer) object to manage the ink input (see the [Complex ink sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | HighContrastAdjustment |
| 1803 | 17134 | InputConfiguration |

## -examples
Here, we show how to overlay ink annotations on an image. For this example, ink data is not captured or saved by a corresponding InkPresenter.

```xaml
<ScrollViewer>
  <Grid>
    <Image Source="<path>"></Image>
    <InkCanvas x:Name="inkCanvas"></InkCanvas>
  </Grid>
</ScrollView
```

Here, we configure the [InkPresenter](../windows.ui.xaml.controls/inkcanvas_inkpresenter.md) to interpret input data from both pen and mouse as ink strokes. We also set some initial ink stroke attributes used for rendering strokes to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).


[!code-csharp[SnippetSetInitialStrokeAttributes](../windows.ui.input.inking/code/Ink_Basic_Customization/csharp/MainPage.xaml.cs#SnippetSetInitialStrokeAttributes)]

Ink stroke attributes can be set dynamically to accommodate user preferences or app requirements.

Here, we let a user choose from a list of ink colors.

[!code-xaml[SnippetUI](../windows.ui.input.inking/code/Ink_Basic_Customization/csharp/MainPage.xaml#SnippetUI)]

We then handle changes to the selected color and update the ink stroke attributes accordingly.


[!code-csharp[SnippetSetColorStrokeAttribute](../windows.ui.input.inking/code/Ink_Basic_Customization/csharp/MainPage.xaml.cs#SnippetSetColorStrokeAttribute)]


## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

