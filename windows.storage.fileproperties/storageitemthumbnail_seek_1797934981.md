---
-api-id: M:Windows.Storage.FileProperties.StorageItemThumbnail.Seek(System.UInt64)
-api-type: winrt method
---

<!-- Method syntax
public void Seek(System.UInt64 position)
-->

# Windows.Storage.FileProperties.StorageItemThumbnail.Seek

## -description
Sets the offset of the thumbnail stream to the specified value.

## -parameters
### -param position
The number of bytes from the start of the thumbnail stream where the position of the thumbnail stream is set.

## -remarks
> [!WARNING]
> This method does not check *position* to make sure the value is valid. If the value is invalid for the stream, the [readAsync](storageitemthumbnail_readasync_1012630619.md) and [writeAsync](storageitemthumbnail_writeasync_897036872.md) methods will return error if they are called.

## -examples

## -see-also
