---
-api-id: M:Windows.Networking.Sockets.StreamSocket.CancelIOAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction CancelIOAsync()
-->

# Windows.Networking.Sockets.StreamSocket.CancelIOAsync

## -description
Cancels pending reads and writes over a [StreamSocket](streamsocket.md) object.

## -returns
An asynchronous cancel operation on a [StreamSocket](streamsocket.md) object.

## -remarks
Call [CancelIOAsync](streamsocket_cancelioasync_169683529.md) to cancel any pending reads or writes on this socket before you call [TransferOwnership](streamsocket_transferownership_1291619316.md) when your app is about to be suspended.

[CancelIOAsync](streamsocket_cancelioasync_169683529.md) does not guarantee that all read/write completion handlers have finished executing before it signals completion. It does, however, guarantee that all I/O operations will have reached a terminal state (either Completed or Error) by the time it signals completion. If your app needs to wait for all pending I/O operation handlers to finish executing, you must implement your own app-level sychronization logic. The [Socket Activity Stream Socket](https://go.microsoft.com/fwlink/p/?LinkId=620606) sample demonstrates one way to do this.



> [!NOTE]
> [CancelIOAsync](streamsocket_cancelioasync_169683529.md) cancels pending writes and reads in the Windows Runtime, but if there is a write buffer pending in networking drivers, it flushes the write.

## -examples

## -see-also
