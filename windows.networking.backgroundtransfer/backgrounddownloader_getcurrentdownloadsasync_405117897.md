---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundDownloader.GetCurrentDownloadsAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.BackgroundTransfer.DownloadOperation>> GetCurrentDownloadsAsync(System.String group)
-->

# Windows.Networking.BackgroundTransfer.BackgroundDownloader.GetCurrentDownloadsAsync

## -description
> [!NOTE]
> [GetCurrentDownloadsAsync(group)](backgrounddownloader_getcurrentdownloadsasync_405117897.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [GetCurrentDownloadsForTransferGroupAsync](backgrounddownloader_getcurrentdownloadsfortransfergroupasync_1466993145.md).

Returns a collection of pending downloads for a specific [Group](backgrounddownloader_group.md).

## -parameters
### -param group
A string indicating a specific group of transfers.

## -returns
A collection of pending downloads for the specific group.

## -remarks
On Windows Phone, this method will return the error code HRESULT: 0x80040154 (REGDB_E_CLASSNOTREG) if the Internet capability is not declared in your app manifest. On Windows, this method will return the error code HRESULT: 0x80070005 (E_ACCESSDENIED) if the Internet capability is not declared in your app manifest. This capability is enabled by default in all Store app project templates.

## -examples

## -see-also
[GetCurrentDownloadsAsync](backgrounddownloader_getcurrentdownloadsasync_1101292265.md)