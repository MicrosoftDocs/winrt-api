---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.IgnorePressure
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IgnorePressure { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.IgnorePressure

## -description
Gets or sets a value that indicates whether the pressure of the contact on the digitizer surface is ignored when you draw an [InkStroke](inkstroke.md).

## -property-value
**true** if pressure is ignored; otherwise **false**. The default value is **false**.

## -remarks
If IgnorePressure is set to false, the user can modify the thickness of a stroke by adjusting the amount of pressure applied to the digitizer surface while writing. 


The following actions may be affected by the IgnorePressure setting.<table>
   <tr><th>IgnorePressure</th><th>True</th><th>False</th></tr>
   <tr><th>Copy</th><td>No effect. Pressure data, if present, is written to the Ink Serialized Format (ISF) stream.</td><td>No effect. Pressure data, if present, is written to the Ink Serialized Format (ISF) stream.</td></tr>
   <tr><th>Paste</th><td>Depending on the implementation, pressure data from Ink Serialized Format (ISF) stream may be ignored during rendering.</td><td>Depending on the implementation, pressure data from Ink Serialized Format (ISF) stream may be applied during rendering.</td></tr>
   <tr><th>Save</th><td>No effect. Pressure data, if present, is written to the Ink Serialized Format (ISF) stream.</td><td>No effect. Pressure data, if present, is written to the Ink Serialized Format (ISF) stream</td></tr>
   <tr><th>Load</th><td>Depending on the implementation, pressure data from Ink Serialized Format (ISF) stream may be ignored during rendering.</td><td>Depending on the implementation, pressure data from Ink Serialized Format (ISF) stream may be applied during rendering.</td></tr>
</table>

## -examples
The following example demonstrates how to set the IgnorePressure attribute for all strokes managed by this [InkManager](inkmanager.md) object (`inkManager`) that are created after the [SetDefaultDrawingAttributes](inkmanager_setdefaultdrawingattributes_1436218448.md) method call.

```csharp
var inkManager = new Windows.UI.Input.Inking.InkManager();
var drawingAttributes = new Windows.UI.Input.Inking.InkDrawingAttributes();
drawingAttributes.ignorePressure = true;
inkManager.setDefaultDrawingAttributes(drawingAttributes);

```

## -see-also
[Pressure](inkstrokerenderingsegment_pressure.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)
