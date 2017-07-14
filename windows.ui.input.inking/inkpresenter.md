---
-api-id: T:Windows.UI.Input.Inking.InkPresenter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkPresenter : Windows.UI.Input.Inking.IInkPresenter, Windows.UI.Input.Inking.IInkPresenter2
-->

# Windows.UI.Input.Inking.InkPresenter

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Provides properties, methods, and events for managing the input, processing, and rendering of ink input (standard and modified) for an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

> [!NOTE]
> Standard ink input (pen tip or eraser tip/button) is not modified with a secondary affordance, such as a pen barrel button, right mouse button, or similar (see [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md)).

By default, both standard and modified ink input is managed entirely by the [InkPresenter](inkunprocessedinput_inkpresenter.md) and rendered to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) as either an ink stroke or an erase stroke, based on [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md). We recommend that you limit default processing by the [InkPresenter](inkunprocessedinput_inkpresenter.md) to moderate inking scenarios such as collecting signatures, adding annotations, and so on. For more robust inking scenarios, use custom drying (described later in this section).

Modified input can be passed through to your app for processing by setting [InkInputProcessingConfiguration.RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) to [InkInputRightDragAction.LeaveUnprocessed](inkinputrightdragaction.md).

All input can be passed through to your app for processing by setting [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) to [None](inkinputprocessingmode.md).

Leaving input unprocessed by the [InkPresenter](inkunprocessedinput_inkpresenter.md) lets you support a customized ink experience and extended functionality such as selection.

For complete control of ink input and to render it to the Direct2D device context of your Universal Windows app, instead of the default [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control, call [ActivateCustomDrying](inkpresenter_activatecustomdrying.md) prior to loading the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md). This requires an [IInkD2DRenderer](http://msdn.microsoft.com/library/d1bd910d-ce64-4424-a0e1-4f55110b0265) object to manage the ink input (see the [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)). We also recommend custom drying for more robust inking scenarios where a large number of ink strokes must be supported, such as sketching and notetaking. 

## -remarks
The [InkPresenter](inkpresenter.md) class cannot be instantiated directly. It is returned as a property of an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) object.

## -examples
Here, we show how to overlay ink annotations on an image. For this example, ink data is not captured or saved by a corresponding [InkPresenter](inkpresenter.md).

```xaml
<ScrollViewer>
  <Grid>
    <Image Source="<path>"></Image>
    <InkCanvas x:Name="MyInkCanvas"></InkCanvas>
  </Grid>
</ScrollView
```

Here, we configure the [InkPresenter](../windows.ui.xaml.controls/inkcanvas_inkpresenter.md) to interpret input data from both pen and mouse as ink strokes. We also set some initial ink stroke attributes used for rendering strokes to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).



[TODO:AUTO_SNIPPET (SAMPLE_ID:Ink_Basic_Customization)(SNIPPET_ID:SetInitialStrokeAttributes)]Ink stroke attributes can be set dynamically to accommodate user preferences or app requirements.

Here, we let a user choose from a list of ink colors.



[TODO:AUTO_SNIPPET (SAMPLE_ID:Ink_Basic_Customization)(SNIPPET_ID:UI)]We then handle changes to the selected color and update the ink stroke attributes accordingly.



[TODO:AUTO_SNIPPET (SAMPLE_ID:Ink_Basic_Customization)(SNIPPET_ID:SetColorStrokeAttribute)]

## -see-also
[Windows.UI.Input.Inking Classes](windows_ui_input_inking_classes.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)
