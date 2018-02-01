---
-api-id: M:Windows.Networking.Sockets.MessageWebSocket.SendNonfinalFrameAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<uint, uint> MessageWebSocket.SendNonfinalFrameAsync(IBuffer data)
-->

# Windows.Networking.Sockets.MessageWebSocket.SendNonfinalFrameAsync

## -description
Asynchronously (with progress) writes a frame of data in a sequential stream, with the semantics that more frames will follow for the same WebSocket message (the FIN bit on this frame is set to 0). This method and [SendFinalFrameAsync](messagewebsocket_sendfinalframeasync_1210635846.md) allow you to send individual WebSocket frames.

## -parameters
### -param data
A buffer containing the data that constitutes the frame to be sent.

## -returns
An asynchronous byte writer operation with progress.

## -remarks

## -see-also

## -examples

## -capabilities
internetClientServer, privateNetworkClientServer
