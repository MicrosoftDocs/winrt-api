---
-api-id: P:Windows.UI.Input.Inking.InkPresenter.StrokeInput
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.InkStrokeInput StrokeInput { get; }
-->

# Windows.UI.Input.Inking.InkPresenter.StrokeInput

## -description
Gets an [InkStrokeInput](inkstrokeinput.md) object for managing ink input events.

## -property-value
The ink input.

## -remarks

## -examples
Here, we declare a [StrokeStarted](inkstrokeinput_strokestarted.md) listener.

```csharp
inkCanvas.InkPresenter.StrokeInput.StrokeStarted += StrokeInput_StrokeStarted;
```

We then define the corresponding handler, which clears any selected strokes when a new ink stroke is started.

```csharp
private void StrokeInput_StrokeStarted(InkStrokeInput sender, Windows.UI.Core.PointerEventArgs args)
{
  var strokes = inkCanvas.InkPresenter.StrokeContainer.GetStrokes();
  foreach (var stroke in strokes)
  {
    stroke.Selected = false;
  }
  ClearDrawnBoundingRect();
}
```



## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)