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
Call CancelIOAsync to cancel any pending reads or writes on this socket before you call [TransferOwnership](/uwp/api/windows.networking.sockets.streamsocketlistener.transferownership) when your app is about to be suspended.



> [!NOTE]
> CancelIOAsync cancels pending writes and reads in the Windows Runtime, but if there is a write buffer pending in networking drivers, it flushes the write.

## -examples

## -see-also
