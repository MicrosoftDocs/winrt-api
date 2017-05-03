---
-api-id: M:Windows.UI.Input.Inking.InkStrokeContainer.LoadAsync(Windows.Storage.Streams.IInputStream)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncActionWithProgress<ulong> LoadAsync(Windows.Storage.Streams.IInputStream inputStream)
-->

# Windows.UI.Input.Inking.InkStrokeContainer.LoadAsync

## -description
Asynchronously loads all [InkStroke](inkstroke.md) objects from the specified stream to the [InkStroke](inkstroke.md) collection that is managed by the [InkStrokeContainer](inkstrokecontainer.md).

> All existing strokes in the [InkStrokeContainer](inkstrokecontainer.md) are cleared before new strokes are loaded.

## -parameters
### -param inputStream
The target stream.

## -returns
The status of the asynchronous operation as the number of bytes fetched. For more information, see [ReadAsync](http://msdn.microsoft.com/library/4d5046c8-a1d2-435f-9c3d-64c242fc20cf) method.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)