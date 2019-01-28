---
-api-id: P:Windows.UI.Input.Inking.InkPresenter.StrokeContainer
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.InkStrokeContainer StrokeContainer { get;  set; }
-->

# Windows.UI.Input.Inking.InkPresenter.StrokeContainer

## -description
Gets or sets an [InkStrokeContainer](inkstrokecontainer.md) object to store and manage the collection of [InkStroke](inkstroke.md) objects rendered by the [InkPresenter](inkpresenter.md).

Modifications made to any of the ink strokes in the stroke container are immediately rendered to the drawing surface associated with the [InkPresenter](inkpresenter.md).

## -property-value
Stores and manages one or more [InkStroke](inkstroke.md) objects.

If custom dry mode is enabled ([ActivateCustomDrying](inkpresenter_activatecustomdrying_1826048524.md)), [StrokeContainer](inkpresenter_strokecontainer.md) is null.

## -remarks
The [StrokesCollected](inkpresenter_strokescollected.md) event is fired when ink strokes are processed ("wet" to "dry") on the UI thread.

For ink recognition, use an [InkRecognizerContainer](inkrecognizercontainer.md) object.

## -examples

## -see-also

[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

