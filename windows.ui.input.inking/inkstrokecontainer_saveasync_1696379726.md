---
-api-id: M:Windows.UI.Input.Inking.InkStrokeContainer.SaveAsync(Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<uint, uint> SaveAsync(Windows.Storage.Streams.IOutputStream outputStream)
-->

# Windows.UI.Input.Inking.InkStrokeContainer.SaveAsync

## -description
Asynchronously saves all [InkStroke](inkstroke.md) objects in the [InkStroke](inkstroke.md) collection that is managed by the [InkStrokeContainer](inkstrokecontainer.md) to the specified stream.

## -parameters
### -param outputStream
The target stream. An [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) (requires [IOutputStream](../windows.storage.streams/ioutputstream.md)) object can be specified instead.

## -returns
The status of the asynchronous operation as the number of bytes sent. For more information, see [WriteAsync](/previous-versions/hh438392(v=vs.85)) method.

## -remarks

## -examples

## -see-also
[InkStrokeContainer.SaveAsync(Windows.Storage.Streams.IOutputStream outputStream, Windows.UI.Input.Inking.InkPersistenceFormat inkPersistenceFormat)](inkstrokecontainer_saveasync_238248194.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

