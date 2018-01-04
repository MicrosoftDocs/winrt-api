---
-api-id: M:Windows.Networking.Sockets.MessageWebSocket.SendFinalFrameAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<uint, uint> MessageWebSocket.SendFinalFrameAsync(IBuffer data)
-->

# Windows.Networking.Sockets.MessageWebSocket.SendFinalFrameAsync

## -description
Asynchronously (with progress) writes a frame of data in a sequential stream, with the semantics that this is the last frame in a WebSocket message (the FIN bit on this frame is set to 1). This method and [SendNonfinalFrameAsync](messagewebsocket_sendnonfinalframeasync_1560905117.md) allow you to send individual WebSocket frames.

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
