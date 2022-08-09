---
-api-id: M:Windows.UI.Input.Inking.InkPoint.#ctor(Windows.Foundation.Point,System.Single,System.Single,System.Single,System.UInt64)
-api-type: winrt method
---

<!-- Method syntax
public InkPoint(Windows.Foundation.Point position, System.Single pressure, System.Single tiltX, System.Single tiltY, System.UInt64 timestamp)
-->

# Windows.UI.Input.Inking.InkPoint.InkPoint

## -description
Creates a complex [InkPoint](inkpoint.md) object used in the construction of an [InkStroke](inkstroke.md).

## -parameters
### -param position
The screen coordinates for the [InkPoint](inkpoint.md) object.

### -param pressure
The pressure of the contact on the digitizer surface. The default is 0.5.

### -param tiltX
The plane angle between the Y-Z plane and the plane containing the Y axis and the axis of the input device. The default is 0.

### -param tiltY
The plane angle between the X-Z plane and the plane containing the X axis and the axis of the input device. The default is 0.

### -param timestamp
The timestamp for the first [InkPoint](inkpoint.md) of an InkStroke, or when an entire InkStroke is pasted or loaded. 

## -remarks

## -examples

## -see-also

[InkPoint(Windows.Foundation.Point position, System.Single pressure)](inkpoint_inkpoint_1903734527.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

