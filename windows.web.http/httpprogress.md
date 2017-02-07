---
-api-id: T:Windows.Web.Http.HttpProgress
-api-type: winrt struct
---

<!-- Structure syntax.
public struct HttpProgress 
-->

# HttpProgress

## -description
Contains status information on the progress of an [HttpClient](httpclient.md) operation.

## -struct-fields

### -field Stage
The step in the progress of an HTTP connection.
    

### -field BytesSent
The total number of bytes sent.

This value includes bytes sent as request headers.

If the operation was restarted, this value may be smaller than in the previous progress report.
    

### -field TotalBytesToSend
The total number of data bytes to send.

If the number is unknown, this value is 0.
    

### -field BytesReceived
The total number of bytes received.

This value includes bytes received as response headers.

If the operation was restarted, this value may be smaller than in the previous progress report.
    

### -field TotalBytesToReceive
The total number of data bytes to receive.

If the number is unknown, this value is 0.
    

### -field Retries
The number of retries.
    

## -remarks
When sending (POST method) an [HttpBufferContent](httpbuffercontent.md) class, the  value jumps from 0% bytes sent to 100% bytes sent in one progress event, because the whole buffer is moved to lower network APIs all at once. For more detailed progress, use [HttpStreamContent](httpstreamcontent.md) instead of [HttpBufferContent](httpbuffercontent.md), because streams are read and sent in smaller chunks, resulting in more progress events. E.g. 0 bytes sent, 65536 bytes sent, 131072 bytes sent, etc.

## -examples

## -see-also
[HttpClient](httpclient.md)