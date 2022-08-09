---
-api-id: T:Windows.UI.Input.Inking.InkDrawingAttributes
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkDrawingAttributes : Windows.UI.Input.Inking.IInkDrawingAttributes, Windows.UI.Input.Inking.IInkDrawingAttributes2, Windows.UI.Input.Inking.IInkDrawingAttributes3, Windows.UI.Input.Inking.IInkDrawingAttributes4
-->

# Windows.UI.Input.Inking.InkDrawingAttributes

## -description
Provides properties associated with the drawing of an [InkStroke](inkstroke.md).

## -remarks
InkDrawingAttributes can be set globally through the [SetDefaultDrawingAttributes](inkmanager_setdefaultdrawingattributes_1436218448.md) method of an [InkManager](inkmanager.md) object or an [InkStrokeBuilder](inkstrokebuilder.md) object. They can also be set on an individual [InkStroke](inkstroke.md) object through the [DrawingAttributes](inkstroke_drawingattributes.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | CreateForPencil |
| 1607 | 14393 | Kind |
| 1607 | 14393 | PencilProperties |
| 1703 | 15063 | IgnoreTilt |
| 1803 | 17134 | ModelerAttributes |

## -examples
The following example demonstrates how to set a default drawing attribute for all strokes managed by an [InkManager](inkmanager.md) object (`inkManager`).

```csharp
// Create the InkManager instance.
Windows.UI.Input.Inking.InkManager inkManager = 
  new Windows.UI.Input.Inking.InkManager();
Windows.UI.Input.Inking.InkDrawingAttributes drawingAttributes = 
  new Windows.UI.Input.Inking.InkDrawingAttributes();
// True is the Default value for fitToCurve.
drawingAttributes.FitToCurve = false;
// Set color to red (default is black).
drawingAttributes.Color = Windows.UI.Colors.CornflowerBlue;
inkManager.SetDefaultDrawingAttributes(drawingAttributes);

```

The following example demonstrates how to set a drawing attribute for a specific stroke.

> [!NOTE]
> You cannot set the [DrawingAttributes](inkstroke_drawingattributes.md) property of the stroke directly. You must create a copy of the InkDrawingAttributes of the stroke, set the desired values for that InkDrawingAttributes object, and then assign the new InkDrawingAttributes to the [DrawingAttributes](inkstroke_drawingattributes.md) of the stroke, as shown here.

```csharp
// Get the InkStroke objects.
IReadOnlyList<InkStroke> inkStrokes = inkManager.GetStrokes();
Windows.UI.Input.Inking.InkStroke cloneStroke = 
  inkStrokes.GetAt(index).Clone();
Windows.UI.Input.Inking.InkDrawingAttributes drawingAttributes = 
  cloneStroke.DrawingAttributes;
drawingAttributes.PenTip = Windows.UI.Input.Inking.PenTipShape.Rectangle;
cloneStroke.DrawingAttributes = drawingAttributes;
```

## -see-also
[Windows.UI.Input.Inking.InkManager.SetDefaultDrawingAttributes](inkmanager_setdefaultdrawingattributes_1436218448.md), [Windows.UI.Input.Inking.InkStroke.DrawingAttributes](inkstroke_drawingattributes.md), [UI.Xaml.Controls.InkToolbar.InkDrawingAttributes](../windows.ui.xaml.controls/inktoolbar_inkdrawingattributes.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

