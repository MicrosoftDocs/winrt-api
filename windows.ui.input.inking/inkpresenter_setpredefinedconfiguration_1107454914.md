---
-api-id: M:Windows.UI.Input.Inking.InkPresenter.SetPredefinedConfiguration(Windows.UI.Input.Inking.InkPresenterPredefinedConfiguration)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetPredefinedConfiguration(Windows.UI.Input.Inking.InkPresenterPredefinedConfiguration value)
-->

# Windows.UI.Input.Inking.InkPresenter.SetPredefinedConfiguration

## -description
Sets the inking behavior of one or more contact points on the associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

## -parameters
### -param value
The inking behavior of one or more contact points. The default is [SimpleSinglePointer](inkpresenterpredefinedconfiguration.md).

[SimpleSinglePointer](inkpresenterpredefinedconfiguration.md) specifies that single pointer inking is supported.

[SimpleMultiplePointer](inkpresenterpredefinedconfiguration.md) specifies that multi-pointer inking is supported. 

> [!NOTE]
> Multi-pointer inking requires ink input to be processed in custom drying mode. [ActivateCustomDrying](inkpresenter_activatecustomdrying_1826048524.md) must be called before setting SetPredefinedConfiguration to [SimpleMultiplePointer](inkpresenterpredefinedconfiguration.md).

## -remarks
#### Error codes
##### E_ILLEGAL_METHOD_CALL  (0x8000000E)
Thrown if multi-pointer inking is enabled through SetPredefinedConfiguration before [ActivateCustomDrying](inkpresenter_activatecustomdrying_1826048524.md) is called.

##### E_INVALIDARG  (0x80070057)
An invalid parameter was specified. 

## -examples

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

