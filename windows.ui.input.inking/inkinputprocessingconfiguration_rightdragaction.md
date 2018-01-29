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
To pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing, set [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) to [LeaveUnprocessed](inkinputrightdragaction.md).

## -examples
Here, we set [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) to [LeaveUnprocessed](inkinputrightdragaction.md) and declare [UnprocessedInput](inkpresenter_unprocessedinput.md) event listeners for pointer input.

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
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)