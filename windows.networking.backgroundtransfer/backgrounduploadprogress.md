---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundUploadProgress
-api-type: winrt struct
---

<!-- Structure syntax.
public struct BackgroundUploadProgress 
-->

# BackgroundUploadProgress

## -description
Contains status information about the upload operation.

## -struct-fields

### -field BytesReceived
The total number of bytes received. This value does not include bytes received as part of response headers. If the upload operation has restarted, this value may be smaller than in the previous progress report.
    

### -field BytesSent
The total number of bytes sent. If the upload operation has restarted, this value may be smaller than in the previous progress report.
    

### -field TotalBytesToReceive
The total number of bytes of data to upload. If this number is unknown, this value is set to 0.
    

### -field TotalBytesToSend
The total number of bytes to upload.
    

### -field Status
The current status of the upload operation.
    

### -field HasResponseChanged
TRUE if the upload request response has changed; otherwise, FALSE.

Whenever new response information is available due to a new request being invoked, this field is set to true. The application can then choose to read the new response information and update its state, if needed.
    

### -field HasRestarted
**true** if a upload transfer operation has restarted; otherwise **false**.

Uploads cannot be resumed. Whenever a new request is sent to the server to restart the upload, this property is set to **true** in the first progress notification for the new request. After the first progress notification, **HasRestarted** is set to **false** in later notifications.
    

## -remarks

## -examples

## -see-also
[BackgroundDownloadProgress](backgrounddownloadprogress.md), [Progress](uploadoperation_progress.md), [UploadOperation](uploadoperation.md)