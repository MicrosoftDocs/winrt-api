---
-api-id: M:Windows.Networking.Sockets.StreamSocketListener.CancelIOAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction CancelIOAsync()
-->

# Windows.Networking.Sockets.StreamSocketListener.CancelIOAsync

## -description
Cancels pending reads and writes over a [StreamSocketListener](streamsocketlistener.md) object.

## -returns
An asynchronous cancel operation on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
Call [CancelIOAsync](streamsocketlistener_cancelioasync.md) to cancel any pending reads or writes on this socket before you call [TransferOwnership](streamsocketlistener_transferownership.md) when your app is about to be suspended.



> [!NOTE]
> [CancelIOAsync](streamsocketlistener_cancelioasync.md) cancels pending writes and reads in the Windows Runtime, but if there is a write buffer pending in networking drivers, it flushes the write.

## -examples

## -see-also
