---
-api-id: T:Windows.UI.Input.Inking.IInkPresenterStencil
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IInkPresenterStencil : 
-->

# Windows.UI.Input.Inking.IInkPresenterStencil

## -description
Represents a visual stencil, displayed as an semi-transparent overlay on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).


The stencil transforms how an ink stroke is rendered:

+ It snaps the ink stroke to the stencil edge if the pen tip is within a distance threshold (gutter).
+ It acts as a mask and prevents the drawing of an ink stroke within the area obscured by the stencil.


The stencil can be manipulated both programmatically and by the user. It also scales and translates with the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

## -remarks

## -examples

## -see-also
[Windows.UI.Input.Inking Interfaces](windows_ui_input_inking_interfaces.md)