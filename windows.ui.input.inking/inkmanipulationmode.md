---
-api-id: T:Windows.UI.Input.Inking.InkManipulationMode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkManipulationMode : int
-->

# InkManipulationMode

## -description
Specifies the modes of ink input.

## -enum-fields
### -field Inking:0
All points are passed to the [InkStrokeBuilder](inkstrokebuilder.md) and an [InkStroke](inkstroke.md) is created. The stroke is appended to the stroke collection of the [InkManager](inkmanager.md) or [InkStrokeContainer](inkstrokecontainer.md).

### -field Erasing:1
All strokes are hit tested against all strokes in the stroke collection. If there is an intersection, [InkManager](inkmanager.md) deletes the stroke automatically and returns an invalidated rectangle for [processPointerUpdate](inkmanager_processpointerupdate.md) calls.

### -field Selecting:2
All points are used to create a polyline. When you call [processPointerUp](inkmanager_processpointerup.md), the polyline is hit tested against entire stroke collection and all strokes within the polyline are marked as selected.


## -remarks

## -examples

## -see-also
[Windows.UI.Input.Inking Enumerations](windows_ui_input_inking_enumerations.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)