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
If [IgnorePressure](inkdrawingattributes_ignorepressure.md) is set to false, the user can modify the thickness of a stroke by adjusting the amount of pressure applied to the digitizer surface while writing. 


The following actions may be affected by the [IgnorePressure](inkdrawingattributes_ignorepressure.md) setting.<table>
   <tr><th>IgnorePressure</th><th>True</th><th>False</th></tr>
   <tr><th>Copy</th><td>No effect. Pressure data, if present, is written to the Ink Serialized Format (ISF) stream.</td><td>No effect. Pressure data, if present, is written to the Ink Serialized Format (ISF) stream.</td></tr>
   <tr><th>Paste</th><td>Depending on the implementation, pressure data from Ink Serialized Format (ISF) stream may be ignored during rendering.</td><td>Depending on the implementation, pressure data from Ink Serialized Format (ISF) stream may be applied during rendering.</td></tr>
   <tr><th>Save</th><td>No effect. Pressure data, if present, is written to the Ink Serialized Format (ISF) stream.</td><td>No effect. Pressure data, if present, is written to the Ink Serialized Format (ISF) stream</td></tr>
   <tr><th>Load</th><td>Depending on the implementation, pressure data from Ink Serialized Format (ISF) stream may be ignored during rendering.</td><td>Depending on the implementation, pressure data from Ink Serialized Format (ISF) stream may be applied during rendering.</td></tr>
</table>

## -examples
The following example demonstrates how to set the [IgnorePressure](inkdrawingattributes_ignorepressure.md) attribute for all strokes managed by this [InkManager](inkmanager.md) object (`inkManager`) that are created after the [SetDefaultDrawingAttributes](inkmanager_setdefaultdrawingattributes.md) method call.

```

var inkManager = new Windows.UI.Input.Inking.InkManager();
var drawingAttributes = new Windows.UI.Input.Inking.InkDrawingAttributes();
drawingAttributes.ignorePressure = true;
inkManager.setDefaultDrawingAttributes(drawingAttributes);

```



For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[Pressure](inkstrokerenderingsegment_pressure.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)