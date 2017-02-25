---
-api-id: M:Windows.UI.Input.Inking.InkStrokeContainer.SaveAsync(Windows.Storage.Streams.IOutputStream,Windows.UI.Input.Inking.InkPersistenceFormat)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<uint, uint> SaveAsync(Windows.Storage.Streams.IOutputStream outputStream, Windows.UI.Input.Inking.InkPersistenceFormat inkPersistenceFormat)
-->

# Windows.UI.Input.Inking.InkStrokeContainer.SaveAsync

## -description
Asynchronously saves all [InkStroke](inkstroke.md) objects in the [InkStroke](inkstroke.md) collection that is managed by the [InkStrokeContainer](inkstrokecontainer.md) to the specified stream and in the specified format.

## -parameters
### -param outputStream
The target stream. An [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) (requires [IOutputStream](../windows.storage.streams/ioutputstream.md)) object can be specified instead.

### -param inkPersistenceFormat
The format in which to save the ink input.

## -returns
The status of the asynchronous operation as the number of bytes sent. For more information, see [WriteAsync](http://msdn.microsoft.com/library/530f0755-c2f7-4b35-a641-039be007ba0f) method.

## -remarks

## -examples

## -see-also
- [InkPersitenceFormat](inkpersistenceformat.md)
- [InkStrokeContainer.SaveAsync(Windows.Storage.Streams.IOutputStream outputStream)](inkstrokecontainer_saveasync_1696379726.md)
- [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)
- [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)