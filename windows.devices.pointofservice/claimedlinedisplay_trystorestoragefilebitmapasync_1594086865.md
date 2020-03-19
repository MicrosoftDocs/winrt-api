---
-api-id: M:Windows.Devices.PointOfService.ClaimedLineDisplay.TryStoreStorageFileBitmapAsync(Windows.Storage.StorageFile,Windows.Devices.PointOfService.LineDisplayHorizontalAlignment,Windows.Devices.PointOfService.LineDisplayVerticalAlignment)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<LineDisplayStoredBitmap> ClaimedLineDisplay.TryStoreStorageFileBitmapAsync(StorageFile bitmap, LineDisplayHorizontalAlignment horizontalAlignment, LineDisplayVerticalAlignment verticalAlignment)
-->

# Windows.Devices.PointOfService.ClaimedLineDisplay.TryStoreStorageFileBitmapAsync

## -description
Attempts to asynchronously store a bitmap image from a [StorageFile](../windows.storage/storagefile.md) for later display on the line display device.

## -parameters
### -param bitmap
A [StorageFile](../windows.storage/storagefile.md) that represents a local bitmap file. All line displays support black and white uncompressed Windows bitmaps. Check device specifications for other supported formats. 

### -param horizontalAlignment
Determines how the bitmap will be horizontally aligned relative to its originating character cell.

### -param verticalAlignment
Determines how the bitmap will be vertically aligned relative to its originating character cell.

## -returns
True if the bitmap is stored successfully, False if a failure occurs.

## -remarks
- The bitmap [StorageFile](../windows.storage/storagefile.md) must be backed by a local file. If it is created from a stream, a URI or another source this method will throw an exception.
- Calling this method when [LineDisplayCapabiliaties.CanDisplayBitmaps](LineDisplayCapabilities_CanDisplayBitmaps.md) is False will result in an exception.
- Up to 100 bitmaps can be stored using this method. Attempting to store more than 100 bitmaps will result in an exception. Delete unused bitmaps using [LineDisplayStoredBitmap.TryDeleteAsync](linedisplaystoredbitmap_trydeleteasync_41251962.md).

## -see-also
[LineDisplayStoredBitmap.EscapeSequence](LineDisplayStoredBitmap_EscapeSequence.md),
[LineDisplayWindow.TryDisplayStoredBitmapAtCursorAsync(LineDisplayStoredBitmap)](linedisplaywindow_trydisplaystoredbitmapatcursorasync_100389007.md),
[LineDisplayStoredBitmap.TryDeleteAsync()](linedisplaystoredbitmap_trydeleteasync_41251962.md)

## -examples

