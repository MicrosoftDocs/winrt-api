---
-api-id: M:Windows.Networking.Sockets.WebSocketError.GetStatus(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Web.WebErrorStatus GetStatus(System.Int32 hresult)
-->

# Windows.Networking.Sockets.WebSocketError.GetStatus

## -description
Gets a [WebErrorStatus](../windows.web/weberrorstatus.md) value based on an error encountered by a WebSocket operation.

## -parameters
### -param hresult
The error encountered by a WebSocket operation represented as an **HRESULT**.

## -returns
The socket error status value for a WebSocket operation.

## -remarks
An error encountered on a WebSocket operation is returned as **HRESULT** value. The [GetStatus](websocketerror_getstatus.md) method is used to convert an error from a WebSocket operation to a [WebErrorStatus](../windows.web/weberrorstatus.md) enumeration value. This can be useful for handling errors programmatically.

## -examples

## -see-also
[SocketErrorStatus](socketerrorstatus.md)