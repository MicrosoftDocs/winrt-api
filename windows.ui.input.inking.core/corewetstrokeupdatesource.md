---
-api-id: T:Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource
-api-type: winrt class
---

<!-- Class syntax.
public class CoreWetStrokeUpdateSource : Windows.UI.Input.Inking.Core.ICoreWetStrokeUpdateSource
-->

# Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource

## -description
Represents the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) that manages the input, processing, and rendering of ink stroke data.

## -remarks
Standard [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md) events occur after ink strokes have been rendered.

Use the [Windows.UI.Input.Inking.Core](windows_ui_input_inking_core.md) events to process "wet" ink data before it is rendered by the [InkPresenter](coreinkindependentinputsource_inkpresenter.md). This can be useful when providing a digital stencil, such as a ruler or protractor, to constrain and modify a stroke while it is "wet", or mask select areas of the canvas from ink strokes.

An ink stroke always triggers either a [WetStrokeCompleted](corewetstrokeupdatesource_wetstrokecompleted.md) or a [WetStrokeCanceled](corewetstrokeupdatesource_wetstrokecanceled.md) event.

## -examples

## -see-also
[Windows.UI.Input.Inking.Core classes](windows_ui_input_inking_core_classes.md), [Pen and stylus interactions](https://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620314)
