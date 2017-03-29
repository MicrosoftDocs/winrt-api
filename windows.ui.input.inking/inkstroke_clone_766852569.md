---
-api-id: M:Windows.UI.Input.Inking.InkStroke.Clone
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Inking.InkStroke Clone()
-->

# Windows.UI.Input.Inking.InkStroke.Clone

## -description
Copies the [InkStroke](inkstroke.md) to another [InkManager](inkmanager.md) (or [InkStrokeContainer](inkstrokecontainer.md)).

## -returns
The new stroke.

## -remarks
This method must be used with [AddStroke](inkmanager_addstroke.md) ([InkManager](inkmanager.md)) or [AddStroke](inkstrokecontainer_addstroke.md) ([InkStrokeContainer](inkstrokecontainer.md)).

```javascript

inkStrokeContainer.AddStroke(stroke.Clone());
inkManager.AddStroke(stroke.Clone());
```

```csharp
inkStrokeContainer.AddStroke(stroke.Clone());
inkManager.AddStroke(stroke.Clone());
```



## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)