---
-api-id: M:Windows.UI.Input.Inking.InkManager.SaveAsync(Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<uint, uint> SaveAsync(Windows.Storage.Streams.IOutputStream outputStream)
-->

# Windows.UI.Input.Inking.InkManager.SaveAsync

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Asynchronously saves all [InkStroke](inkstroke.md) objects in the [InkStroke](inkstroke.md) collection that is managed by the [InkManager](inkmanager.md) to the specified stream.

Ink data is serialized as Ink Serialized Format (ISF) metadata and embedded into a Graphics Interchange Format (GIF) file.

## -parameters
### -param outputStream
The target stream. An [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) (requires [IOutputStream](../windows.storage.streams/ioutputstream.md)) object can be specified instead.

## -returns
The size of the saved stream and the status of the asynchronous operation as the number of bytes sent. For more information, see [WriteAsync](http://msdn.microsoft.com/library/530f0755-c2f7-4b35-a641-039be007ba0f) method.

## -remarks
Embedding the metadata into a Graphics Interchange Format (GIF) file enables ink to be viewed in applications that are not ink-enabled while maintaining full fidelity for ink-enabled applications. This format is ideal for transporting ink content within an HTML file and making it usable by both ink and non-ink applications. 

> [!NOTE]
> Ink Serialized Format (ISF) is the most compact persistent representation of ink. It can be embedded within a binary document format or placed directly on the Clipboard while preserving various ink properties such as pressure, width, color, tilt, twist, and so on.

## -examples
The `saveStrokes` function in this example demonstrates how to:
+ Display a file save screen where the file type is constrained to Graphics Interchange Format (GIF) format using the [FileSavePicker](../windows.storage.pickers/filesavepicker.md) object.
+ Set up an output stream through the [OpenAsync](../windows.storage/storagefile_openasync.md) method.
+ Use the [SaveAsync](inkmanager_saveasync.md) method of an [InkManager](inkmanager.md) object (`inkManager`) to serialize the ink data to an output stream and embed it into a Graphics Interchange Format (GIF) file (`storageFile`).




[!code-js[SaveStrokes](../windows.ui.input.inking/code/CaptureInkData_JS/js/InkPage.js#SnippetSaveStrokes)]

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)
