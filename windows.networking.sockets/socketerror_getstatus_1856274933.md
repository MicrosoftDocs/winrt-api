---
-api-id: M:Windows.Networking.Sockets.SocketError.GetStatus(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.Sockets.SocketErrorStatus GetStatus(System.Int32 hresult)
-->

# Windows.Networking.Sockets.SocketError.GetStatus

## -description
Gets a [SocketErrorStatus](socketerrorstatus.md) value based on an error encountered by a socket operation.

## -parameters
### -param hresult
The error encountered by a socket operation represented as an **HRESULT**.

## -returns
The socket error status value for a socket operation.

## -remarks
An error encountered on socket operation is returned as **HRESULT** value. The [GetStatus](socketerror_getstatus.md) method is used to convert an error from a socket operation to a [SocketErrorStatus](socketerrorstatus.md) enumeration value. Most of the [SocketErrorStatus](socketerrorstatus.md) enumeration values correspond to an error returned by the native Windows sockets operation.

The [SocketError](socketerror.md) object and the [GetStatus](socketerror_getstatus.md) method would be used when the developer wants to programmatically handle errors that occur during the operation of an app.

## -examples

## -see-also
[SocketErrorStatus](socketerrorstatus.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]