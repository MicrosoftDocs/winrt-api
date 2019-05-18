---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundUploader.GetCurrentUploadsAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.BackgroundTransfer.UploadOperation>> GetCurrentUploadsAsync(System.String group)
-->

# Windows.Networking.BackgroundTransfer.BackgroundUploader.GetCurrentUploadsAsync

## -description
> [!NOTE]
> GetCurrentUploadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use [GetCurrentUploadsForTransferGroupAsync](backgrounduploader_getcurrentuploadsfortransfergroupasync_467871446.md).

Returns a collection of pending uploads for a specific [Group](backgrounddownloader_group.md).

## -parameters
### -param group
A string indicating a specific group of uploads.

## -returns
A collection of pending uploads for the specific group.

## -remarks

## -examples

## -see-also
[GetCurrentUploadsAsync](backgrounduploader_getcurrentuploadsasync_1938169689.md)
