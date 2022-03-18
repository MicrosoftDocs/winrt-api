---
-api-id: M:Windows.Networking.BackgroundTransfer.DownloadOperation.SetRequestHeader(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetRequestHeader(System.String headerName, System.String headerValue)
-->

## -description

Used to set an HTTP request header.

## -parameters

### -param headerName
The header name.

### -param headerValue
The header value.

## -remarks
This method allows the caller to set request headers. This method can be called multiple times for the same header. The values will then be concatenated.

## -see-also

## -examples