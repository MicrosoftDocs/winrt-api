---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundDownloader.GetCurrentDownloadsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.BackgroundTransfer.DownloadOperation>> GetCurrentDownloadsAsync()
-->

# Windows.Networking.BackgroundTransfer.BackgroundDownloader.GetCurrentDownloadsAsync

## -description
Returns a collection of pending downloads that are not associated with a BackgroundTransferGroup.

## -returns
A collection of pending downloads for the current application instance.

## -remarks
On Windows Phone, this method will return the error code HRESULT: 0x80040154 (REGDB_E_CLASSNOTREG) if the Internet capability is not declared in your app manifest. On Windows, this method will return the error code HRESULT: 0x80070005 (E_ACCESSDENIED) if the Internet capability is not declared in your app manifest. This capability is enabled by default in all Store app project templates.

## -examples

## -see-also
[GetCurrentDownloadsAsync(String)](backgrounddownloader_getcurrentdownloadsasync_405117897.md)