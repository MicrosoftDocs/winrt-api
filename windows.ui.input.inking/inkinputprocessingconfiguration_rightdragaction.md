---
-api-id: P:Windows.UI.Input.Inking.InkInputProcessingConfiguration.RightDragAction
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.InkInputRightDragAction RightDragAction { get;  set; }
-->

# Windows.UI.Input.Inking.InkInputProcessingConfiguration.RightDragAction

## -description
Gets or sets how the [InkPresenter](inkpresenter.md) object handles secondary input from a pen barrel button, pen eraser tip, right mouse button, or similar.

By default, this secondary input is processed as primary input and rendered as an [InkStroke](inkstroke.md) (see remarks).

## -property-value
The input behavior when modified with a secondary affordance.

## -remarks
To pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing, set RightDragAction to [LeaveUnprocessed](inkinputrightdragaction.md).

## -examples
Here, we set RightDragAction to [LeaveUnprocessed](inkinputrightdragaction.md) and declare [UnprocessedInput](inkpresenter_unprocessedinput.md) event listeners for pointer input.

```csharp
inkCanvas.InkPresenter.InputProcessingConfiguration.RightDragAction = 
  InkInputRightDragAction.LeaveUnprocessed;

inkCanvas.InkPresenter.UnprocessedInput.PointerPressed += 
  UnprocessedInput_PointerPressed;
inkCanvas.InkPresenter.UnprocessedInput.PointerMoved += 
  UnprocessedInput_PointerMoved;
inkCanvas.InkPresenter.UnprocessedInput.PointerReleased += 
  UnprocessedInput_PointerReleased;
```

Here, we define the custom event handlers for pointer input. The handlers are used to implement ink stroke selection.

```csharp
private void UnprocessedInput_PointerPressed(InkUnprocessedInput sender, Windows.UI.Core.PointerEventArgs args)
{
  lasso = new Polyline()
  {
    Stroke = new SolidColorBrush(Windows.UI.Colors.Blue),
    StrokeThickness = 1,
    StrokeDashArray = new DoubleCollection() {5, 2},
  };

  lasso.Points.Add(args.CurrentPoint.RawPosition);

  selectionCanvas.Children.Add(lasso);
}

private void UnprocessedInput_PointerMoved(InkUnprocessedInput sender, Windows.UI.Core.PointerEventArgs args)
{
  lasso.Points.Add(args.CurrentPoint.RawPosition);
}

private void UnprocessedInput_PointerReleased(InkUnprocessedInput sender, Windows.UI.Core.PointerEventArgs args)
{
  lasso.Points.Add(args.CurrentPoint.RawPosition);

  boundingRect = inkCanvas.InkPresenter.StrokeContainer.SelectWithPolyLine(lasso.Points);

  DrawBoundingRect();
}
```



## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)

