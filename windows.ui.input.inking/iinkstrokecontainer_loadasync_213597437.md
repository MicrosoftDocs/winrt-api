---
-api-id: M:Windows.UI.Input.Inking.IInkStrokeContainer.LoadAsync(Windows.Storage.Streams.IInputStream)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncActionWithProgress<ulong> LoadAsync(Windows.Storage.Streams.IInputStream inputStream)
-->

# Windows.UI.Input.Inking.IInkStrokeContainer.LoadAsync

## -description
Asynchronously loads all [InkStroke](inkstroke.md) objects from the specified stream to the [InkStroke](inkstroke.md) collection that is managed by the [InkStrokeContainer](inkstrokecontainer.md).

## -parameters
### -param inputStream
The stream that contains the stroke collection. An [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) (requires [IOutputStream](../windows.storage.streams/ioutputstream.md)) object can be specified instead.

## -returns
The status of the asynchronous operation as the number of bytes fetched. For more information, see [ReadAsync](http://msdn.microsoft.com/library/4d5046c8-a1d2-435f-9c3d-64c242fc20cf) method.

## -remarks

## -examples

## -see-also

[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Get started: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

