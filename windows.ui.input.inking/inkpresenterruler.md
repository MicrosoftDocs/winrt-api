---
-api-id: T:Windows.UI.Input.Inking.InkPresenterRuler
-api-type: winrt class
---

<!-- Class syntax.
public class InkPresenterRuler : Windows.UI.Input.Inking.IInkPresenterRuler, Windows.UI.Input.Inking.IInkPresenterRuler2, Windows.UI.Input.Inking.IInkPresenterStencil
-->

# Windows.UI.Input.Inking.InkPresenterRuler

## -description
Represents a visual stencil, in the form of a straight rule for drawing straight lines, displayed as a semi-transparent overlay on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).


The stencil transforms how an ink stroke is rendered:

+ It snaps the ink stroke to the stencil edge if the pen tip is within a distance threshold (gutter).
+ It acts as a mask and prevents the drawing of an ink stroke within the area obscured by the stencil.


The [InkPresenterRuler](inkpresenterruler.md) can be manipulated both programmatically and by the user. It also scales and translates with the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

## -remarks
The opacity of the stencil is set at 75% when static, and 50% during manipulation.

## -examples

## -see-also
[IInkPresenterStencil](iinkpresenterstencil.md), [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md), [InkToolbarRulerButton](../windows.ui.xaml.controls/inktoolbarrulerbutton.md)