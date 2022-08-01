---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarTool
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.InkToolbarTool : int
-->

# InkToolbarTool

## -description
Defines constants that specify the type of built-in or custom tool associated with the [InkToolbarToolButton](inktoolbartoolbutton.md).

## -enum-fields
### -field BallpointPen:0
A pen tool that renders a solid, opaque stroke, with the stroke size dependent on the pen pressure detected (default size is 2x2 pixels).

### -field Pencil:1
A pen tool that renders a soft-edged, semi-transparent stroke that can be layered for shading effects. The stroke opacity is dependent on the pen pressure detected.

### -field Highlighter:2
A pen tool that renders a semi-transparent highlighter overlay stroke.

### -field Eraser:3
A pen tool that deletes any ink strokes that intersect with the erase stroke.

### -field CustomPen:4
A custom pen tool.

### -field CustomTool:5
A custom non-pen tool.


## -remarks

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
