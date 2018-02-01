---
-api-id: T:Windows.UI.Input.Inking.InkStrokeInput
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkStrokeInput : Windows.UI.Input.Inking.IInkStrokeInput
-->

# Windows.UI.Input.Inking.InkStrokeInput

## -description
Provides properties and events for [StrokeInput](inkpresenter_strokeinput.md) associated with an [InkPresenter](inkpresenter.md) object.

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