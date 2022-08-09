---
-api-id: T:Windows.UI.Input.Inking.InkInputConfiguration
-api-type: winrt class
---

<!-- Class syntax.
public class InkInputConfiguration 
-->

# Windows.UI.Input.Inking.InkInputConfiguration

## -description
Manages which types of secondary input can be processed by the [InkPresenter](inkpresenter.md) object.

## -remarks
To manage how secondary input is processed by your app, see [InkInputProcessingConfiguration](inkinputprocessingconfiguration.md).

## -examples
Here, we show how to accept input as ink from pen, touch, and mouse devices, but ignore all input from pen barrel buttons and eraser tips. 

```csharp
public ScenarioBarrelEraserIgnore() 
{ 
    this.InitializeComponent(); 
    var inkPresenter = inkCanvas.InkPresenter; 
    inkPresenter.InputDeviceTypes = 
        Windows.UI.Core.CoreInputDeviceTypes.Pen |  
        Windows.UI.Core.CoreInputDeviceTypes.Touch | 
        Windows.UI.Core.CoreInputDeviceTypes.Mouse; 

    InkInputConfiguration inkInputConfiguration = 
        inkPresenter.InputConfiguration; 
    inkInputConfiguration.IsEraserInputEnabled = false; 
    inkInputConfiguration.IsPrimaryBarrelButtonInputEnabled = false; 
} 
```

## -see-also
[InkPresenter.InputConfiguration](inkpresenter_inputconfiguration.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

