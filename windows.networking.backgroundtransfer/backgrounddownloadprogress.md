---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundDownloadProgress
-api-type: winrt struct
---

<!-- Structure syntax.
public struct BackgroundDownloadProgress 
-->

# BackgroundDownloadProgress

## -description
Contains status information about the download operation.

## -struct-fields

### -field BytesReceived
The total number of bytes received. This value does not include bytes received as response headers. If the download operation has restarted, this value may be smaller than in the previous progress report.

### -field TotalBytesToReceive
The total number of bytes of data to download. If this number is unknown, this value is set to 0.

### -field Status
A [BackgroundTransferStatus](backgroundtransferstatus.md) containing the current status of the download operation.

### -field HasResponseChanged
**true** if the download request response has changed; otherwise, **false**.

Whenever new response information is available due to a new request being invoked, this field is set to true. The application can then choose to read the new response information and update its state, if needed.

### -field HasRestarted
**true** if a data transfer operation has restarted; otherwise **false**.

When a download is interrupted and a new request is sent to the server to resume the download, **HasRestarted** is set to **true** if the server does not support resume and the download had to start over.

**HasRestarted** is set to **true** only in the first progress notification sent after the restart. After the first progress notification, **HasRestarted** is set to **false** in later notifications.
    
## -remarks

## -examples

## -see-also
[BackgroundTransferStatus](backgroundtransferstatus.md), [BackgroundUploadProgress](backgrounduploadprogress.md), [DownloadOperation](downloadoperation.md), [Progress](downloadoperation_progress.md)
