---
-api-id: M:Windows.Networking.Sockets.StreamSocket.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Networking.Sockets.StreamSocket.Close

## -description
Closes the [StreamSocket](streamsocket.md) object.

## -remarks
The Close method aborts any pending operations and releases all unmanaged resources associated with the [StreamSocket](streamsocket.md) object. Aborting pending read operations on an [InputStream](streamsocket_inputstream.md) or aborting pending write operations on an [OutputStream](streamsocket_outputstream.md) will also result in the [StreamSocket](streamsocket.md) object being closed.

The Close is used by UWP apps written in JavaScript. For apps written using the .NET Framework 4.5 in C# and VB.NET, the Close method is exposed as the [Dispose()](/uwp/api/Windows.Networking.Sockets.StreamSocket.Dispose) method on the [StreamSocket](streamsocket.md). For apps written in C++, the Close method will be called when using the delete keyword on the object.

## -examples

## -see-also


## -capabilities
ID_CAP_NETWORKING [Windows Phone]
