---
-api-id: T:Windows.UI.Input.Inking.InkPresenterPredefinedConfiguration
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkPresenterPredefinedConfiguration : int
-->

# InkPresenterPredefinedConfiguration

## -description
Specifies the inking behavior of one or more contact points. Used with [SetPredefinedConfiguration](inkpresenter_setpredefinedconfiguration_1107454914.md).

## -enum-fields
### -field SimpleSinglePointer:0
A single, primary contact point is used to draw an [InkStroke](inkstroke.md).

### -field SimpleMultiplePointer:1
Each contact point is used to draw an [InkStroke](inkstroke.md). 

> [!NOTE]
> Multi-pointer inking requires ink input to be processed in custom drying mode. [ActivateCustomDrying](inkpresenter_activatecustomdrying_1826048524.md) must be called before setting [SetPredefinedConfiguration](inkpresenter_setpredefinedconfiguration_1107454914.md) to [SimpleMultiplePointer](inkpresenterpredefinedconfiguration.md).


## -remarks

## -examples

## -see-also

[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

